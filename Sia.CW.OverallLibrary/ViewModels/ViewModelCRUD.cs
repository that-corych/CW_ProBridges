using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sia.CW.OverallLibrary.ViewModels
{
    public class ViewModelCRUD : ViewModelBase
    {
        #region Private Поля
        private bool _IsListEnabled = true;
        private bool _IsDetailEnabled = false;
        private bool _IsAddMode = false;
        #endregion

        #region Public свойства
        public bool IsListEnabled
        {
            get { return _IsListEnabled; }
            set
            {
                _IsListEnabled = value;
                OnPropertyChanged("IsListEnabled");
            }
        }

        public bool IsDetailEnabled
        {
            get { return _IsDetailEnabled; }
            set
            {
                _IsDetailEnabled = value;
                OnPropertyChanged("IsDetailEnabled");
            }
        }

        public bool IsAddMode
        {
            get { return _IsAddMode; }
            set
            {
                _IsAddMode = value;
                OnPropertyChanged("IsAddMode");
            }
        }
        #endregion

        #region Метод BeginEdit
        public virtual void BeginEdit(bool isAddMode = false)
        {
            IsListEnabled = false;
            IsDetailEnabled = true;
            IsAddMode = isAddMode;
        }
        #endregion

        #region Метод CancelEdit
        public virtual void CancelEdit()
        {
            base.Clear();

            IsListEnabled = true;
            IsDetailEnabled = false;
            IsAddMode = false;
        }
        #endregion

        #region Метод Save
        public virtual bool Delete()
        {
            return true;
        }
        #endregion
    }
}
