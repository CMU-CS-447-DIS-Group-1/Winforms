using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms.API
{
    class Invoice
    {
        Connect request = new Connect();
        string url;

        public Invoice()
        {
            url = request.baseurl + "/select/invoice";
        }

        public dynamic index()
        {
            return request.Get(url).data;
        }

        public dynamic show(string id)
        {
            return request.Get(request.baseurl + "/select/invoices/" + id).data;
        }

        public dynamic view(string id)
        {
            return request.Get(url + '/' + id).data;
        }

        public dynamic print(string id)
        {
            return request.Post(url + '/' + id);
        }
    }
}
