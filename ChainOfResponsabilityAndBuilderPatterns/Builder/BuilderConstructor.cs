namespace ChainOfResponsabilityAndBuilderPatterns.Builder
{
    public static class BuilderConstructor<T>
    {
        public static T ConstructObject(Builder<T> builder)
        {
            return builder.Build();
        }
    }
}
