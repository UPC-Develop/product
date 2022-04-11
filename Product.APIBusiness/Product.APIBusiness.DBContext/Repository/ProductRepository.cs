using System;
using System.Collections.Generic;
using System.Text;
using DBContext;
using Users.APIBusiness.DBContext.Repository;
using Users.APIBusiness.DBContext.Interface;
using DBEntity;
using Users.APIBusiness.DBEntity.Model;
using Dapper;
using System.Data;
using System.Linq;

namespace Users.APIBusiness.DBContext.Repository

{
    public class ProductRepository : BaseRepository, Interface.IProductRepository
    {
        public BaseResponse List_Products(Int32 campus_id, int active)
        {

            var campusEntity = new List<ProductEntity>();
            var returnEntity = new BaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"usp_list_product_by_campus";

                    var p = new DynamicParameters();

                    p.Add(name: "@campus_id", value: campus_id, dbType: DbType.Int32 , direction: ParameterDirection.Input);
                    p.Add(name: "@active", value: active, dbType: DbType.Int16, direction: ParameterDirection.Input);

                    campusEntity = db.Query<ProductEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure).ToList();
        
                    if (campusEntity.Count > 0)
                    {
                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = campusEntity;
                    }
                    else
                    {
                        returnEntity.isSuccess = true;
                        returnEntity.errorCode = "0000";
                        returnEntity.errorMessage = string.Empty;
                        returnEntity.data = null;
                    }
                }
            }
            catch (Exception ex)
            {
                returnEntity.isSuccess = false;
                returnEntity.errorCode = "0001";
                returnEntity.errorMessage = ex.Message;
                returnEntity.data = null;
            }

            return returnEntity;

        }
    }
}
