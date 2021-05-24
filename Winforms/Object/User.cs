using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Winforms.Object
{
    class User
    {

        public dynamic info(string key)
        {
            string UserInfo = Properties.Settings.Default.UserInfo;
            dynamic info = JObject.Parse(UserInfo);
            if (info != null && info[key] != null)
            {
                return info[key];
            }
            return "";
        }
    }
}
