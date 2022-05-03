﻿using System;

namespace Imagin.Common
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class SuggestionsAttribute : Attribute
    {
        public readonly string CommandName;

        public readonly string SourceName;

        public SuggestionsAttribute(string sourceName, string commandName)
        {
            SourceName
                = sourceName;
            CommandName 
                = commandName;
        }
    }
}