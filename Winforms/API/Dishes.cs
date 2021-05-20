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
            return request.Get(url);
        }

        public dynamic store()
        {
            var data = new Dictionary<string, string>();
            return request.Post(url, data);
        }

        public dynamic show(int id)
        {
            return request.Get(url + "/" + id);
        }

        public dynamic update(int id)
        {
            var data = new Dictionary<string, string>();
            return request.Put(url + " / " + id, data);
        }

        public bool destroy(int id)
        {
            return request.Delete(url + " / " + id);
        }
    }
}
