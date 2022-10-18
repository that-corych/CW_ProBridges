using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sia.CW.OverallLibrary.ErrorManager
{
    public class ExceptionManager : OverallBase
    {
        #region Свойство Instance
        private static ExceptionManager _Instance;
        public static ExceptionManager Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new ExceptionManager();
                }
                return _Instance;
            }
            set { _Instance = value; }
        }
        #endregion

        #region Метод Publish
        public virtual void Publish(Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }
        #endregion
    }
}