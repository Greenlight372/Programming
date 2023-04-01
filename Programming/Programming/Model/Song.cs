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
                _minutes = value;
                Validator.AssertValueInRange(_minutes, 0, 60);
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
                _seconds = value;
                Validator.AssertValueInRange(_seconds, 0, 60);
            }
        }
        public string Composer { get; set; }
        public string Title { get; set; }
    }
}
