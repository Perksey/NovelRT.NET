// This file is part of NovelRT.NET.
// 
// You may modify and distribute NovelRT.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace NovelRT.NET
{
    [NativeName("AnonymousName", "__AnonymousEnum_NovelRTLogLevel_L11_C9")]
    [NativeName("Name", "NovelRTLogLevel")]
    public enum LogLevel
    {
        [NativeName("Name", "NOVELRT_LOGLEVEL_DEBUG")]
        LoglevelDebug = 0x1,
        [NativeName("Name", "NOVELRT_LOGLEVEL_INFO")]
        LoglevelInfo = 0x2,
        [NativeName("Name", "NOVELRT_LOGLEVEL_WARN")]
        LoglevelWarn = 0x3,
        [NativeName("Name", "NOVELRT_LOGLEVEL_ERR")]
        LoglevelErr = 0x4,
        [NativeName("Name", "NOVELRT_LOGLEVE_OFF")]
        LogleveOff = 0x6,
    }
}
