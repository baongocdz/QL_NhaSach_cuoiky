using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.BUS
{
    public class ProductBUS
    {
        private readonly ProductDAL _productDAL;

        public ProductBUS()
        {
            _productDAL = new ProductDAL();
        }

        public List<Product> GetAllProducts()
        {
            var productList = new List<Product>();
            var dataTable = _productDAL.GetAllProducts();
            foreach (DataRow row in dataTable.Rows)
            {
                productList.Add(new Product(row));
            }
            return productList;
        }
        public List<Product> SearchProducts(string keyword)
        {
            List<Product> productList = new List<Product>();
            var dataTable= _productDAL.SearchProducts(keyword);
            foreach (DataRow row in dataTable.Rows)
            {
                Product product = new Product(row);
                productList.Add(product);
            }
            return productList;
        }
        public bool UpdateProduct(Product data)
        {
            if (data == null || data.MAMATHANG == null)
            {
                return false;
            }
            return _productDAL.UpdateProduct(data);
        }
        public bool DeleteProduct(int maMatHang)
        {
            return _productDAL.DeleteProduct(maMatHang);
        }

    }
}
