using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QL_NhaSach.DAL
{
    public class ChiNhanhDAL
    {
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();    
        public DataTable GetAllChiNhanh()
        {
            var query = "select * from CHINHANH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool CheckChiNhanh(string Ten)
        {
            var query = $"select * from CHINHANH where LOWER(TEN) = LOWER('{Ten}')";
            var result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count == 0;
        }
    }
}
