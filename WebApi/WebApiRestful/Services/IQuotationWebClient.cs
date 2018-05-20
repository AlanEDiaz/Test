using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiRestfull.WebApiModels;

namespace WebApiRestfull.Services
{
    public interface IQuotationWebClient
    {
        QuotationResult GetQuotation();
    }
}
