using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace NovelRT.NET
{
    public partial class NovelRT
    {
        public static NovelRT GetApi()
        {
            return new NovelRT(CreateDefaultContext(new NovelRTLibraryNameContainer().GetLibraryName()));
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotSupportedException();
        }
    }
}

