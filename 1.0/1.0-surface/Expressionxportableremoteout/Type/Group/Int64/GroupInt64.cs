﻿using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupInt64(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var result = BitConverter.ToInt64(Remote_ARRAY, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            objectResult = result;

            return objectResult;
        }
    }
}
