using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmThanh
{
   public class Channelsss
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Channel;
        public Channelsss(int ID,string Name,int Channel) {
            this.ID = ID;
            this.Name = Name;
            this.Channel = Channel;
        }
    }
}
