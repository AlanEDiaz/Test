using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestfull.Services;
using WebApiRestfull.WebApiModels;

namespace WebApiRestfull.QuotationStrategies
{
    public class RealQuotationStrategy : AbstractQuotationStrategy
    {
        public RealQuotationStrategy()
        {
            _quotationWebClientService = new RealQuotationWebClient();
        }

        public override QuotationResult GetQuotation()
        {
            return _quotationWebClientService.GetQuotation();
        }
    }
}