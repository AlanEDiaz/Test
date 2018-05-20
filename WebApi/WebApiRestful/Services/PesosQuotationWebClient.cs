using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebApiRestfull.WebApiModels;

namespace WebApiRestfull.Services
{
    public class PesosQuotationWebClient : IQuotationWebClient
    {
        public QuotationResult GetQuotation()
        {
            return new QuotationResult(HttpStatusCode.Unauthorized);
        }
    }
}