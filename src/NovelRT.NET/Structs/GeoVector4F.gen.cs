// This file is part of NovelRT.NET.
// 
// You may modify and distribute NovelRT.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace NovelRT.NET
{
    [NativeName("Name", "NovelRTGeoVector4F")]
    public unsafe partial struct GeoVector4F
    {
        public GeoVector4F
        (
            float? x = null,
            float? y = null,
            float? z = null,
            float? w = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (z is not null)
            {
                Z = z.Value;
            }

            if (w is not null)
            {
                W = w.Value;
            }
        }


        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x")]
        public float X;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y")]
        public float Y;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "z")]
        public float Z;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "w")]
        public float W;
    }
}
