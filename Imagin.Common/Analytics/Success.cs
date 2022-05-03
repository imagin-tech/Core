﻿using System;

namespace Imagin.Common.Analytics
{
    [Serializable]
    public class Success : Success<object>
    {
        public Success() : base() { }

        public Success(object data) : base(data) { }
    }
}