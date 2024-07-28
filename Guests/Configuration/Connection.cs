using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Configuration
{
    internal class Connection
    {
        public static readonly string connectionString =
          "Server=Ely-Kas;" +
          "Database=Guests;" +
          "Uid=sa;" +
          "Pwd=1234;" +
          "Encrypt=True;" +
          "TrustServerCertificate=True";

    }
}
