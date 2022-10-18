using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sia.CW.OverallLibrary.MesService
{
    public class MessagingServiceEventArgs : EventArgs
    {
        #region Конструкторы

        public MessagingServiceEventArgs() : base()
        {

        }

        public MessagingServiceEventArgs(string messageName, object payload) : base()
        {
            MessageName = messageName;
            MessagePayload = payload;
        }
        #endregion

        #region Public Свойства
        public string MessageName { get; set; }
        public object MessagePayload { get; set; }
        #endregion
    }
}
