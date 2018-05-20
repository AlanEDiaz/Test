using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebApiRestfull.WebApiModels;

namespace WebApiRestfull.QuotationStrategies
{
    public class DefaultQuotationStrategy : AbstractQuotationStrategy
    {
        public override QuotationResult GetQuotation()
        {
            return new QuotationResult("Invalid Currency", HttpStatusCode.BadRequest);
        }
    }
}