using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DAL
{
    public class DataProvider
    {
        string connectionstring = @"Data Source=NGOCDZ\SQLEXPRESS02; Initial Catalog=QL_NhaSach;Integrated Security=True";
        private DataProvider() { }
        private static DataProvider instance;

        public static DataProvider Instance {
            get => instance; set => instance = value; }
    }
}
