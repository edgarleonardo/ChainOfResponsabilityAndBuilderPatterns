using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityAndBuilderPatterns.ChainOfResponsability
{
    public class SalesChainHandler : ChainHandler
    {
        public override void HandleRequest(ChainRequest request)
        {
            if (request == null)
            {
                Console.WriteLine($"Request Empty");
                return;
            }
            if (request.TypeOfRequest == TypeOfRequestEnum.Sales)
            {
                Console.WriteLine($"Sales Received The Message: {request.Message}");
            }
            else
            {
                SubstituteHandler.HandleRequest(request);
            }
        }
    }
}
