using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public  class ResultService
    {
        private readonly ResultDAL _resultDAL;
        public ResultService()
        {
            _resultDAL = new ResultDAL();
        }

        public  Task<bool> InsertResult(Result result)
        {
            var response = _resultDAL.InsertResult(result);
            return response;
        }
        public Result GetResult(Result result)
        {
            var response = _resultDAL.GetResult(result);
            return response;
        }
        public IEnumerable<Result> GetResults()
        {
            var response = _resultDAL.GetResults();
            return response;
        }
        public  Task<bool> EditResult(Result result)
        {
            var response = _resultDAL.EditResult(result);
            return response;
        }
        public  Task<bool> Delete(Result result)
        {
            var response = _resultDAL.Delete(result);
            return response;
        }
    }
}
