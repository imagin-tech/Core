﻿using System;

namespace Imagin.Core;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class ProgressAttribute : Attribute
{
    public ProgressAttribute() : base() { }
}