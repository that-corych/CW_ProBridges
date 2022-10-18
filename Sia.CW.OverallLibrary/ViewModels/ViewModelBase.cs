using Sia.CW.OverallLibrary.ErrorManager;
using Sia.CW.OverallLibrary.MesService;
using Sia.CW.OverallLibrary.ValidationService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sia.CW.OverallLibrary.ViewModels
{
    public class ViewModelBase : OverallBase
    {
        #region Private поля
        private ObservableCollection<ValidationMessage> _ValidationMessages =
            new ObservableCollection<ValidationMessage>();

        private bool _IsValidationVisible = false;
        #endregion

        #region Public свойства
        public ObservableCollection<ValidationMessage > ValidationMessages
        {
            get { return _ValidationMessages; }
            set
            {
                _ValidationMessages = value;
                OnPropertyChanged("ValidationMessages");
            }
        }

        public bool IsValidationVisible
        {
            get { return _IsValidationVisible; }
            set
            {
                _IsValidationVisible = value;
                OnPropertyChanged("IsValidationVisible");
            }
        }
        #endregion

        #region Метод AddBusinessRuleMessage
        public virtual void AddValidationMessage(string propertyName, string msg)
        {
            _ValidationMessages.Add(new ValidationMessage { Message=msg, PropertyName=propertyName });
            IsValidationVisible = true;
        }
        #endregion

        #region Метод Clear
        public virtual void Clear()
        {
            ValidationMessages.Clear();
            IsValidationVisible = false;
        }
        #endregion

        #region Метод DisplayStatusMessage
        public virtual void DisplayStatusMessage(string msg = "")
        {
            MessagingService.Instance.SendMessage(MessagingServiceMessages.DISPLAY_STATUS_MESSAGE, msg);
        }
        #endregion

        #region Метод PublishException
        public void PublishException(Exception ex)
        {
            ExceptionManager.Instance.Publish(ex);
        }
        #endregion

        #region Метод Close
        public virtual void Close(bool wasCancelled = true)
        {
            MessagingService.Instance.SendMessage(MessagingServiceMessages.CLOSE_USER_CONTROL, wasCancelled);
        }
        #endregion

        #region Метод Dispose
        public virtual void Dispose()
        {

        }
        #endregion
    }
}
