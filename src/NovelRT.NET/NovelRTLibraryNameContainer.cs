// This file is part of NovelRT.NET.
// 
// You may modify and distribute NovelRT.NET under the terms
// of the MIT license. See the LICENSE file for details.
using Silk.NET.Core.Loader;

namespace NovelRT.NET
{
    /// <summary>
    /// Contains the library name of NovelRT.
    /// </summary>
    internal class NovelRTLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libNovelRT.so";

        /// <inheritdoc />
        public override string MacOS => "libNovelRT.dylib";

        /// <inheritdoc />
        public override string Android => "libNovelRT.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "NovelRT.dll";

        /// <inheritdoc />
        public override string Windows86 => "NovelRT.dll";
    }
}
