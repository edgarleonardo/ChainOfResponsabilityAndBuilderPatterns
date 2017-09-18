using System;
using ChainOfResponsabilityAndBuilderPatterns.Builder;
using ChainOfResponsabilityAndBuilderPatterns.ChainOfResponsability;

namespace ChainOfResponsabilityAndBuilderPatterns
{
    class Program
    {
        private static ChainHandler _chainOfResponsability = null;
        public static ChainHandler ChainOfResponsability
        {
            get
            {
                if (_chainOfResponsability == null)
                {
                    _chainOfResponsability = new OperationChainHandler();
                    var sales = new SalesChainHandler();
                    var finance = new FinanceChainHandler();
                    finance.SubstituteHandler = sales;
                    _chainOfResponsability.SubstituteHandler = finance;
                }
                return _chainOfResponsability;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Begin Chain Of Responsability On Action");
            Console.WriteLine("-------------------------------------------------------------------------");

            ChainOfResponsability.HandleRequest(new ChainRequest(TypeOfRequestEnum.Finance, "I need The Payment Of Customer John Smith."));
            ChainOfResponsability.HandleRequest(new ChainRequest(TypeOfRequestEnum.Operation, "The Products lot is already on production."));
            ChainOfResponsability.HandleRequest(new ChainRequest(TypeOfRequestEnum.Finance, "The Operation department needs to buy several new machines to get the work done for this spring."));
            ChainOfResponsability.HandleRequest(new ChainRequest(TypeOfRequestEnum.Sales, "We reach the all goals with current clients and now we are going after the new clients."));
            ChainOfResponsability.HandleRequest(new ChainRequest(TypeOfRequestEnum.Operation, "The lot of juice got damaged because a chemical was poured on the machine.."));
            ChainOfResponsability.HandleRequest(new ChainRequest(TypeOfRequestEnum.Sales, "Last month brings better profit than the current."));

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("End Chain Of Responsability On Action");
            Console.WriteLine("-------------------------------------------------------------------------");


            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Begin Builder On Action");
            Console.WriteLine("-------------------------------------------------------------------------");
            var builder = new ConcreateBuilder();
            var objectFromBuilder = BuilderConstructor<ItemsToBeBuild>.ConstructObject(builder);
            Console.WriteLine($"Information injected from Builder {objectFromBuilder.Message}");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("End Builder On Action");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
