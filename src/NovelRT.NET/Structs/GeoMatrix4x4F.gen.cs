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
    [NativeName("Name", "NovelRTGeoMatrix4x4F")]
    public unsafe partial struct GeoMatrix4x4F
    {
        public GeoMatrix4x4F
        (
            GeoVector4F? x = null,
            GeoVector4F? y = null,
            GeoVector4F? z = null,
            GeoVector4F? w = null
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


        [NativeName("Type", "NovelRTGeoVector4F")]
        [NativeName("Type.Name", "NovelRTGeoVector4F")]
        [NativeName("Name", "x")]
        public GeoVector4F X;

        [NativeName("Type", "NovelRTGeoVector4F")]
        [NativeName("Type.Name", "NovelRTGeoVector4F")]
        [NativeName("Name", "y")]
        public GeoVector4F Y;

        [NativeName("Type", "NovelRTGeoVector4F")]
        [NativeName("Type.Name", "NovelRTGeoVector4F")]
        [NativeName("Name", "z")]
        public GeoVector4F Z;

        [NativeName("Type", "NovelRTGeoVector4F")]
        [NativeName("Type.Name", "NovelRTGeoVector4F")]
        [NativeName("Name", "w")]
        public GeoVector4F W;
    }
}
