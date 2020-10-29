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
    [NativeName("Name", "NovelRTTransform")]
    public unsafe partial struct Transform
    {
        public Transform
        (
            GeoVector2F? position = null,
            GeoVector2F? scale = null,
            float? rotation = null
        ) : this()
        {
            if (position is not null)
            {
                Position = position.Value;
            }

            if (scale is not null)
            {
                Scale = scale.Value;
            }

            if (rotation is not null)
            {
                Rotation = rotation.Value;
            }
        }


        [NativeName("Type", "NovelRTGeoVector2F")]
        [NativeName("Type.Name", "NovelRTGeoVector2F")]
        [NativeName("Name", "position")]
        public GeoVector2F Position;

        [NativeName("Type", "NovelRTGeoVector2F")]
        [NativeName("Type.Name", "NovelRTGeoVector2F")]
        [NativeName("Name", "scale")]
        public GeoVector2F Scale;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "rotation")]
        public float Rotation;
    }
}
