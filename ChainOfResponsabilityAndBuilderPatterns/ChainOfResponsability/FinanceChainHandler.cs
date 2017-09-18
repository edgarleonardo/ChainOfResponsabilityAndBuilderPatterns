using System;

namespace ChainOfResponsabilityAndBuilderPatterns.ChainOfResponsability
{
    public class FinanceChainHandler : ChainHandler
    {
        public override void HandleRequest(ChainRequest request)
        {
            if (request == null)
            {
                Console.WriteLine($"Request Empty");
                return;
            }
            if (request.TypeOfRequest == TypeOfRequestEnum.Finance)
            {
                Console.WriteLine($"Finance Received The Message: {request.Message}");
            }
            else
            {
                SubstituteHandler.HandleRequest(request);
            }
        }
    }
}
