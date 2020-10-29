// This file is part of NovelRT.NET.
// 
// You may modify and distribute NovelRT.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace NovelRT.NET
{
    [NativeName("AnonymousName", "__AnonymousEnum_NovelRTAnimatorPlayState_L10_C9")]
    [NativeName("Name", "NovelRTAnimatorPlayState")]
    public enum AnimatorPlayState
    {
        [NativeName("Name", "Stopped")]
        Stopped = 0x0,
        [NativeName("Name", "Playing")]
        Playing = 0x1,
        [NativeName("Name", "Paused")]
        Paused = 0x2,
    }
}
