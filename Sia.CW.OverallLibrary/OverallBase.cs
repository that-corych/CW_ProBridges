using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sia.CW.OverallLibrary
{
    public class OverallBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Метод Clone
        public void Clone<T>(T original, T cloneTo)
        {
            if(original != null && cloneTo != null)
            {
                foreach (var prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    var value = prop.GetValue(original, null);
                    prop.SetValue(cloneTo, value, null);
                }
            }
        }
        #endregion
    }
}