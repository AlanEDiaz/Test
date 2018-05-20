using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestfull.Services;
using WebApiRestfull.WebApiModels;

namespace WebApiRestfull.QuotationStrategies
{
    public abstract class AbstractQuotationStrategy
    {
        public IQuotationWebClient _quotationWebClientService;
        public abstract QuotationResult GetQuotation();
    }
}