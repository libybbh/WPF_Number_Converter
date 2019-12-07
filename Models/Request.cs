﻿using System;

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
            private set
            {
                _date = DateTime.Now;

            }
        }

        internal string RomanNumber
        {
            get
            {
                return _romanNumber;
            }
            private set
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
            private set
            {
                _arabNumber = value;
            }
        }

        #region Constructor

        public Request(int arabNumber, string romanNumber, DateTime date)
        {
            _arabNumber = arabNumber;
            _romanNumber = romanNumber;
            _date = date;

        }
        #endregion

        #endregion
    }
}
