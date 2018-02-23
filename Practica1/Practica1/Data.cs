using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Data
    {
        private uint input;
        private byte direction;
        private byte level;
        private byte sensors;
        private byte dateDay;
        private byte dateMonth;
        private byte dateYear;

        public uint Input { set { this.input = value; } }
        public byte Direction { get { return direction; } }
        public byte Level { get { return level; } }
        public byte Sensors { get { return sensors; } }
        public byte DateDay { get { return dateDay; } }
        public byte DateMonth { get { return dateMonth; } }
        public byte DateYear { get { return dateYear; } }

        public void Procces()
        {
            direction = (byte)(input >> 1 & 7);
            level     = (byte)(input >> 4 & 3);
            sensors   = (byte)(input >> 6 & 3);
            dateDay   = (byte)(input >> 8 & 31);
            dateMonth = (byte)(input >> 13 & 15);
            dateYear  = (byte)(input >> 17 & 127);
        }

        public void SetDate(int day, int month, int year)
        {
            dateDay = (byte)day;
            dateMonth = (byte)month;
            dateYear = (byte)year;
        }

        public UInt16 GetDate()
        {
            return (UInt16)(dateDay + (dateMonth << 5) + (dateYear << 9)); 
        }
    }
}
