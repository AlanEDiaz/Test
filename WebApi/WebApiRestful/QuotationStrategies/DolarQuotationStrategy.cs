using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestfull.Services;
using WebApiRestfull.WebApiModels;

namespace WebApiRestfull.QuotationStrategies
{
    public class DolarQuotationStrategy : AbstractQuotationStrategy
    {
        public DolarQuotationStrategy()
        {
            _quotationWebClientService = new DolarQuotationWebClient();
        }
        public override QuotationResult GetQuotation()
        {
            return _quotationWebClientService.GetQuotation();
        }
    }
}