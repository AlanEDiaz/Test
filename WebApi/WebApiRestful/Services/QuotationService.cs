using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestfull.QuotationStrategies;
using WebApiRestfull.WebApiModels;

namespace WebApiRestfull.Services
{
    public class QuotationService
    {   
        public QuotationResult GetQuotation(string currency)
        {
            return new QuotationStrategyFactory().GetQuotationStrategy(currency).GetQuotation();
        }
    }
}