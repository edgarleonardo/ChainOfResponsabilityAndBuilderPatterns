
namespace ChainOfResponsabilityAndBuilderPatterns.Builder
{
    public class ItemsToBeBuild
    {
        public string Message { get; private set; }
        public ItemsToBeBuild(string message)
        {
            this.Message = message;
        }
    }
}
