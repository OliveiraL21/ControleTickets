using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ResultDAL
    {
        private readonly TicketContext _context;
        public ResultDAL(TicketContext context)
        {
            _context = context;
        }
        public ResultDAL()
        {
            _context = new TicketContext();
        }

        public async Task<bool> InsertResult(Result result)
        {
            if(result == null)
            {
                return false;
            }
            _context.Add(result);
           await _context.SaveChangesAsync();
            return true;
        }
        public Result GetResult(Result result)
        {
            var response =  _context.results.FirstOrDefault(r => r.ResultId == result.ResultId);
            if(response == null)
            {
                return null;
            }
            return response;
        }
        public  IEnumerable<Result> GetResults()
        {
            var response = _context.results.ToList();
            return response;
        }
        public async Task<bool> EditResult(Result result)
        {
            if (result == null)
            {
                return false;
            }
            var response = _context.results.FirstOrDefault(r => r.ResultId == result.ResultId);
            _context.Entry(response).CurrentValues.SetValues(result);
           await  _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool>Delete(Result result)
        {
            var entity = _context.results.FirstOrDefault(r => r.ResultId == result.ResultId);
            if (entity == null) { return false; }
            var response = _context.Remove(entity);
           
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
