using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace Users.APIBusiness.DBContext.Interface
{
    public interface IProductRepository
    {
        public BaseResponse List_Products(Int32 campus_id, int active);
    }
}
