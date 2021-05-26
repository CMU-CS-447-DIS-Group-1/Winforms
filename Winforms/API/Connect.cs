using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using Newtonsoft.Json.Linq;

namespace Winforms.API
{
    class Connect
    {
        HttpRequest request = new HttpRequest();
        public string baseurl = "https://res.khodata.xyz/api";

        public Connect()
        {
            request.AddHeader(HttpHeader.Accept, "application/json");
        }

        public dynamic Get(string url)
        {
            try
            {
                if (Properties.Settings.Default.AuthToken != null)
                {
                    url = url + "?api_token=" + Properties.Settings.Default.AuthToken;
                }
                string html = request.Get(url).ToString();
                if (html != null)
                {
                    dynamic result = JObject.Parse(@html);
                    return result;
                }
                return null;
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return null;
            }
            finally
            {
                // Cleanup in the end if initialized
                request?.Dispose();
            }
        }

        /**
         * Post, Store
         */
        public dynamic Post(string url, Dictionary<string, string> data)
        {
            try
            {
                string html = request.Post(url, ToRequestParams(data)).ToString();
                dynamic result = JObject.Parse(@html);
                return result;
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return null;
            }
            finally
            {
                // Cleanup in the end if initialized
                request?.Dispose();
            }
        }

        /**
         * Update
         */
        public dynamic Put(string url, Dictionary<string, string> data)
        {
            try
            {
                string html = request.Put(url, ToRequestParams(data)).ToString();
                dynamic result = JObject.Parse(@html);
                return result;
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return null;
            }
            finally
            {
                // Cleanup in the end if initialized
                request?.Dispose();
            }
        }

        /**
         * Delete
         */
        public bool Delete(string url)
        {
            try
            {
                string html = request.Delete(url).ToString();
                dynamic result = JObject.Parse(@html);
                if (result.code == 1) return true;
                return false;
            }
            catch (HttpException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return false;
            }
            finally
            {
                // Cleanup in the end if initialized
                request?.Dispose();
            }
        }

        public RequestParams ToRequestParams(Dictionary<string, string> data = null)
        {
            RequestParams output = new RequestParams { };
            output["api_token"] = Properties.Settings.Default.AuthToken != null ? Properties.Settings.Default.AuthToken : "";
            if (data != null)
            {
                foreach (KeyValuePair<string, string> param in data)
                {
                    output[param.Key] = param.Value;
                }
            }

            return output;
        }
    }
}
