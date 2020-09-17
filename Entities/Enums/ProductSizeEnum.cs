using System;

namespace Entities.Enums
{
    [Flags]
    public enum ProductSizeEnum
    {
        XS = 1,
        S = 2,
        M = 4,
        L = 8,
        XL = 16,
    }
}