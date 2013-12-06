using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;

namespace TP_Final
{
    class Panel_Image_Setting : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("null")]
        public Image BackgroundImage
        {
            get
            {
                return ((Image)this["BackgroundImage"]);
            }
            set
            {
                this["BackgroundImage"] = (Image)value;
            }
        }
    }
}
