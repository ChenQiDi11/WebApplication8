using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication8.Models;
using WebApplication8.Tools;

namespace WebApplication8.Controllers
{
    public class demoController : ApiController
    {
        [HttpGet]
        public async Task<apicallback> getv1(string id)
        {
            var orditem = await GetOrditem(id);
            var apicall = new apicallback();
            apicall.Status = status.sucuss;
            apicall.data = orditem;
            return apicall;
        }

        public Task<orditem> GetOrditem(string ordid)
        {
            return Task<orditem>.Run(() =>
            {
                orditem item = new orditem();
                item.size = 36;
                item.ordid = "15353";
                item.ordname = "啥都怪我";
                return item;
            });
            

            
        }
    }
}