

namespace ChainOfResponsabilityAndBuilderPatterns.ChainOfResponsability
{
    public abstract class ChainHandler
    {
        public ChainHandler SubstituteHandler { get; set; }
        public abstract void HandleRequest(ChainRequest request);
    }
}
