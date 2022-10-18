using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sia.CW.OverallLibrary.ValidationService
{
    public class ValidationMessage : OverallBase
    {
        #region Private свойства
        private string _PropertyName;
        private string _Message;
        #endregion

        #region Public свойства
        public string PropertyName
        {
            get { return _PropertyName; }
            set
            {
                _PropertyName = value;
                OnPropertyChanged("PropertyName");
            }
        }

        public string Message
        {
            get { return _Message; }
            set
            {
                _Message = value;
                OnPropertyChanged("Message");
            }
        }
        #endregion
    }
}
