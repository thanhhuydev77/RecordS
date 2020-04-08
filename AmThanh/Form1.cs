using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Windows.Forms;

using NAudio.CoreAudioApi;
using NAudio.Wave;

using VisioForge.Types.OutputFormat;
namespace AmThanh
{
    public partial class Form1 : Form
    {


        WasapiCapture sourceStream;
        WasapiLoopbackCapture sourceStream1;
        WaveFileWriter waveWriter;
        WaveFileWriter waveWriter2;
        BlockAlignReductionStream steam;
        BlockAlignReductionStream steam2;
        DirectSoundOut output;
        DirectSoundOut output2;
        DirectoryInfo d;
        string currentrecord;
        void setdefaul()
        {
            sbtRecord.Enabled = true;
            sbtPlay.Enabled = false;
            this.sbtStop.Enabled = false;
            sbtSave.Enabled = false;
            sbtPause.Enabled = false;
            cdDelete.Checked = true;
            txtTenFile.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
            setdefaul();
            txtPathSave.Text = System.IO.Path.GetDirectoryName(@"C:\Users\huy\Desktop\myrecord\");
            d = new DirectoryInfo(txtPathSave.Text);//Assuming Test is your Folder    
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            List<Channelsss> _listChannal = new List<Channelsss>();
            _listChannal.Add(new Channelsss(-1, "System - Speaker", 0));
            int ii = 0;
            foreach (var source in sources)
            {
                Channelsss _itemChannel = new Channelsss(ii, source.ProductName, source.Channels);
                _listChannal.Add(_itemChannel);
                ii++;
            }

            txtTenFile.Focus();
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - 283, 100);

        }

        private void btRecord_Click(object sender, EventArgs e)
        {
            if (txtTenFile.Text == string.Empty)
            {
                MessageBox.Show("Please type the name first!");
                txtTenFile.Focus();
                return;
            }

            DisposWave();
            if (!Directory.Exists(txtPathSave.Text))
            {
                Directory.CreateDirectory(txtPathSave.Text);
            }
            sbtStop.Enabled = true;
            sbtStop.Focus();
            //sourceStream.DataAvailable += this.SourceStreamDataAvailable;

            //if ((int)cbMic.SelectedValue == -1) //Speaker

            sourceStream1 = new WasapiLoopbackCapture();
            sourceStream1.DataAvailable += SourceStreamDataAvailable;
            waveWriter = new WaveFileWriter(txtPathSave.Text + @"\" + txtTenFile.Text + ".wav", sourceStream1.WaveFormat);


            var enumerator = new MMDeviceEnumerator();
            var captureDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToArray();
            var defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
            var device = captureDevices.FirstOrDefault(c => c.ID == defaultDevice.ID);
            sourceStream = new WasapiCapture(device);

            sourceStream.DataAvailable += this.SourceStreamDataAvailable2;

            waveWriter2 = new WaveFileWriter(txtPathSave.Text + @"\" + txtTenFile.Text + "mic.wav", sourceStream.WaveFormat);



            sourceStream1.StartRecording();
            sourceStream.StartRecording();
            currentrecord = txtPathSave.Text + @"\" + txtTenFile.Text + ".wav";

            // MessageBox.Show(cbMic.SelectedIndex.ToString());
            this.sbtRecord.Enabled = false;
            this.sbtStop.Enabled = true;
        }


        public void SourceStreamDataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                if (waveWriter == null) return;
                waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
                waveWriter.Flush();
            }
            catch
            {
                MessageBox.Show("have errror", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SourceStreamDataAvailable2(object sender, WaveInEventArgs e)
        {

            if (waveWriter2 == null) return;
            waveWriter2.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter2.Flush();
        }

        private void btStop_Click(object sender, EventArgs e)
        {

            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }

            if (sourceStream1 != null)
            {


                sourceStream1.StopRecording();
                sourceStream1.Dispose();
                sourceStream1 = null;
            }
            if (this.waveWriter == null)
            {
                return;
            }
            this.waveWriter.Dispose();
            waveWriter2.Dispose();
            this.waveWriter = null;
            waveWriter2 = null;
            this.sbtRecord.Enabled = false;
            this.sbtStop.Enabled = false;
            sbtPlay.Enabled = true;
            sbtPlay.Focus();

            //mix();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            sbtPlay.Enabled = false;
            sbtSave.Enabled = true;
            sbtSave.Focus();
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = currentrecord;
            DisposWave();
            if (open.FileName.EndsWith(".mp3"))
            {
                WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(open.FileName));
                steam = new BlockAlignReductionStream(pcm);
            }
            else if (open.FileName.EndsWith(".wav"))
            {
                WaveStream pcm = new WaveChannel32(new WaveFileReader(open.FileName));
                steam = new BlockAlignReductionStream(pcm);
            }
            else throw new InvalidOperationException("ko phai file audio");
            txtTenFile.Text = open.SafeFileName;

            WaveStream pcm2 = new WaveChannel32(new WaveFileReader(open.FileName.Replace(".wav", "mic.wav")));
            steam2 = new BlockAlignReductionStream(pcm2);

            output = new DirectSoundOut();
            output2 = new DirectSoundOut();
            sourceStream1 = new WasapiLoopbackCapture();
            sourceStream1.DataAvailable += SourceStreamDataAvailable;
            waveWriter = new WaveFileWriter(txtPathSave.Text + @"\" + txtTenFile.Text.Replace(".wav", "mix") + ".wav", sourceStream1.WaveFormat);

            sourceStream1.StartRecording();
            output.Init(steam);

            output.Play();

            output2.Init(steam2);
            output2.Play();

        }

        public void DisposWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (steam != null)
            {
                steam.Dispose();
                steam = null;
            }
        }

        private void btPause_Click(object sender, EventArgs e)
        {

            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {

                    output.Pause();
                }
                else if (output.PlaybackState == PlaybackState.Paused)
                {

                    sbtPause.Enabled = false;
                    sbtOpen.Focus();
                    output.Play();
                    //MessageBox.Show(output.PlaybackState.ToString());
                }

            }


            //    
        }

        private void sptOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = System.IO.Directory.GetCurrentDirectory();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                //fldrDlg.SelectedPath -- your result
                txtPathSave.Text = folder.SelectedPath;
                d = new DirectoryInfo(txtPathSave.Text);//Assuming Test is your Folder    
            }
        }

        private void txtTenFile_TextChanged(object sender, EventArgs e)
        {
            d = new DirectoryInfo(txtPathSave.Text);
            FileInfo[] Files = d.GetFiles("*.wav"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                if (file.Name.Contains(txtTenFile.Text))
                {
                    label5.Text = file.Name;
                    break;
                }
                label5.Text = "";
            }

        }

        private void sbtSave_Click(object sender, EventArgs e)
        {
            if (sourceStream1 != null)
            {
                sourceStream1.StopRecording();
                sourceStream1.Dispose();
                sourceStream1 = null;
                sbtSave.Enabled = false;
                sbtOpen.Focus();
                txtTenFile.Text = "";
            }
            if (this.waveWriter != null)
            {
                this.waveWriter.Dispose();
                this.waveWriter = null;
            }
            steam.Dispose();
            steam2.Dispose();
            output.Dispose();
            output2.Dispose();
            if (cdDelete.Checked)
            {
                File.Delete(currentrecord);
                File.Delete(currentrecord.Replace(".wav", "mic.wav"));
            }
            setdefaul();
        }

        private void sbtOpen_Click(object sender, EventArgs e)
        {

            sbtPause.Enabled = true;
            sbtPause.Focus();
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = txtPathSave.Text;
            open.Filter = "MP3/WAV File (*.mp3,*.wav)|*.mp3;*.wav";
            if (open.ShowDialog() != DialogResult.OK) return;

            DisposWave();
            if (open.FileName.EndsWith(".mp3"))
            {
                WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(open.FileName));
                steam = new BlockAlignReductionStream(pcm);
            }
            else if (open.FileName.EndsWith(".wav"))
            {
                WaveStream pcm = new WaveChannel32(new WaveFileReader(open.FileName));
                steam = new BlockAlignReductionStream(pcm);
            }
            else throw new InvalidOperationException("ko phai file audio");
            txtTenFile.Text = open.SafeFileName;



            output = new DirectSoundOut();
            output.Init(steam);
            output.Play();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // if (e.KeyChar == (char)Keys.F1)
            // {
            //     btRecord_Click(null, null);
            // }
            // else
            //if (e.KeyChar == (char)Keys.F2)
            // {
            //     btStop_Click(null, null);
            // }
            // else
            //if (e.KeyChar == (char)Keys.F3)
            // {
            //     btPlay_Click(null, null);
            // }
            // else
            //if (e.KeyChar == (char)Keys.F4)
            // {
            //     sbtSave_Click(null, null);
            // }else
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void cdDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cdDelete.Checked)
                cdDelete.ForeColor = Color.FromArgb(0, 255, 21);
            else
                cdDelete.ForeColor = Color.FromArgb(229, 255, 0);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //recording
            //stop record and delete 2 file
            if (sbtStop.Enabled == true)
            {
                if (sourceStream != null)
                {                   
                    sourceStream.StopRecording();
                    sourceStream.Dispose();
                    sourceStream = null;
                }

                if (sourceStream1 != null)
                {
                    
                    sourceStream1.StopRecording();
                    sourceStream1.Dispose();
                    sourceStream1 = null;
                }
                if (this.waveWriter == null)
                {
                    return;
                }
                if (this.waveWriter2 == null)
                {
                    return;
                }
                waveWriter.Dispose();
                waveWriter2.Dispose();

                this.waveWriter = null;
                waveWriter2 = null;

                if (cdDelete.Checked)
                {
                    File.Delete(currentrecord);
                    File.Delete(currentrecord.Replace(".wav", "mic.wav"));
                }

                
            }
            //recorded 2 file wav separate
            //want not to play and delete 2 file
            else if (sbtPlay.Enabled == true)
            {
                if (cdDelete.Checked)
                {
                    File.Delete(currentrecord);
                    File.Delete(currentrecord.Replace(".wav", "mic.wav"));
                }
                
            }
            //recording mix file
            else if(sbtSave.Enabled == true)
            {
                if (sourceStream1 != null)
                {
                    sourceStream1.StopRecording();
                    sourceStream1.Dispose();
                    sourceStream1 = null;
                    sbtSave.Enabled = false;
                    setdefaul();
                    sbtOpen.Focus();
                    txtTenFile.Text = "";
                }
                if (waveWriter != null)
                {
                    waveWriter.Dispose();
                    waveWriter = null;
                }
                steam.Dispose();
                steam2.Dispose();
                output.Dispose();
                output2.Dispose();
                if (cdDelete.Checked)
                {
                    File.Delete(currentrecord);
                    File.Delete(currentrecord.Replace(".wav", "mic.wav"));
                }
                File.Delete(currentrecord.Replace(".wav", "mix.wav"));

                
            }
            setdefaul();
        }
    }
}

