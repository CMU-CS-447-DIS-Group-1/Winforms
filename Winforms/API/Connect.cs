using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace Winforms.API
{
    class Connect
    {
        RestClient client;
        // public string baseurl = "https://res.khodata.xyz/api";
        public string baseurl = "http://restaurant-api.test/api";
        private bool debug = false;

        public Connect()
        {
            client = new RestClient(baseurl);
            client.AddDefaultHeader("Accept", "application/json");
        }

        public dynamic Get(string url, Dictionary<string, string> data = null)
        {
            try
            {
                var request = ToRequestParams(url, data);
                var response = client.Get(request);
                string html = response.Content;
                if (debug == true)
                {
                    MessageBox.Show("URL: " + response.ResponseUri.ToString() + "\nContent: \n" + html);
                }
                dynamic result = JObject.Parse(@html);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return null;
            }
        }

        /**
         * Post, Store
         */
        public dynamic Post(string url, Dictionary<string, string> data = null)
        {
            try
            {
                var request = ToRequestParams(url, data);
                var response = client.Post(request);
                string html = response.Content;
                if (debug == true)
                {
                    MessageBox.Show("URL: " + response.ResponseUri.ToString() + "\nContent: \n" + html);
                }
                dynamic result = JObject.Parse(@html);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return null;
            }
        }

        // Update
        public dynamic Put(string url, Dictionary<string, string> data = null)
        {
            try
            {
                var request = ToRequestParams(url, data);
                var response = client.Put(request);
                string html = response.Content;
                if (debug == true)
                {
                    MessageBox.Show("URL: " + response.ResponseUri.ToString() + "\nContent: \n" + html);
                }
                dynamic result = JObject.Parse(@html);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return null;
            }
        }

        // Delete
        public bool Delete(string url)
        {
            try
            {
                var request = ToRequestParams(url);
                var response = client.Delete(request);
                string html = response.Content;
                if (debug == true)
                {
                    MessageBox.Show("URL: " + response.ResponseUri.ToString() + "\nContent: \n" + html);
                }
                dynamic result = JObject.Parse(@html);
                if (result != null && result.code == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return false;
            }
        }

        public RestRequest ToRequestParams(string url, Dictionary<string, string> data = null)
        {
            RestRequest output = new RestRequest(url);
            if (Properties.Settings.Default.AuthToken != null) output.AddParameter("api_token", Properties.Settings.Default.AuthToken);
            if (data != null)
            {
                foreach (KeyValuePair<string, string> param in data)
                {
                    output.AddParameter(param.Key, param.Value);
                }
            }

            return output;
        }
    }
}
