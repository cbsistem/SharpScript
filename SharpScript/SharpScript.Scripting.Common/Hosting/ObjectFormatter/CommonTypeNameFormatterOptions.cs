// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace SharpScript.Scripting.Common.Hosting
{
    internal struct CommonTypeNameFormatterOptions
    {
        public int ArrayBoundRadix { get; }
        public bool ShowNamespaces { get; }

        public CommonTypeNameFormatterOptions(int arrayBoundRadix, bool showNamespaces)
        {
            ArrayBoundRadix = arrayBoundRadix;
            ShowNamespaces = showNamespaces;
        }
    }
}