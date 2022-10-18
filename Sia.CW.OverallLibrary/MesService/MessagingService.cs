using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sia.CW.OverallLibrary.MesService
{
    public class MessagingService
    {
        #region Делегат для MessageRecievedEventHandler
        public delegate void MessageRecievedEventHandler(object sender, MessagingServiceEventArgs e);
        public event MessageRecievedEventHandler MessageRecieved;
        #endregion

        #region Instance Свойство
        private static MessagingService _Instance;
        public static MessagingService Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new MessagingService();
                }

                return _Instance;
            }
            set { _Instance = value; }
        }
        #endregion

        #region Методы SendMessage
        public void SendMessage(string messageName)
        {
            SendMessage(messageName, null);
        }

        public void SendMessage(string messageName, object payload)
        {
            MessagingServiceEventArgs arg;
            arg = new MessagingServiceEventArgs(messageName, payload);
            RaiseMessageRecieved(arg);
        }
        #endregion

        #region MessageRecieved Event
        protected void RaiseMessageRecieved(MessagingServiceEventArgs e)
        {
            if(null != MessageRecieved)
            {
                MessageRecieved(this, e);
            }
        }
        #endregion
    }
}