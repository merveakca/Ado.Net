using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net
{
    public class Db
    {
        public static string ConnectionString 
        { get
            {
                return "Data Source=DESKTOP-D84DF12\\SQLEXPRESS01; Initial Catalog=NORTHWND; Integrated Security=True";
            }
        }
    }
}
