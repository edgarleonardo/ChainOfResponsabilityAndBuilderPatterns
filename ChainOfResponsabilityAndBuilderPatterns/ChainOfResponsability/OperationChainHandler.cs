using System;

namespace ChainOfResponsabilityAndBuilderPatterns.ChainOfResponsability
{
    public class OperationChainHandler : ChainHandler
    {
        public override void HandleRequest(ChainRequest request)
        {
            if (request == null)
            {
                Console.WriteLine($"Request Empty");
                return;
            }
            if (request.TypeOfRequest == TypeOfRequestEnum.Operation)
            {
                Console.WriteLine($"Operation Received The Message: {request.Message}");
            }
            else
            {
                SubstituteHandler.HandleRequest(request);
            }
        }
    }
}
