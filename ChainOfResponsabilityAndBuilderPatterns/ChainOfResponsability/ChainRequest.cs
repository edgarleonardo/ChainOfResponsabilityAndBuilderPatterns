
namespace ChainOfResponsabilityAndBuilderPatterns.ChainOfResponsability
{
    public class ChainRequest
    {
        public TypeOfRequestEnum TypeOfRequest {get;set;}
        public string Message { get; set; }

        public ChainRequest(TypeOfRequestEnum typeOfRequest, string message)
        {
            this.TypeOfRequest = typeOfRequest;
            this.Message = message;
        }
    }
}
