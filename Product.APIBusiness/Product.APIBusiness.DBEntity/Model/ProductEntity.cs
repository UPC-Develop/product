using System;
using System.Collections.Generic;
using System.Text;

namespace Users.APIBusiness.DBEntity.Model
{
    public class ProductEntity
    {
        public Int32 product_id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public decimal width_product { get; set; }
        public decimal long_product { get; set; }
        public string unit_measurement { get; set; }
        public decimal price { get; set; }
        public string currency_type { get; set; }
        public Int32 product_category_id { get; set; }
        public string product_category_description { get; set; }
        public int active { get; set; }
        public Int32 campus_id { get; set; }
        public decimal campus_description { get; set; }


    }
}
