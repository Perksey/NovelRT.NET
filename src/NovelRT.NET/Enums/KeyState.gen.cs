// This file is part of NovelRT.NET.
// 
// You may modify and distribute NovelRT.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace NovelRT.NET
{
    [NativeName("AnonymousName", "__AnonymousEnum_NovelRTKeyState_L9_C9")]
    [NativeName("Name", "NovelRTKeyState")]
    public enum KeyState
    {
        [NativeName("Name", "Idle")]
        Idle = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "KeyUp")]
        KeyUp = 0x0,
        [NativeName("Name", "KeyDown")]
        KeyDown = 0x1,
        [NativeName("Name", "KeyDownHeld")]
        KeyDownHeld = 0x2,
    }
}
