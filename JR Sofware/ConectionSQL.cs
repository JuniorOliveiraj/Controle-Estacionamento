using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JR_Software
{
    public class ConectionSQL
    {
        private string connectionString = @"Server=100.64.64.223;Port=3000;Database=bd-oliveira;Uid=root;Pwd=Oliveira1012/0;";

        public string GetConnectionString()
        {
            return connectionString;
        }
    }
}
