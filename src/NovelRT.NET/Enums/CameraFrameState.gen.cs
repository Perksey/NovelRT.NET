// This file is part of NovelRT.NET.
// 
// You may modify and distribute NovelRT.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace NovelRT.NET
{
    [NativeName("AnonymousName", "__AnonymousEnum_NovelRTCameraFrameState_L13_C9")]
    [NativeName("Name", "NovelRTCameraFrameState")]
    public enum CameraFrameState
    {
        [NativeName("Name", "Unmodified")]
        Unmodified = 0x0,
        [NativeName("Name", "ModifiedInCurrent")]
        ModifiedInCurrent = 0x1,
        [NativeName("Name", "ModifiedInLast")]
        ModifiedInLast = 0x2,
    }
}
