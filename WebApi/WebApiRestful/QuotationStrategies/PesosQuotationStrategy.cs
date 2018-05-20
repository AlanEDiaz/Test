using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestfull.Services;
using WebApiRestfull.WebApiModels;

namespace WebApiRestfull.QuotationStrategies
{
    public class PesosQuotationStrategy : AbstractQuotationStrategy
    {
        public PesosQuotationStrategy()
        {
            _quotationWebClientService = new PesosQuotationWebClient();
        }
        public override QuotationResult GetQuotation()
        {
            return _quotationWebClientService.GetQuotation();
        }
    }
}