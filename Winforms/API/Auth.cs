using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.API
{
    class Auth
    {
        Connect request = new Connect();
        string login_url, logout_url;

        public Auth()
        {
            login_url = request.baseurl + "/login";
            logout_url = request.baseurl + "/logout";
        }

        public bool login(string email, string password)
        {
            var data = new Dictionary<string, string>();
            data["email"] = email;
            data["password"] = password;
            var result = request.Post(login_url, data);
            if (result != null && result.api_token != null)
            {
                Properties.Settings.Default.AuthToken = result["api_token"].ToString();
                return true;
            }
            return false;
        }

        public bool logout()
        {
            var result = request.Get(logout_url);
            if (result != null && result.code == 1)
            {
                Properties.Settings.Default.AuthToken = null;
                return true;
            }
            return false;
        }
    }
}
