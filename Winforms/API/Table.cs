using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms.API
{
    class Table
    {
        Connect request = new Connect();
        string url;

        public Table()
        {
            url = request.baseurl + "/select/table";
        }

        public dynamic index()
        {
            return request.Get(url);
        }

        public dynamic order(int tableID, int dishID, int quantity, double price)
        {
            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                {"dish_id", dishID.ToString() },
                {"quantity", quantity.ToString() },
                {"price", price.ToString() }
            };
            return request.Post(url + '/' + tableID, data);
        }
    }
}
