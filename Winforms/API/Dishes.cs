using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms.API
{
    class Dishes
    {
        Connect request = new Connect();
        string url;

        public Dishes()
        {
            url = request.baseurl + "/dishes";
        }

        public dynamic index()
        {
            return request.Get(url).data;
        }

        public dynamic store(string name, double price, string description = "")
        {
            var data = new Dictionary<string, string> {
                {"name", name },
                {"price", price.ToString() },
                {"description", description }
            };
            return request.Post(url, data);
        }

        public dynamic show(int id)
        {
            return request.Get(url + "/" + id);
        }

        public dynamic update(int id, string name, double price, string description = "")
        {
            var data = new Dictionary<string, string> {
                {"name", name },
                {"price", price.ToString() },
                {"description", description }
            };
            return request.Put(url + "/" + id.ToString(), data);
        }

        public bool destroy(int id)
        {
            return request.Delete(url + "/" + id);
        }
    }
}
