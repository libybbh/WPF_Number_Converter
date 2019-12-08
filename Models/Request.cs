using System;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models
{
    class Request
    {
        #region Fields
        private DateTime _date;
        private int _arabNumber;
        private String _romanNumber;
        #endregion

        #region Properties

        internal DateTime Time
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;

            }
        }

        internal string RomanNumber
        {
            get
            {
                return _romanNumber;
            }
            set
            {
                _romanNumber = value;
            }
        }

        internal  int ArabNumber
        {
            get
            {
                return _arabNumber;
            }
            set
            {
                _arabNumber = value;
            }
        }

        #region Constructor

        public Request()
        {
            
        }
        public Request(int arabNumber, string romanNumber, DateTime date)
        {
            _arabNumber = arabNumber;
            _romanNumber = romanNumber;
            _date = date;

        }
        #endregion

        #endregion

        public override string ToString()
        {
            return "Request: Arabic Number = " + ArabNumber + "; Roman = " + RomanNumber + "; Date = " + Time.ToString() + "\n";
        }
    }
    }

