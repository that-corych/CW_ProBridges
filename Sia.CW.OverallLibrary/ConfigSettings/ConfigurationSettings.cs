using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sia.CW.OverallLibrary.ConfigSettings
{
    public class ConfigurationSettings : OverallBase
    {
        #region Метод LoadSettings
        public virtual void LoadSettings()
        {

        }
        #endregion

        #region Метод GetSetting
        protected T GetSetting<T>(string key, object defaultValue)
        {
            T ret = default(T);
            string value;

            value = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrEmpty(value))
            {
                ret = (T)defaultValue;
            }
            else
            {
                ret = (T)Convert.ChangeType(value, typeof(T));
            }

            return ret;
        }
        #endregion
    }
}
