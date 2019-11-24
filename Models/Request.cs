using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models
{
    class Request
    {
        #region Fields
     //   private Guid _id;
        private string _date;
        private int _numToCon;
        private String _numAfterCon;
        #endregion

        #region Properties
      //  public Guid ID { get; set; }

        internal String Time
        {
            get
            {
                return _date;
            }
            private set
            {
                _date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");

            }
        }

        internal string NumAfterCon
        {
            get
            {
                return _numAfterCon;
            }
            private set
            {
                _numAfterCon = value;
            }
        }

        internal  int NumToCon
        {
            get
            {
                return _numToCon;
            }
            private set
            {
                _numToCon = value;
            }
        }

        #region Constructor

        public Request(int numToCon, string numAfterCon, string date)
        {
           // _id = Guid.NewGuid();
            _numToCon = numToCon;
            _numAfterCon = numAfterCon;
            _date = date;
          
          
        }
        #endregion

        #endregion
    }
}
