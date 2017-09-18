﻿

using System;

namespace ChainOfResponsabilityAndBuilderPatterns.Builder
{
    public class ConcreateBuilder : Builder<ItemsToBeBuild>
    {
        public override ItemsToBeBuild Build()
        {
            return new ItemsToBeBuild("Generated by builder");
        }
    }
}
