using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Programming.Model
{
    public class Song
    {
        private int _minutes;
        private int _seconds;
        private string _composer;
        private string _title;

        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (_minutes < 0 || _minutes > 60)
                    throw new ArgumentException($"{0} is a number out of range", nameof(Minutes));

                _minutes = value;
            }
        }
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (_seconds < 0 || _seconds > 60)
                    throw new ArgumentException($"{0} is a number out of range", nameof(Seconds));

                _seconds = value;
            }
        }
        public string Composer { get; set; }
        public string Title { get; set; }
    }
}
