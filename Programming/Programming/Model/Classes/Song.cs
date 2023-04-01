using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _minutes;
        private int _seconds;

        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(value, 0, 60, "Minutes");
                _minutes = value;
            }
        }
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(value, 0, 60, "Seconds");
                _seconds = value;
            }
        }
        public string Composer { get; set; }
        public string Title { get; set; }
    }
}
