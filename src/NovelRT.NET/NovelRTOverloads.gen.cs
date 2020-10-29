// This file is part of NovelRT.NET.
// 
// You may modify and distribute NovelRT.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace NovelRT.NET
{
    public static class NovelRTOverloads
    {
        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 13 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Windowing/../NovelRTInteropUtils.h")]
        public static unsafe byte* TranslateErrorCode(this NovelRT thisApi, byte* targetLanguage, Span<byte> errorPtr)
        {
            // SpanOverloader
            return thisApi.TranslateErrorCode(targetLanguage, ref errorPtr.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 13 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Windowing/../NovelRTInteropUtils.h")]
        public static unsafe byte* TranslateErrorCode(this NovelRT thisApi, Span<byte> targetLanguage, byte* errorPtr)
        {
            // SpanOverloader
            return thisApi.TranslateErrorCode(ref targetLanguage.GetPinnableReference(), errorPtr);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 13 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Windowing/../NovelRTInteropUtils.h")]
        public static unsafe byte* TranslateErrorCode(this NovelRT thisApi, Span<byte> targetLanguage, Span<byte> errorPtr)
        {
            // SpanOverloader
            return thisApi.TranslateErrorCode(ref targetLanguage.GetPinnableReference(), ref errorPtr.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 13 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Windowing/../NovelRTInteropUtils.h")]
        public static unsafe byte* TranslateErrorCode(this NovelRT thisApi, Span<byte> targetLanguage, string errorPtr)
        {
            // SpanOverloader
            return thisApi.TranslateErrorCode(ref targetLanguage.GetPinnableReference(), errorPtr);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 13 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Windowing/../NovelRTInteropUtils.h")]
        public static unsafe byte* TranslateErrorCode(this NovelRT thisApi, string targetLanguage, Span<byte> errorPtr)
        {
            // SpanOverloader
            return thisApi.TranslateErrorCode(targetLanguage, ref errorPtr.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FRotateToAngleAroundPoint(this NovelRT thisApi, Span<GeoVector2F> vector, float angleRotationValue, GeoVector2F point, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FRotateToAngleAroundPoint(ref vector.GetPinnableReference(), angleRotationValue, point, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FRotateToAngleAroundPoint(this NovelRT thisApi, Span<GeoVector2F> vector, float angleRotationValue, GeoVector2F point, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FRotateToAngleAroundPoint(ref vector.GetPinnableReference(), angleRotationValue, point, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FAddVector(this NovelRT thisApi, GeoVector2F lhs, GeoVector2F rhs, Span<GeoVector2F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FAddVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FAddVector(this NovelRT thisApi, GeoVector2F lhs, GeoVector2F rhs, Span<GeoVector2F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FAddVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FSubtractVector(this NovelRT thisApi, GeoVector2F lhs, GeoVector2F rhs, Span<GeoVector2F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FSubtractVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FSubtractVector(this NovelRT thisApi, GeoVector2F lhs, GeoVector2F rhs, Span<GeoVector2F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FSubtractVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FMultiplyVector(this NovelRT thisApi, GeoVector2F lhs, GeoVector2F rhs, Span<GeoVector2F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FMultiplyVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FMultiplyVector(this NovelRT thisApi, GeoVector2F lhs, GeoVector2F rhs, Span<GeoVector2F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FMultiplyVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 36, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FDivideVector(this NovelRT thisApi, GeoVector2F lhs, GeoVector2F rhs, Span<GeoVector2F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FDivideVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 36, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FDivideVector(this NovelRT thisApi, GeoVector2F lhs, GeoVector2F rhs, Span<GeoVector2F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FDivideVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FAddFloat(this NovelRT thisApi, GeoVector2F lhs, float rhs, Span<GeoVector2F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FAddFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FAddFloat(this NovelRT thisApi, GeoVector2F lhs, float rhs, Span<GeoVector2F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FAddFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 38, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FSubtractFloat(this NovelRT thisApi, GeoVector2F lhs, float rhs, Span<GeoVector2F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FSubtractFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 38, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FSubtractFloat(this NovelRT thisApi, GeoVector2F lhs, float rhs, Span<GeoVector2F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FSubtractFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 39, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FMultiplyFloat(this NovelRT thisApi, GeoVector2F lhs, float rhs, Span<GeoVector2F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FMultiplyFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 39, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FMultiplyFloat(this NovelRT thisApi, GeoVector2F lhs, float rhs, Span<GeoVector2F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FMultiplyFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 40, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FDivideFloat(this NovelRT thisApi, GeoVector2F lhs, float rhs, Span<GeoVector2F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FDivideFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 40, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FDivideFloat(this NovelRT thisApi, GeoVector2F lhs, float rhs, Span<GeoVector2F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FDivideFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 41, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FAddAssignVector(this NovelRT thisApi, Span<GeoVector2F> lhs, GeoVector2F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FAddAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 41, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FAddAssignVector(this NovelRT thisApi, Span<GeoVector2F> lhs, GeoVector2F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FAddAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 42, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FSubtractAssignVector(this NovelRT thisApi, Span<GeoVector2F> lhs, GeoVector2F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FSubtractAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 42, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FSubtractAssignVector(this NovelRT thisApi, Span<GeoVector2F> lhs, GeoVector2F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FSubtractAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 43, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FMultiplyAssignVector(this NovelRT thisApi, Span<GeoVector2F> lhs, GeoVector2F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FMultiplyAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 43, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FMultiplyAssignVector(this NovelRT thisApi, Span<GeoVector2F> lhs, GeoVector2F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FMultiplyAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 44, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FDivideAssignVector(this NovelRT thisApi, Span<GeoVector2F> lhs, GeoVector2F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FDivideAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 44, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FDivideAssignVector(this NovelRT thisApi, Span<GeoVector2F> lhs, GeoVector2F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FDivideAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 45, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FAddAssignFloat(this NovelRT thisApi, Span<GeoVector2F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FAddAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 45, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FAddAssignFloat(this NovelRT thisApi, Span<GeoVector2F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FAddAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 46, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FSubtractAssignFloat(this NovelRT thisApi, Span<GeoVector2F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FSubtractAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 46, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FSubtractAssignFloat(this NovelRT thisApi, Span<GeoVector2F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FSubtractAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 47, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FMultiplyAssignFloat(this NovelRT thisApi, Span<GeoVector2F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FMultiplyAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 47, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FMultiplyAssignFloat(this NovelRT thisApi, Span<GeoVector2F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FMultiplyAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 48, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FDivideAssignFloat(this NovelRT thisApi, Span<GeoVector2F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FDivideAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 48, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/../Maths/NovelRTGeoVector2F.h")]
        public static unsafe int GeoVector2FDivideAssignFloat(this NovelRT thisApi, Span<GeoVector2F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector2FDivideAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoBounds.h")]
        public static unsafe int GeoBoundsIntersectsWith(this NovelRT thisApi, GeoBounds first, GeoBounds other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoBoundsIntersectsWith(first, other, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoBounds.h")]
        public static unsafe int GeoBoundsIntersectsWith(this NovelRT thisApi, GeoBounds first, GeoBounds other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoBoundsIntersectsWith(first, other, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetR(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetR(colourConfig, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetR(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetR(colourConfig, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetR(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetR(ref colourConfig.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetR(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetR(ref colourConfig.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetR(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetR(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetR(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetR(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigSetR(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int inputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigSetR(ref colourConfig.GetPinnableReference(), inputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigSetR(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int inputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigSetR(ref colourConfig.GetPinnableReference(), inputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetG(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetG(colourConfig, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetG(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetG(colourConfig, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetG(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetG(ref colourConfig.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetG(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetG(ref colourConfig.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetG(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetG(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetG(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetG(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigSetG(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int inputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigSetG(ref colourConfig.GetPinnableReference(), inputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigSetG(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int inputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigSetG(ref colourConfig.GetPinnableReference(), inputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetB(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetB(colourConfig, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetB(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetB(colourConfig, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetB(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetB(ref colourConfig.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetB(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetB(ref colourConfig.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetB(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetB(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetB(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetB(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigSetB(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int inputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigSetB(ref colourConfig.GetPinnableReference(), inputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigSetB(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int inputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigSetB(ref colourConfig.GetPinnableReference(), inputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetA(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetA(colourConfig, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetA(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetA(colourConfig, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetA(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetA(ref colourConfig.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetA(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetA(ref colourConfig.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetA(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetA(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetA(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetA(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigSetA(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int inputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigSetA(ref colourConfig.GetPinnableReference(), inputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigSetA(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, int inputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigSetA(ref colourConfig.GetPinnableReference(), inputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetRScalar(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<float> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetRScalar(colourConfig, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetRScalar(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<float> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetRScalar(colourConfig, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetRScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, float* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetRScalar(ref colourConfig.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetRScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, float* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetRScalar(ref colourConfig.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetRScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<float> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetRScalar(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetRScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<float> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetRScalar(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetGScalar(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<float> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetGScalar(colourConfig, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetGScalar(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<float> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetGScalar(colourConfig, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetGScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, float* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetGScalar(ref colourConfig.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetGScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, float* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetGScalar(ref colourConfig.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetGScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<float> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetGScalar(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetGScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<float> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetGScalar(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetBScalar(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<float> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetBScalar(colourConfig, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetBScalar(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<float> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetBScalar(colourConfig, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetBScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, float* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetBScalar(ref colourConfig.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetBScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, float* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetBScalar(ref colourConfig.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetBScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<float> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetBScalar(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetBScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<float> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetBScalar(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetAScalar(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<float> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetAScalar(colourConfig, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetAScalar(this NovelRT thisApi, RGBAConfigHandle* colourConfig, Span<float> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetAScalar(colourConfig, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetAScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, float* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetAScalar(ref colourConfig.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetAScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, float* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetAScalar(ref colourConfig.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetAScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<float> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetAScalar(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigGetAScalar(this NovelRT thisApi, Span<RGBAConfigHandle> colourConfig, Span<float> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigGetAScalar(ref colourConfig.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigDestroy(this NovelRT thisApi, Span<RGBAConfigHandle> arg0, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigDestroy(ref arg0.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRGBAConfig.h")]
        public static unsafe int RGBAConfigDestroy(this NovelRT thisApi, Span<RGBAConfigHandle> arg0, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RGBAConfigDestroy(ref arg0.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceInitialiseWindow(this NovelRT thisApi, WindowingServiceHandle* service, int displayNumber, Span<byte> windowTitle, int transparencyEnabled, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceInitialiseWindow(service, displayNumber, ref windowTitle.GetPinnableReference(), transparencyEnabled, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceInitialiseWindow(this NovelRT thisApi, WindowingServiceHandle* service, int displayNumber, Span<byte> windowTitle, int transparencyEnabled, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceInitialiseWindow(service, displayNumber, ref windowTitle.GetPinnableReference(), transparencyEnabled, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceInitialiseWindow(this NovelRT thisApi, Span<WindowingServiceHandle> service, int displayNumber, byte* windowTitle, int transparencyEnabled, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceInitialiseWindow(ref service.GetPinnableReference(), displayNumber, windowTitle, transparencyEnabled, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceInitialiseWindow(this NovelRT thisApi, Span<WindowingServiceHandle> service, int displayNumber, byte* windowTitle, int transparencyEnabled, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceInitialiseWindow(ref service.GetPinnableReference(), displayNumber, windowTitle, transparencyEnabled, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceInitialiseWindow(this NovelRT thisApi, Span<WindowingServiceHandle> service, int displayNumber, Span<byte> windowTitle, int transparencyEnabled, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceInitialiseWindow(ref service.GetPinnableReference(), displayNumber, ref windowTitle.GetPinnableReference(), transparencyEnabled, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceInitialiseWindow(this NovelRT thisApi, Span<WindowingServiceHandle> service, int displayNumber, Span<byte> windowTitle, int transparencyEnabled, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceInitialiseWindow(ref service.GetPinnableReference(), displayNumber, ref windowTitle.GetPinnableReference(), transparencyEnabled, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceInitialiseWindow(this NovelRT thisApi, Span<WindowingServiceHandle> service, int displayNumber, string windowTitle, int transparencyEnabled, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceInitialiseWindow(ref service.GetPinnableReference(), displayNumber, windowTitle, transparencyEnabled, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceInitialiseWindow(this NovelRT thisApi, Span<WindowingServiceHandle> service, int displayNumber, string windowTitle, int transparencyEnabled, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceInitialiseWindow(ref service.GetPinnableReference(), displayNumber, windowTitle, transparencyEnabled, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceTearDown(this NovelRT thisApi, Span<WindowingServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceTearDown(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceTearDown(this NovelRT thisApi, Span<WindowingServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceTearDown(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, byte** windowTitle, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowTitle(ref service.GetPinnableReference(), windowTitle, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, byte** windowTitle, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowTitle(ref service.GetPinnableReference(), windowTitle, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, ref byte* windowTitle, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowTitle(ref service.GetPinnableReference(), ref windowTitle, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, ref byte* windowTitle, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowTitle(ref service.GetPinnableReference(), ref windowTitle, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowTitle(this NovelRT thisApi, WindowingServiceHandle* service, Span<byte> value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowTitle(service, ref value.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowTitle(this NovelRT thisApi, WindowingServiceHandle* service, Span<byte> value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowTitle(service, ref value.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, byte* value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowTitle(ref service.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, byte* value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowTitle(ref service.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, Span<byte> value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowTitle(ref service.GetPinnableReference(), ref value.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, Span<byte> value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowTitle(ref service.GetPinnableReference(), ref value.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, string value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowTitle(ref service.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowTitle(this NovelRT thisApi, Span<WindowingServiceHandle> service, string value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowTitle(ref service.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowSize(this NovelRT thisApi, Span<WindowingServiceHandle> service, GeoVector2F value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowSize(ref service.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceSetWindowSize(this NovelRT thisApi, Span<WindowingServiceHandle> service, GeoVector2F value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceSetWindowSize(ref service.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowSize(this NovelRT thisApi, WindowingServiceHandle* service, Span<GeoVector2F> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowSize(service, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowSize(this NovelRT thisApi, WindowingServiceHandle* service, Span<GeoVector2F> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowSize(service, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowSize(this NovelRT thisApi, Span<WindowingServiceHandle> service, GeoVector2F* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowSize(ref service.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowSize(this NovelRT thisApi, Span<WindowingServiceHandle> service, GeoVector2F* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowSize(ref service.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowSize(this NovelRT thisApi, Span<WindowingServiceHandle> service, Span<GeoVector2F> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowSize(ref service.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Windowing/NovelRTWindowingService.h")]
        public static unsafe int WindowingServiceGetWindowSize(this NovelRT thisApi, Span<WindowingServiceHandle> service, Span<GeoVector2F> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.WindowingServiceGetWindowSize(ref service.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreate(this NovelRT thisApi, Span<WindowingServiceHandle> windowingService, RenderingServiceHandle** outputRenderingService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreate(ref windowingService.GetPinnableReference(), outputRenderingService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreate(this NovelRT thisApi, Span<WindowingServiceHandle> windowingService, RenderingServiceHandle** outputRenderingService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreate(ref windowingService.GetPinnableReference(), outputRenderingService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreate(this NovelRT thisApi, Span<WindowingServiceHandle> windowingService, ref RenderingServiceHandle* outputRenderingService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreate(ref windowingService.GetPinnableReference(), ref outputRenderingService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreate(this NovelRT thisApi, Span<WindowingServiceHandle> windowingService, ref RenderingServiceHandle* outputRenderingService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreate(ref windowingService.GetPinnableReference(), ref outputRenderingService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceInitialiseRendering(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceInitialiseRendering(ref renderingService.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceInitialiseRendering(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceInitialiseRendering(ref renderingService.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceTearDown(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceTearDown(ref renderingService.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceTearDown(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceTearDown(ref renderingService.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, byte* filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, byte* filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<byte> filePath, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, outputImageRect, transform, layer, ref filePath.GetPinnableReference(), colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<byte> filePath, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, outputImageRect, transform, layer, ref filePath.GetPinnableReference(), colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<byte> filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, outputImageRect, transform, layer, ref filePath.GetPinnableReference(), ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<byte> filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, outputImageRect, transform, layer, ref filePath.GetPinnableReference(), ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, string filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, string filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, byte* filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, ref outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, byte* filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, ref outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<byte> filePath, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, ref outputImageRect, transform, layer, ref filePath.GetPinnableReference(), colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<byte> filePath, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, ref outputImageRect, transform, layer, ref filePath.GetPinnableReference(), colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<byte> filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, ref outputImageRect, transform, layer, ref filePath.GetPinnableReference(), ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<byte> filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, ref outputImageRect, transform, layer, ref filePath.GetPinnableReference(), ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, string filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, ref outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, string filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(renderingService, ref outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, byte* filePath, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, filePath, colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, byte* filePath, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, filePath, colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, byte* filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, byte* filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<byte> filePath, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, ref filePath.GetPinnableReference(), colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<byte> filePath, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, ref filePath.GetPinnableReference(), colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<byte> filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, ref filePath.GetPinnableReference(), ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<byte> filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, ref filePath.GetPinnableReference(), ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, string filePath, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, filePath, colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, string filePath, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, filePath, colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, string filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, string filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, byte* filePath, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, filePath, colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, byte* filePath, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, filePath, colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, byte* filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, byte* filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<byte> filePath, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, ref filePath.GetPinnableReference(), colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<byte> filePath, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, ref filePath.GetPinnableReference(), colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<byte> filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, ref filePath.GetPinnableReference(), ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<byte> filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, ref filePath.GetPinnableReference(), ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, string filePath, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, filePath, colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, string filePath, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, filePath, colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, string filePath, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, string filePath, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithFile(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, filePath, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(renderingService, outputImageRect, transform, layer, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, RenderingServiceHandle* renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(renderingService, outputImageRect, transform, layer, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(renderingService, ref outputImageRect, transform, layer, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(renderingService, ref outputImageRect, transform, layer, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ImageRectHandle** outputImageRect, Transform transform, int layer, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(ref renderingService.GetPinnableReference(), outputImageRect, transform, layer, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, RGBAConfigHandle* colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, colourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, RGBAConfigHandle* colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, colourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<RGBAConfigHandle> colourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, ref colourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateImageRectWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref ImageRectHandle* outputImageRect, Transform transform, int layer, Span<RGBAConfigHandle> colourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateImageRectWithNothing(ref renderingService.GetPinnableReference(), ref outputImageRect, transform, layer, ref colourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, BasicFillRectHandle** outputBasicFillRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(renderingService, outputBasicFillRect, transform, layer, ref colourConfig.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, BasicFillRectHandle** outputBasicFillRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(renderingService, outputBasicFillRect, transform, layer, ref colourConfig.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref BasicFillRectHandle* outputBasicFillRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(renderingService, ref outputBasicFillRect, transform, layer, ref colourConfig.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref BasicFillRectHandle* outputBasicFillRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(renderingService, ref outputBasicFillRect, transform, layer, ref colourConfig.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, BasicFillRectHandle** outputBasicFillRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(ref renderingService.GetPinnableReference(), outputBasicFillRect, transform, layer, colourConfig, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, BasicFillRectHandle** outputBasicFillRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(ref renderingService.GetPinnableReference(), outputBasicFillRect, transform, layer, colourConfig, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, BasicFillRectHandle** outputBasicFillRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(ref renderingService.GetPinnableReference(), outputBasicFillRect, transform, layer, ref colourConfig.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, BasicFillRectHandle** outputBasicFillRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(ref renderingService.GetPinnableReference(), outputBasicFillRect, transform, layer, ref colourConfig.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref BasicFillRectHandle* outputBasicFillRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(ref renderingService.GetPinnableReference(), ref outputBasicFillRect, transform, layer, colourConfig, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref BasicFillRectHandle* outputBasicFillRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(ref renderingService.GetPinnableReference(), ref outputBasicFillRect, transform, layer, colourConfig, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref BasicFillRectHandle* outputBasicFillRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(ref renderingService.GetPinnableReference(), ref outputBasicFillRect, transform, layer, ref colourConfig.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateBasicFillRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref BasicFillRectHandle* outputBasicFillRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateBasicFillRect(ref renderingService.GetPinnableReference(), ref outputBasicFillRect, transform, layer, ref colourConfig.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, Span<byte> fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, outputTextRect, transform, layer, colourConfig, fontSize, ref fontFilePath.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, Span<byte> fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, outputTextRect, transform, layer, colourConfig, fontSize, ref fontFilePath.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, byte* fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, byte* fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, Span<byte> fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, ref fontFilePath.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, Span<byte> fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, ref fontFilePath.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, string fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, string fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, Span<byte> fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, ref outputTextRect, transform, layer, colourConfig, fontSize, ref fontFilePath.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, Span<byte> fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, ref outputTextRect, transform, layer, colourConfig, fontSize, ref fontFilePath.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, byte* fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, byte* fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, Span<byte> fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, ref fontFilePath.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, Span<byte> fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, ref fontFilePath.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, string fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, string fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(renderingService, ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, byte* fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, colourConfig, fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, byte* fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, colourConfig, fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, Span<byte> fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, colourConfig, fontSize, ref fontFilePath.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, Span<byte> fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, colourConfig, fontSize, ref fontFilePath.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, string fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, colourConfig, fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, string fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, colourConfig, fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, byte* fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, byte* fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, Span<byte> fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, ref fontFilePath.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, Span<byte> fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, ref fontFilePath.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, string fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextRectHandle** outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, string fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, byte* fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, colourConfig, fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, byte* fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, colourConfig, fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, Span<byte> fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, colourConfig, fontSize, ref fontFilePath.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, Span<byte> fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, colourConfig, fontSize, ref fontFilePath.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, string fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, colourConfig, fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, RGBAConfigHandle* colourConfig, float fontSize, string fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, colourConfig, fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, byte* fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, byte* fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, Span<byte> fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, ref fontFilePath.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, Span<byte> fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, ref fontFilePath.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, string fontFilePath, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceCreateTextRect(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextRectHandle* outputTextRect, Transform transform, int layer, Span<RGBAConfigHandle> colourConfig, float fontSize, string fontFilePath, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceCreateTextRect(ref renderingService.GetPinnableReference(), ref outputTextRect, transform, layer, ref colourConfig.GetPinnableReference(), fontSize, fontFilePath, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetCamera(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, CameraHandle** outputCamera, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetCamera(ref renderingService.GetPinnableReference(), outputCamera, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetCamera(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, CameraHandle** outputCamera, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetCamera(ref renderingService.GetPinnableReference(), outputCamera, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetCamera(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref CameraHandle* outputCamera, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetCamera(ref renderingService.GetPinnableReference(), ref outputCamera, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetCamera(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref CameraHandle* outputCamera, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetCamera(ref renderingService.GetPinnableReference(), ref outputCamera, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceBeginFrame(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceBeginFrame(ref renderingService.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceBeginFrame(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceBeginFrame(ref renderingService.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceEndFrame(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceEndFrame(ref renderingService.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceEndFrame(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceEndFrame(ref renderingService.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceSetBackgroundColour(this NovelRT thisApi, RenderingServiceHandle* renderingService, Span<RGBAConfigHandle> colour, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceSetBackgroundColour(renderingService, ref colour.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceSetBackgroundColour(this NovelRT thisApi, RenderingServiceHandle* renderingService, Span<RGBAConfigHandle> colour, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceSetBackgroundColour(renderingService, ref colour.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceSetBackgroundColour(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, RGBAConfigHandle* colour, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceSetBackgroundColour(ref renderingService.GetPinnableReference(), colour, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceSetBackgroundColour(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, RGBAConfigHandle* colour, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceSetBackgroundColour(ref renderingService.GetPinnableReference(), colour, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceSetBackgroundColour(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, Span<RGBAConfigHandle> colour, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceSetBackgroundColour(ref renderingService.GetPinnableReference(), ref colour.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceSetBackgroundColour(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, Span<RGBAConfigHandle> colour, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceSetBackgroundColour(ref renderingService.GetPinnableReference(), ref colour.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextureHandle** outputTexture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithNothing(ref renderingService.GetPinnableReference(), outputTexture, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextureHandle** outputTexture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithNothing(ref renderingService.GetPinnableReference(), outputTexture, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextureHandle* outputTexture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithNothing(ref renderingService.GetPinnableReference(), ref outputTexture, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithNothing(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextureHandle* outputTexture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithNothing(ref renderingService.GetPinnableReference(), ref outputTexture, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextureHandle** outputTexture, Span<byte> fileTarget, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(renderingService, outputTexture, ref fileTarget.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, TextureHandle** outputTexture, Span<byte> fileTarget, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(renderingService, outputTexture, ref fileTarget.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextureHandle* outputTexture, Span<byte> fileTarget, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(renderingService, ref outputTexture, ref fileTarget.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref TextureHandle* outputTexture, Span<byte> fileTarget, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(renderingService, ref outputTexture, ref fileTarget.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextureHandle** outputTexture, byte* fileTarget, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), outputTexture, fileTarget, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextureHandle** outputTexture, byte* fileTarget, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), outputTexture, fileTarget, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextureHandle** outputTexture, Span<byte> fileTarget, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), outputTexture, ref fileTarget.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextureHandle** outputTexture, Span<byte> fileTarget, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), outputTexture, ref fileTarget.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextureHandle** outputTexture, string fileTarget, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), outputTexture, fileTarget, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, TextureHandle** outputTexture, string fileTarget, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), outputTexture, fileTarget, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextureHandle* outputTexture, byte* fileTarget, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), ref outputTexture, fileTarget, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextureHandle* outputTexture, byte* fileTarget, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), ref outputTexture, fileTarget, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextureHandle* outputTexture, Span<byte> fileTarget, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), ref outputTexture, ref fileTarget.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextureHandle* outputTexture, Span<byte> fileTarget, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), ref outputTexture, ref fileTarget.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextureHandle* outputTexture, string fileTarget, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), ref outputTexture, fileTarget, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetTextureWithFile(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref TextureHandle* outputTexture, string fileTarget, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetTextureWithFile(ref renderingService.GetPinnableReference(), ref outputTexture, fileTarget, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, RenderingServiceHandle* renderingService, FontSetHandle** outputFontSet, Span<byte> fileTarget, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(renderingService, outputFontSet, ref fileTarget.GetPinnableReference(), fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, RenderingServiceHandle* renderingService, FontSetHandle** outputFontSet, Span<byte> fileTarget, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(renderingService, outputFontSet, ref fileTarget.GetPinnableReference(), fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref FontSetHandle* outputFontSet, Span<byte> fileTarget, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(renderingService, ref outputFontSet, ref fileTarget.GetPinnableReference(), fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, RenderingServiceHandle* renderingService, ref FontSetHandle* outputFontSet, Span<byte> fileTarget, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(renderingService, ref outputFontSet, ref fileTarget.GetPinnableReference(), fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, FontSetHandle** outputFontSet, byte* fileTarget, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), outputFontSet, fileTarget, fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, FontSetHandle** outputFontSet, byte* fileTarget, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), outputFontSet, fileTarget, fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, FontSetHandle** outputFontSet, Span<byte> fileTarget, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), outputFontSet, ref fileTarget.GetPinnableReference(), fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, FontSetHandle** outputFontSet, Span<byte> fileTarget, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), outputFontSet, ref fileTarget.GetPinnableReference(), fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, FontSetHandle** outputFontSet, string fileTarget, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), outputFontSet, fileTarget, fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, FontSetHandle** outputFontSet, string fileTarget, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), outputFontSet, fileTarget, fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref FontSetHandle* outputFontSet, byte* fileTarget, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), ref outputFontSet, fileTarget, fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref FontSetHandle* outputFontSet, byte* fileTarget, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), ref outputFontSet, fileTarget, fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref FontSetHandle* outputFontSet, Span<byte> fileTarget, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), ref outputFontSet, ref fileTarget.GetPinnableReference(), fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref FontSetHandle* outputFontSet, Span<byte> fileTarget, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), ref outputFontSet, ref fileTarget.GetPinnableReference(), fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref FontSetHandle* outputFontSet, string fileTarget, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), ref outputFontSet, fileTarget, fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceGetFontSet(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref FontSetHandle* outputFontSet, string fileTarget, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceGetFontSet(ref renderingService.GetPinnableReference(), ref outputFontSet, fileTarget, fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceDestroy(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceDestroy(ref renderingService.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTRenderingService.h")]
        public static unsafe int RenderingServiceDestroy(this NovelRT thisApi, Span<RenderingServiceHandle> renderingService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderingServiceDestroy(ref renderingService.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, UtilitiesEventHandle* sceneConstructionEvent, Span<RenderingServiceHandle> renderingService, DebugServiceHandle** outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(sceneConstructionEvent, ref renderingService.GetPinnableReference(), outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, UtilitiesEventHandle* sceneConstructionEvent, Span<RenderingServiceHandle> renderingService, DebugServiceHandle** outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(sceneConstructionEvent, ref renderingService.GetPinnableReference(), outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, UtilitiesEventHandle* sceneConstructionEvent, Span<RenderingServiceHandle> renderingService, ref DebugServiceHandle* outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(sceneConstructionEvent, ref renderingService.GetPinnableReference(), ref outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, UtilitiesEventHandle* sceneConstructionEvent, Span<RenderingServiceHandle> renderingService, ref DebugServiceHandle* outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(sceneConstructionEvent, ref renderingService.GetPinnableReference(), ref outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, Span<UtilitiesEventHandle> sceneConstructionEvent, RenderingServiceHandle* renderingService, DebugServiceHandle** outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(ref sceneConstructionEvent.GetPinnableReference(), renderingService, outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, Span<UtilitiesEventHandle> sceneConstructionEvent, RenderingServiceHandle* renderingService, DebugServiceHandle** outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(ref sceneConstructionEvent.GetPinnableReference(), renderingService, outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, Span<UtilitiesEventHandle> sceneConstructionEvent, RenderingServiceHandle* renderingService, ref DebugServiceHandle* outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(ref sceneConstructionEvent.GetPinnableReference(), renderingService, ref outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, Span<UtilitiesEventHandle> sceneConstructionEvent, RenderingServiceHandle* renderingService, ref DebugServiceHandle* outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(ref sceneConstructionEvent.GetPinnableReference(), renderingService, ref outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, Span<UtilitiesEventHandle> sceneConstructionEvent, Span<RenderingServiceHandle> renderingService, DebugServiceHandle** outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(ref sceneConstructionEvent.GetPinnableReference(), ref renderingService.GetPinnableReference(), outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, Span<UtilitiesEventHandle> sceneConstructionEvent, Span<RenderingServiceHandle> renderingService, DebugServiceHandle** outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(ref sceneConstructionEvent.GetPinnableReference(), ref renderingService.GetPinnableReference(), outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, Span<UtilitiesEventHandle> sceneConstructionEvent, Span<RenderingServiceHandle> renderingService, ref DebugServiceHandle* outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(ref sceneConstructionEvent.GetPinnableReference(), ref renderingService.GetPinnableReference(), ref outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceCreate(this NovelRT thisApi, Span<UtilitiesEventHandle> sceneConstructionEvent, Span<RenderingServiceHandle> renderingService, ref DebugServiceHandle* outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceCreate(ref sceneConstructionEvent.GetPinnableReference(), ref renderingService.GetPinnableReference(), ref outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetIsFpsCounterVisible(this NovelRT thisApi, DebugServiceHandle* service, Span<int> result, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetIsFpsCounterVisible(service, ref result.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetIsFpsCounterVisible(this NovelRT thisApi, DebugServiceHandle* service, Span<int> result, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetIsFpsCounterVisible(service, ref result.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetIsFpsCounterVisible(this NovelRT thisApi, Span<DebugServiceHandle> service, int* result, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetIsFpsCounterVisible(ref service.GetPinnableReference(), result, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetIsFpsCounterVisible(this NovelRT thisApi, Span<DebugServiceHandle> service, int* result, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetIsFpsCounterVisible(ref service.GetPinnableReference(), result, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetIsFpsCounterVisible(this NovelRT thisApi, Span<DebugServiceHandle> service, Span<int> result, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetIsFpsCounterVisible(ref service.GetPinnableReference(), ref result.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetIsFpsCounterVisible(this NovelRT thisApi, Span<DebugServiceHandle> service, Span<int> result, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetIsFpsCounterVisible(ref service.GetPinnableReference(), ref result.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceSetIsFpsCounterVisible(this NovelRT thisApi, Span<DebugServiceHandle> service, int value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceSetIsFpsCounterVisible(ref service.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceSetIsFpsCounterVisible(this NovelRT thisApi, Span<DebugServiceHandle> service, int value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceSetIsFpsCounterVisible(ref service.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetFramesPerSecond(this NovelRT thisApi, DebugServiceHandle* service, Span<uint> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetFramesPerSecond(service, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetFramesPerSecond(this NovelRT thisApi, DebugServiceHandle* service, Span<uint> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetFramesPerSecond(service, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetFramesPerSecond(this NovelRT thisApi, Span<DebugServiceHandle> service, uint* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetFramesPerSecond(ref service.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetFramesPerSecond(this NovelRT thisApi, Span<DebugServiceHandle> service, uint* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetFramesPerSecond(ref service.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetFramesPerSecond(this NovelRT thisApi, Span<DebugServiceHandle> service, Span<uint> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetFramesPerSecond(ref service.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceGetFramesPerSecond(this NovelRT thisApi, Span<DebugServiceHandle> service, Span<uint> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceGetFramesPerSecond(ref service.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceSetFramesPerSecond(this NovelRT thisApi, Span<DebugServiceHandle> service, uint value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceSetFramesPerSecond(ref service.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/NovelRTDebugService.h")]
        public static unsafe int DebugServiceSetFramesPerSecond(this NovelRT thisApi, Span<DebugServiceHandle> service, uint value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DebugServiceSetFramesPerSecond(ref service.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 25 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe LoggingServiceHandle* LoggingServiceCreateCustomTitle(this NovelRT thisApi, Span<byte> core)
        {
            // SpanOverloader
            return thisApi.LoggingServiceCreateCustomTitle(ref core.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 25 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe LoggingServiceHandle* LoggingServiceCreateCustomTitleAndLevel(this NovelRT thisApi, Span<byte> core, LogLevel level)
        {
            // SpanOverloader
            return thisApi.LoggingServiceCreateCustomTitleAndLevel(ref core.GetPinnableReference(), level);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLog(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, LogLevel level, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLog(service, ref message.GetPinnableReference(), level, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLog(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, LogLevel level, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLog(service, ref message.GetPinnableReference(), level, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLog(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, LogLevel level, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLog(ref service.GetPinnableReference(), message, level, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLog(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, LogLevel level, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLog(ref service.GetPinnableReference(), message, level, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLog(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, LogLevel level, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLog(ref service.GetPinnableReference(), ref message.GetPinnableReference(), level, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLog(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, LogLevel level, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLog(ref service.GetPinnableReference(), ref message.GetPinnableReference(), level, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLog(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, LogLevel level, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLog(ref service.GetPinnableReference(), message, level, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLog(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, LogLevel level, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLog(ref service.GetPinnableReference(), message, level, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInfoLine(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInfoLine(service, ref message.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInfoLine(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInfoLine(service, ref message.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInfoLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInfoLine(ref service.GetPinnableReference(), message, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInfoLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInfoLine(ref service.GetPinnableReference(), message, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInfoLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInfoLine(ref service.GetPinnableReference(), ref message.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInfoLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInfoLine(ref service.GetPinnableReference(), ref message.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInfoLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInfoLine(ref service.GetPinnableReference(), message, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInfoLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInfoLine(ref service.GetPinnableReference(), message, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogErrorLine(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogErrorLine(service, ref message.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogErrorLine(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogErrorLine(service, ref message.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogErrorLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogErrorLine(ref service.GetPinnableReference(), message, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogErrorLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogErrorLine(ref service.GetPinnableReference(), message, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogErrorLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogErrorLine(ref service.GetPinnableReference(), ref message.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogErrorLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogErrorLine(ref service.GetPinnableReference(), ref message.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogErrorLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogErrorLine(ref service.GetPinnableReference(), message, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogErrorLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogErrorLine(ref service.GetPinnableReference(), message, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogWarningLine(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogWarningLine(service, ref message.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogWarningLine(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogWarningLine(service, ref message.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogWarningLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogWarningLine(ref service.GetPinnableReference(), message, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogWarningLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogWarningLine(ref service.GetPinnableReference(), message, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogWarningLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogWarningLine(ref service.GetPinnableReference(), ref message.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogWarningLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogWarningLine(ref service.GetPinnableReference(), ref message.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogWarningLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogWarningLine(ref service.GetPinnableReference(), message, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogWarningLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogWarningLine(ref service.GetPinnableReference(), message, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogDebugLine(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogDebugLine(service, ref message.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogDebugLine(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogDebugLine(service, ref message.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogDebugLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogDebugLine(ref service.GetPinnableReference(), message, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogDebugLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogDebugLine(ref service.GetPinnableReference(), message, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogDebugLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogDebugLine(ref service.GetPinnableReference(), ref message.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogDebugLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogDebugLine(ref service.GetPinnableReference(), ref message.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogDebugLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogDebugLine(ref service.GetPinnableReference(), message, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogDebugLine(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogDebugLine(ref service.GetPinnableReference(), message, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInternal(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, LogLevel level, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInternal(service, ref message.GetPinnableReference(), level, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInternal(this NovelRT thisApi, LoggingServiceHandle* service, Span<byte> message, LogLevel level, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInternal(service, ref message.GetPinnableReference(), level, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInternal(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, LogLevel level, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInternal(ref service.GetPinnableReference(), message, level, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInternal(this NovelRT thisApi, Span<LoggingServiceHandle> service, byte* message, LogLevel level, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInternal(ref service.GetPinnableReference(), message, level, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInternal(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, LogLevel level, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInternal(ref service.GetPinnableReference(), ref message.GetPinnableReference(), level, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInternal(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<byte> message, LogLevel level, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInternal(ref service.GetPinnableReference(), ref message.GetPinnableReference(), level, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInternal(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, LogLevel level, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInternal(ref service.GetPinnableReference(), message, level, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceLogInternal(this NovelRT thisApi, Span<LoggingServiceHandle> service, string message, LogLevel level, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceLogInternal(ref service.GetPinnableReference(), message, level, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceSetLogLevel(this NovelRT thisApi, Span<LoggingServiceHandle> service, LogLevel level, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceSetLogLevel(ref service.GetPinnableReference(), level, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceSetLogLevel(this NovelRT thisApi, Span<LoggingServiceHandle> service, LogLevel level, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceSetLogLevel(ref service.GetPinnableReference(), level, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr(this NovelRT thisApi, LoggingServiceHandle* service, void* @object, Span<byte> exceptionMessage, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(service, @object, ref exceptionMessage.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr(this NovelRT thisApi, LoggingServiceHandle* service, void* @object, Span<byte> exceptionMessage, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(service, @object, ref exceptionMessage.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, LoggingServiceHandle* service, Span<T0> @object, byte* exceptionMessage, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(service, ref @object.GetPinnableReference(), exceptionMessage, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, LoggingServiceHandle* service, Span<T0> @object, byte* exceptionMessage, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(service, ref @object.GetPinnableReference(), exceptionMessage, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, LoggingServiceHandle* service, Span<T0> @object, Span<byte> exceptionMessage, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(service, ref @object.GetPinnableReference(), ref exceptionMessage.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, LoggingServiceHandle* service, Span<T0> @object, Span<byte> exceptionMessage, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(service, ref @object.GetPinnableReference(), ref exceptionMessage.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, LoggingServiceHandle* service, Span<T0> @object, string exceptionMessage, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(service, ref @object.GetPinnableReference(), exceptionMessage, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, LoggingServiceHandle* service, Span<T0> @object, string exceptionMessage, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(service, ref @object.GetPinnableReference(), exceptionMessage, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr(this NovelRT thisApi, Span<LoggingServiceHandle> service, void* @object, byte* exceptionMessage, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), @object, exceptionMessage, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr(this NovelRT thisApi, Span<LoggingServiceHandle> service, void* @object, byte* exceptionMessage, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), @object, exceptionMessage, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr(this NovelRT thisApi, Span<LoggingServiceHandle> service, void* @object, Span<byte> exceptionMessage, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), @object, ref exceptionMessage.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr(this NovelRT thisApi, Span<LoggingServiceHandle> service, void* @object, Span<byte> exceptionMessage, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), @object, ref exceptionMessage.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr(this NovelRT thisApi, Span<LoggingServiceHandle> service, void* @object, string exceptionMessage, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), @object, exceptionMessage, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr(this NovelRT thisApi, Span<LoggingServiceHandle> service, void* @object, string exceptionMessage, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), @object, exceptionMessage, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<T0> @object, byte* exceptionMessage, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), ref @object.GetPinnableReference(), exceptionMessage, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<T0> @object, byte* exceptionMessage, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), ref @object.GetPinnableReference(), exceptionMessage, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<T0> @object, Span<byte> exceptionMessage, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), ref @object.GetPinnableReference(), ref exceptionMessage.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<T0> @object, Span<byte> exceptionMessage, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), ref @object.GetPinnableReference(), ref exceptionMessage.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<T0> @object, string exceptionMessage, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), ref @object.GetPinnableReference(), exceptionMessage, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNullPtr<T0>(this NovelRT thisApi, Span<LoggingServiceHandle> service, Span<T0> @object, string exceptionMessage, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNullPtr(ref service.GetPinnableReference(), ref @object.GetPinnableReference(), exceptionMessage, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNotZero(this NovelRT thisApi, LoggingServiceHandle* service, int error, Span<byte> exceptionMessage, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNotZero(service, error, ref exceptionMessage.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNotZero(this NovelRT thisApi, LoggingServiceHandle* service, int error, Span<byte> exceptionMessage, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNotZero(service, error, ref exceptionMessage.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNotZero(this NovelRT thisApi, Span<LoggingServiceHandle> service, int error, byte* exceptionMessage, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNotZero(ref service.GetPinnableReference(), error, exceptionMessage, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNotZero(this NovelRT thisApi, Span<LoggingServiceHandle> service, int error, byte* exceptionMessage, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNotZero(ref service.GetPinnableReference(), error, exceptionMessage, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNotZero(this NovelRT thisApi, Span<LoggingServiceHandle> service, int error, Span<byte> exceptionMessage, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNotZero(ref service.GetPinnableReference(), error, ref exceptionMessage.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNotZero(this NovelRT thisApi, Span<LoggingServiceHandle> service, int error, Span<byte> exceptionMessage, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNotZero(ref service.GetPinnableReference(), error, ref exceptionMessage.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNotZero(this NovelRT thisApi, Span<LoggingServiceHandle> service, int error, string exceptionMessage, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNotZero(ref service.GetPinnableReference(), error, exceptionMessage, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTLoggingService.h")]
        public static unsafe int LoggingServiceThrowIfNotZero(this NovelRT thisApi, Span<LoggingServiceHandle> service, int error, string exceptionMessage, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoggingServiceThrowIfNotZero(ref service.GetPinnableReference(), error, exceptionMessage, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceDestroy(this NovelRT thisApi, Span<AudioServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceDestroy(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceDestroy(this NovelRT thisApi, Span<AudioServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceDestroy(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceInitialiseAudio(this NovelRT thisApi, AudioServiceHandle* service, Span<int> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceInitialiseAudio(service, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceInitialiseAudio(this NovelRT thisApi, AudioServiceHandle* service, Span<int> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceInitialiseAudio(service, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceInitialiseAudio(this NovelRT thisApi, Span<AudioServiceHandle> service, int* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceInitialiseAudio(ref service.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceInitialiseAudio(this NovelRT thisApi, Span<AudioServiceHandle> service, int* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceInitialiseAudio(ref service.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceInitialiseAudio(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<int> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceInitialiseAudio(ref service.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceInitialiseAudio(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<int> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceInitialiseAudio(ref service.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, AudioServiceHandle* service, Span<byte> input, IteratorHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(service, ref input.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, AudioServiceHandle* service, Span<byte> input, IteratorHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(service, ref input.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, AudioServiceHandle* service, Span<byte> input, ref IteratorHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(service, ref input.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, AudioServiceHandle* service, Span<byte> input, ref IteratorHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(service, ref input.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, byte* input, IteratorHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), input, output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, byte* input, IteratorHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), input, output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, byte* input, ref IteratorHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), input, ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, byte* input, ref IteratorHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), input, ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<byte> input, IteratorHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), ref input.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<byte> input, IteratorHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), ref input.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<byte> input, ref IteratorHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), ref input.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<byte> input, ref IteratorHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), ref input.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, string input, IteratorHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), input, output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, string input, IteratorHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), input, output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, string input, ref IteratorHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), input, ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int LoadMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, string input, ref IteratorHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.LoadMusic(ref service.GetPinnableReference(), input, ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceSetSoundVolume(this NovelRT thisApi, Span<AudioServiceHandle> service, uint source, float val, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceSetSoundVolume(ref service.GetPinnableReference(), source, val, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceSetSoundVolume(this NovelRT thisApi, Span<AudioServiceHandle> service, uint source, float val, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceSetSoundVolume(ref service.GetPinnableReference(), source, val, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceSetSoundPosition(this NovelRT thisApi, Span<AudioServiceHandle> service, uint source, float posX, float posY, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceSetSoundPosition(ref service.GetPinnableReference(), source, posX, posY, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceSetSoundPosition(this NovelRT thisApi, Span<AudioServiceHandle> service, uint source, float posX, float posY, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceSetSoundPosition(ref service.GetPinnableReference(), source, posX, posY, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceResumeMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceResumeMusic(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceResumeMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceResumeMusic(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePlayMusic(this NovelRT thisApi, AudioServiceHandle* service, Span<IteratorHandle> handle, int loops, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePlayMusic(service, ref handle.GetPinnableReference(), loops, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePlayMusic(this NovelRT thisApi, AudioServiceHandle* service, Span<IteratorHandle> handle, int loops, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePlayMusic(service, ref handle.GetPinnableReference(), loops, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePlayMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, IteratorHandle* handle, int loops, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePlayMusic(ref service.GetPinnableReference(), handle, loops, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePlayMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, IteratorHandle* handle, int loops, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePlayMusic(ref service.GetPinnableReference(), handle, loops, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePlayMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<IteratorHandle> handle, int loops, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePlayMusic(ref service.GetPinnableReference(), ref handle.GetPinnableReference(), loops, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePlayMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<IteratorHandle> handle, int loops, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePlayMusic(ref service.GetPinnableReference(), ref handle.GetPinnableReference(), loops, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePauseMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePauseMusic(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePauseMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePauseMusic(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceStopMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceStopMusic(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceStopMusic(this NovelRT thisApi, Span<AudioServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceStopMusic(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceSetMusicVolume(this NovelRT thisApi, Span<AudioServiceHandle> service, float value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceSetMusicVolume(ref service.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceSetMusicVolume(this NovelRT thisApi, Span<AudioServiceHandle> service, float value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceSetMusicVolume(ref service.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceCheckSources(this NovelRT thisApi, Span<AudioServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceCheckSources(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceCheckSources(this NovelRT thisApi, Span<AudioServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceCheckSources(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, AudioServiceHandle* service, byte* input, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(service, input, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, AudioServiceHandle* service, byte* input, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(service, input, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, AudioServiceHandle* service, Span<byte> input, uint* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(service, ref input.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, AudioServiceHandle* service, Span<byte> input, uint* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(service, ref input.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, AudioServiceHandle* service, Span<byte> input, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(service, ref input.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, AudioServiceHandle* service, Span<byte> input, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(service, ref input.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, AudioServiceHandle* service, string input, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(service, input, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, AudioServiceHandle* service, string input, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(service, input, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, byte* input, uint* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), input, output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, byte* input, uint* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), input, output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, byte* input, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), input, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, byte* input, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), input, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<byte> input, uint* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), ref input.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<byte> input, uint* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), ref input.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<byte> input, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), ref input.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, Span<byte> input, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), ref input.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, string input, uint* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), input, output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, string input, uint* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), input, output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, string input, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), input, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceLoadSound(this NovelRT thisApi, Span<AudioServiceHandle> service, string input, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceLoadSound(ref service.GetPinnableReference(), input, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceUnload(this NovelRT thisApi, Span<AudioServiceHandle> service, uint handle, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceUnload(ref service.GetPinnableReference(), handle, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceUnload(this NovelRT thisApi, Span<AudioServiceHandle> service, uint handle, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceUnload(ref service.GetPinnableReference(), handle, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePlaySound(this NovelRT thisApi, Span<AudioServiceHandle> service, uint handle, int loops, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePlaySound(ref service.GetPinnableReference(), handle, loops, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServicePlaySound(this NovelRT thisApi, Span<AudioServiceHandle> service, uint handle, int loops, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServicePlaySound(ref service.GetPinnableReference(), handle, loops, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceStopSound(this NovelRT thisApi, Span<AudioServiceHandle> service, uint handle, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceStopSound(ref service.GetPinnableReference(), handle, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceStopSound(this NovelRT thisApi, Span<AudioServiceHandle> service, uint handle, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceStopSound(ref service.GetPinnableReference(), handle, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceTearDown(this NovelRT thisApi, Span<AudioServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceTearDown(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Audio/NovelRTAudioService.h")]
        public static unsafe int AudioServiceTearDown(this NovelRT thisApi, Span<AudioServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.AudioServiceTearDown(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetCurrentState(this NovelRT thisApi, ChangeLogHandle* changeLog, Span<KeyState> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetCurrentState(changeLog, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetCurrentState(this NovelRT thisApi, ChangeLogHandle* changeLog, Span<KeyState> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetCurrentState(changeLog, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetCurrentState(this NovelRT thisApi, Span<ChangeLogHandle> changeLog, KeyState* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetCurrentState(ref changeLog.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetCurrentState(this NovelRT thisApi, Span<ChangeLogHandle> changeLog, KeyState* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetCurrentState(ref changeLog.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetCurrentState(this NovelRT thisApi, Span<ChangeLogHandle> changeLog, Span<KeyState> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetCurrentState(ref changeLog.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetCurrentState(this NovelRT thisApi, Span<ChangeLogHandle> changeLog, Span<KeyState> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetCurrentState(ref changeLog.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetChangeCount(this NovelRT thisApi, ChangeLogHandle* changeLog, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetChangeCount(changeLog, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetChangeCount(this NovelRT thisApi, ChangeLogHandle* changeLog, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetChangeCount(changeLog, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetChangeCount(this NovelRT thisApi, Span<ChangeLogHandle> changeLog, uint* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetChangeCount(ref changeLog.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetChangeCount(this NovelRT thisApi, Span<ChangeLogHandle> changeLog, uint* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetChangeCount(ref changeLog.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetChangeCount(this NovelRT thisApi, Span<ChangeLogHandle> changeLog, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetChangeCount(ref changeLog.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogGetChangeCount(this NovelRT thisApi, Span<ChangeLogHandle> changeLog, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogGetChangeCount(ref changeLog.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogCompareChangeLog(this NovelRT thisApi, Span<ChangeLogHandle> lhs, KeyState rhs)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogCompareChangeLog(ref lhs.GetPinnableReference(), rhs);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTKeyStateFrameChangeLog.h")]
        public static unsafe int KeyStateFrameChangeLogCompareKeyState(this NovelRT thisApi, KeyState lhs, Span<ChangeLogHandle> rhs)
        {
            // SpanOverloader
            return thisApi.KeyStateFrameChangeLogCompareKeyState(lhs, ref rhs.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectExecuteObjectBehaviour(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectExecuteObjectBehaviour(ref @object.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectExecuteObjectBehaviour(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectExecuteObjectBehaviour(ref @object.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetTransform(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<Transform> outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetTransform(@object, ref outputTransform.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetTransform(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<Transform> outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetTransform(@object, ref outputTransform.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetTransform(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Transform* outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetTransform(ref @object.GetPinnableReference(), outputTransform, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetTransform(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Transform* outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetTransform(ref @object.GetPinnableReference(), outputTransform, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetTransform(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<Transform> outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetTransform(ref @object.GetPinnableReference(), ref outputTransform.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetTransform(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<Transform> outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetTransform(ref @object.GetPinnableReference(), ref outputTransform.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectSetTransform(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Transform transform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectSetTransform(ref @object.GetPinnableReference(), transform, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectSetTransform(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Transform transform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectSetTransform(ref @object.GetPinnableReference(), transform, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetLayer(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetLayer(@object, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetLayer(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetLayer(@object, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetLayer(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, int* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetLayer(ref @object.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetLayer(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, int* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetLayer(ref @object.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetLayer(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetLayer(ref @object.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetLayer(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetLayer(ref @object.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectSetLayer(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, int value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectSetLayer(ref @object.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectSetLayer(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, int value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectSetLayer(ref @object.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetActive(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetActive(@object, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetActive(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetActive(@object, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetActive(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, int* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetActive(ref @object.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetActive(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, int* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetActive(ref @object.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetActive(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<int> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetActive(ref @object.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetActive(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<int> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetActive(ref @object.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectSetActive(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, int value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectSetActive(ref @object.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectSetActive(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, int value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectSetActive(ref @object.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectValidateInteractionPrimeter(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, GeoVector2F mousePosition, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectValidateInteractionPrimeter(ref @object.GetPinnableReference(), mousePosition, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectValidateInteractionPrimeter(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, GeoVector2F mousePosition, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectValidateInteractionPrimeter(ref @object.GetPinnableReference(), mousePosition, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetSubscribedKey(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<KeyCode> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetSubscribedKey(@object, ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetSubscribedKey(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<KeyCode> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetSubscribedKey(@object, ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetSubscribedKey(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, KeyCode* outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetSubscribedKey(ref @object.GetPinnableReference(), outputValue, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetSubscribedKey(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, KeyCode* outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetSubscribedKey(ref @object.GetPinnableReference(), outputValue, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetSubscribedKey(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<KeyCode> outputValue, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetSubscribedKey(ref @object.GetPinnableReference(), ref outputValue.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectGetSubscribedKey(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<KeyCode> outputValue, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectGetSubscribedKey(ref @object.GetPinnableReference(), ref outputValue.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectSetSubscribedKey(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, KeyCode value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectSetSubscribedKey(ref @object.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectSetSubscribedKey(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, KeyCode value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectSetSubscribedKey(ref @object.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectAddInteraction<T0>(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<T0> ptr, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectAddInteraction(@object, ref ptr.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectAddInteraction<T0>(this NovelRT thisApi, BasicInteractionRectHandle* @object, Span<T0> ptr, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectAddInteraction(@object, ref ptr.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectAddInteraction(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, void* ptr, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectAddInteraction(ref @object.GetPinnableReference(), ptr, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectAddInteraction(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, void* ptr, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectAddInteraction(ref @object.GetPinnableReference(), ptr, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectAddInteraction<T0>(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<T0> ptr, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectAddInteraction(ref @object.GetPinnableReference(), ref ptr.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTBasicInteractionRect.h")]
        public static unsafe int InputBasicInteractionRectAddInteraction<T0>(this NovelRT thisApi, Span<BasicInteractionRectHandle> @object, Span<T0> ptr, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.InputBasicInteractionRectAddInteraction(ref @object.GetPinnableReference(), ref ptr.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 27 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe InteractionServiceHandle* InteractionServiceCreate(this NovelRT thisApi, Span<WindowingServiceHandle> windowingService)
        {
            // SpanOverloader
            return thisApi.InteractionServiceCreate(ref windowingService.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceConsumePlayerInput(this NovelRT thisApi, Span<InteractionServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceConsumePlayerInput(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceConsumePlayerInput(this NovelRT thisApi, Span<InteractionServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceConsumePlayerInput(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceCreateBasicInteractionRect(this NovelRT thisApi, Span<InteractionServiceHandle> service, Transform transform, int layer, BasicInteractionRectHandle** outputRect, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceCreateBasicInteractionRect(ref service.GetPinnableReference(), transform, layer, outputRect, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceCreateBasicInteractionRect(this NovelRT thisApi, Span<InteractionServiceHandle> service, Transform transform, int layer, BasicInteractionRectHandle** outputRect, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceCreateBasicInteractionRect(ref service.GetPinnableReference(), transform, layer, outputRect, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceCreateBasicInteractionRect(this NovelRT thisApi, Span<InteractionServiceHandle> service, Transform transform, int layer, ref BasicInteractionRectHandle* outputRect, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceCreateBasicInteractionRect(ref service.GetPinnableReference(), transform, layer, ref outputRect, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceCreateBasicInteractionRect(this NovelRT thisApi, Span<InteractionServiceHandle> service, Transform transform, int layer, ref BasicInteractionRectHandle* outputRect, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceCreateBasicInteractionRect(ref service.GetPinnableReference(), transform, layer, ref outputRect, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceExecuteClickedInteractable(this NovelRT thisApi, Span<InteractionServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceExecuteClickedInteractable(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceExecuteClickedInteractable(this NovelRT thisApi, Span<InteractionServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceExecuteClickedInteractable(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceSetScreenSize(this NovelRT thisApi, Span<InteractionServiceHandle> service, GeoVector2F value, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceSetScreenSize(ref service.GetPinnableReference(), value, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceSetScreenSize(this NovelRT thisApi, Span<InteractionServiceHandle> service, GeoVector2F value, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceSetScreenSize(ref service.GetPinnableReference(), value, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceGetKeyState(this NovelRT thisApi, Span<InteractionServiceHandle> service, KeyCode value, ChangeLogHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceGetKeyState(ref service.GetPinnableReference(), value, output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceGetKeyState(this NovelRT thisApi, Span<InteractionServiceHandle> service, KeyCode value, ChangeLogHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceGetKeyState(ref service.GetPinnableReference(), value, output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceGetKeyState(this NovelRT thisApi, Span<InteractionServiceHandle> service, KeyCode value, ref ChangeLogHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceGetKeyState(ref service.GetPinnableReference(), value, ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Input/NovelRTInteractionService.h")]
        public static unsafe int InteractionServiceGetKeyState(this NovelRT thisApi, Span<InteractionServiceHandle> service, KeyCode value, ref ChangeLogHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.InteractionServiceGetKeyState(ref service.GetPinnableReference(), value, ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampIsNaN(this NovelRT thisApi, Span<TimestampHandle> timestamp, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampIsNaN(ref timestamp.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampIsNaN(this NovelRT thisApi, Span<TimestampHandle> timestamp, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampIsNaN(ref timestamp.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsDouble(this NovelRT thisApi, TimestampHandle* timestamp, Span<double> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsDouble(timestamp, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsDouble(this NovelRT thisApi, TimestampHandle* timestamp, Span<double> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsDouble(timestamp, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsDouble(this NovelRT thisApi, Span<TimestampHandle> timestamp, double* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsDouble(ref timestamp.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsDouble(this NovelRT thisApi, Span<TimestampHandle> timestamp, double* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsDouble(ref timestamp.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsDouble(this NovelRT thisApi, Span<TimestampHandle> timestamp, Span<double> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsDouble(ref timestamp.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsDouble(this NovelRT thisApi, Span<TimestampHandle> timestamp, Span<double> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsDouble(ref timestamp.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsFloat(this NovelRT thisApi, TimestampHandle* timestamp, Span<float> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsFloat(timestamp, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsFloat(this NovelRT thisApi, TimestampHandle* timestamp, Span<float> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsFloat(timestamp, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsFloat(this NovelRT thisApi, Span<TimestampHandle> timestamp, float* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsFloat(ref timestamp.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsFloat(this NovelRT thisApi, Span<TimestampHandle> timestamp, float* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsFloat(ref timestamp.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsFloat(this NovelRT thisApi, Span<TimestampHandle> timestamp, Span<float> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsFloat(ref timestamp.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGetSecondsFloat(this NovelRT thisApi, Span<TimestampHandle> timestamp, Span<float> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGetSecondsFloat(ref timestamp.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(first, ref other.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(first, ref other.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(first, ref other.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(first, ref other.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(ref first.GetPinnableReference(), other, output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(ref first.GetPinnableReference(), other, output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(ref first.GetPinnableReference(), other, ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(ref first.GetPinnableReference(), other, ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(first, ref other.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(first, ref other.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(first, ref other.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(first, ref other.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(ref first.GetPinnableReference(), other, output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(ref first.GetPinnableReference(), other, output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(ref first.GetPinnableReference(), other, ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(ref first.GetPinnableReference(), other, ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(first, ref other.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(first, ref other.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(first, ref other.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(first, ref other.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(ref first.GetPinnableReference(), other, output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(ref first.GetPinnableReference(), other, output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(ref first.GetPinnableReference(), other, ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(ref first.GetPinnableReference(), other, ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(first, ref other.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(first, ref other.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(first, ref other.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(first, ref other.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(ref first.GetPinnableReference(), other, output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(ref first.GetPinnableReference(), other, output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(ref first.GetPinnableReference(), other, ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(ref first.GetPinnableReference(), other, ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddAssignTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddAssignTimestamp(first, ref other.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddAssignTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddAssignTimestamp(first, ref other.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddAssignTimestamp(ref first.GetPinnableReference(), other, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddAssignTimestamp(ref first.GetPinnableReference(), other, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddAssignTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampAddAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampAddAssignTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractAssignTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractAssignTimestamp(first, ref other.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractAssignTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractAssignTimestamp(first, ref other.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractAssignTimestamp(ref first.GetPinnableReference(), other, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractAssignTimestamp(ref first.GetPinnableReference(), other, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractAssignTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampSubtractAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampSubtractAssignTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyAssignTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyAssignTimestamp(first, ref other.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyAssignTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyAssignTimestamp(first, ref other.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyAssignTimestamp(ref first.GetPinnableReference(), other, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyAssignTimestamp(ref first.GetPinnableReference(), other, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyAssignTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampMultiplyAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampMultiplyAssignTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideAssignTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideAssignTimestamp(first, ref other.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideAssignTimestamp(this NovelRT thisApi, TimestampHandle* first, Span<TimestampHandle> other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideAssignTimestamp(first, ref other.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideAssignTimestamp(ref first.GetPinnableReference(), other, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, TimestampHandle* other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideAssignTimestamp(ref first.GetPinnableReference(), other, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideAssignTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampDivideAssignTimestamp(this NovelRT thisApi, Span<TimestampHandle> first, Span<TimestampHandle> other, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampDivideAssignTimestamp(ref first.GetPinnableReference(), ref other.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThan(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThan(lhs, ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThan(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThan(lhs, ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThan(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThan(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThan(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThan(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThan(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThan(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThan(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThan(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThanOrEqualTo(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThanOrEqualTo(lhs, ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThanOrEqualTo(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThanOrEqualTo(lhs, ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThanOrEqualTo(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThanOrEqualTo(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThanOrEqualTo(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThanOrEqualTo(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThanOrEqualTo(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThanOrEqualTo(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampLessThanOrEqualTo(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampLessThanOrEqualTo(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThan(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThan(lhs, ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThan(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThan(lhs, ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThan(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThan(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThan(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThan(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThan(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThan(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThan(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThan(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThanOrEqualTo(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThanOrEqualTo(lhs, ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThanOrEqualTo(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThanOrEqualTo(lhs, ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThanOrEqualTo(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThanOrEqualTo(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThanOrEqualTo(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThanOrEqualTo(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThanOrEqualTo(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThanOrEqualTo(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampGreaterThanOrEqualTo(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampGreaterThanOrEqualTo(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampEqual(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampEqual(lhs, ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampEqual(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampEqual(lhs, ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampEqual(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampEqual(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampEqual(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampEqual(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampEqual(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampEqual(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampEqual(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampEqual(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampNotEqual(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampNotEqual(lhs, ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampNotEqual(this NovelRT thisApi, TimestampHandle* lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampNotEqual(lhs, ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampNotEqual(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampNotEqual(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampNotEqual(this NovelRT thisApi, Span<TimestampHandle> lhs, TimestampHandle* rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampNotEqual(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampNotEqual(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampNotEqual(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTTimestamp.h")]
        public static unsafe int TimestampNotEqual(this NovelRT thisApi, Span<TimestampHandle> lhs, Span<TimestampHandle> rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TimestampNotEqual(ref lhs.GetPinnableReference(), ref rhs.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/DotNet/NovelRTRuntimeService.h")]
        public static unsafe int RuntimeServiceDestroy(this NovelRT thisApi, Span<RuntimeServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RuntimeServiceDestroy(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/DotNet/NovelRTRuntimeService.h")]
        public static unsafe int RuntimeServiceDestroy(this NovelRT thisApi, Span<RuntimeServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RuntimeServiceDestroy(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/DotNet/NovelRTRuntimeService.h")]
        public static unsafe int RuntimeServiceInitialise(this NovelRT thisApi, Span<RuntimeServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RuntimeServiceInitialise(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/DotNet/NovelRTRuntimeService.h")]
        public static unsafe int RuntimeServiceInitialise(this NovelRT thisApi, Span<RuntimeServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RuntimeServiceInitialise(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/DotNet/NovelRTRuntimeService.h")]
        public static unsafe int RuntimeServiceTearDown(this NovelRT thisApi, Span<RuntimeServiceHandle> service, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RuntimeServiceTearDown(ref service.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/DotNet/NovelRTRuntimeService.h")]
        public static unsafe int RuntimeServiceTearDown(this NovelRT thisApi, Span<RuntimeServiceHandle> service, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RuntimeServiceTearDown(ref service.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 22 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe NovelRunnerHandle* NovelRunnerCreateCustom(this NovelRT thisApi, int displayNumber, Span<byte> windowTitle, uint targetFrameRate)
        {
            // SpanOverloader
            return thisApi.NovelRunnerCreateCustom(displayNumber, ref windowTitle.GetPinnableReference(), targetFrameRate);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerRunNovel(this NovelRT thisApi, Span<NovelRunnerHandle> runner, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerRunNovel(ref runner.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerRunNovel(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerRunNovel(ref runner.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerDestroy(this NovelRT thisApi, Span<NovelRunnerHandle> runner, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerDestroy(ref runner.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerDestroy(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerDestroy(ref runner.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetAudioService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, AudioServiceHandle** outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetAudioService(ref runner.GetPinnableReference(), outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetAudioService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, AudioServiceHandle** outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetAudioService(ref runner.GetPinnableReference(), outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetAudioService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref AudioServiceHandle* outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetAudioService(ref runner.GetPinnableReference(), ref outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetAudioService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref AudioServiceHandle* outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetAudioService(ref runner.GetPinnableReference(), ref outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetInteractionService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, InteractionServiceHandle** outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetInteractionService(ref runner.GetPinnableReference(), outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetInteractionService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, InteractionServiceHandle** outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetInteractionService(ref runner.GetPinnableReference(), outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetInteractionService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref InteractionServiceHandle* outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetInteractionService(ref runner.GetPinnableReference(), ref outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetInteractionService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref InteractionServiceHandle* outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetInteractionService(ref runner.GetPinnableReference(), ref outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetWindowingService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, WindowingServiceHandle** outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetWindowingService(ref runner.GetPinnableReference(), outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetWindowingService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, WindowingServiceHandle** outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetWindowingService(ref runner.GetPinnableReference(), outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetWindowingService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref WindowingServiceHandle* outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetWindowingService(ref runner.GetPinnableReference(), ref outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetWindowingService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref WindowingServiceHandle* outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetWindowingService(ref runner.GetPinnableReference(), ref outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetRuntimeService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, RuntimeServiceHandle** outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetRuntimeService(ref runner.GetPinnableReference(), outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetRuntimeService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, RuntimeServiceHandle** outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetRuntimeService(ref runner.GetPinnableReference(), outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetRuntimeService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref RuntimeServiceHandle* outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetRuntimeService(ref runner.GetPinnableReference(), ref outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetRuntimeService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref RuntimeServiceHandle* outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetRuntimeService(ref runner.GetPinnableReference(), ref outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetRenderer(this NovelRT thisApi, Span<NovelRunnerHandle> runner, RenderingServiceHandle** outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetRenderer(ref runner.GetPinnableReference(), outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetRenderer(this NovelRT thisApi, Span<NovelRunnerHandle> runner, RenderingServiceHandle** outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetRenderer(ref runner.GetPinnableReference(), outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetRenderer(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref RenderingServiceHandle* outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetRenderer(ref runner.GetPinnableReference(), ref outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetRenderer(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref RenderingServiceHandle* outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetRenderer(ref runner.GetPinnableReference(), ref outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetDebugService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, DebugServiceHandle** outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetDebugService(ref runner.GetPinnableReference(), outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetDebugService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, DebugServiceHandle** outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetDebugService(ref runner.GetPinnableReference(), outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetDebugService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref DebugServiceHandle* outputService, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetDebugService(ref runner.GetPinnableReference(), ref outputService, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetDebugService(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref DebugServiceHandle* outputService, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetDebugService(ref runner.GetPinnableReference(), ref outputService, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddUpdate<T0>(this NovelRT thisApi, NovelRunnerHandle* runner, Span<T0> func, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddUpdate(runner, ref func.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddUpdate<T0>(this NovelRT thisApi, NovelRunnerHandle* runner, Span<T0> func, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddUpdate(runner, ref func.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddUpdate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, void* func, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddUpdate(ref runner.GetPinnableReference(), func, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddUpdate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, void* func, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddUpdate(ref runner.GetPinnableReference(), func, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddUpdate<T0>(this NovelRT thisApi, Span<NovelRunnerHandle> runner, Span<T0> func, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddUpdate(ref runner.GetPinnableReference(), ref func.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddUpdate<T0>(this NovelRT thisApi, Span<NovelRunnerHandle> runner, Span<T0> func, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddUpdate(ref runner.GetPinnableReference(), ref func.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddSceneConstructionRequested<T0>(this NovelRT thisApi, NovelRunnerHandle* runner, Span<T0> func, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddSceneConstructionRequested(runner, ref func.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddSceneConstructionRequested<T0>(this NovelRT thisApi, NovelRunnerHandle* runner, Span<T0> func, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddSceneConstructionRequested(runner, ref func.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddSceneConstructionRequested(this NovelRT thisApi, Span<NovelRunnerHandle> runner, void* func, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddSceneConstructionRequested(ref runner.GetPinnableReference(), func, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddSceneConstructionRequested(this NovelRT thisApi, Span<NovelRunnerHandle> runner, void* func, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddSceneConstructionRequested(ref runner.GetPinnableReference(), func, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddSceneConstructionRequested<T0>(this NovelRT thisApi, Span<NovelRunnerHandle> runner, Span<T0> func, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddSceneConstructionRequested(ref runner.GetPinnableReference(), ref func.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerAddSceneConstructionRequested<T0>(this NovelRT thisApi, Span<NovelRunnerHandle> runner, Span<T0> func, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NovelRunnerAddSceneConstructionRequested(ref runner.GetPinnableReference(), ref func.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 36, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetUpdateEvent(this NovelRT thisApi, Span<NovelRunnerHandle> runner, UtilitiesEventWithTimestampHandle** outputEvent, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetUpdateEvent(ref runner.GetPinnableReference(), outputEvent, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 36, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetUpdateEvent(this NovelRT thisApi, Span<NovelRunnerHandle> runner, UtilitiesEventWithTimestampHandle** outputEvent, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetUpdateEvent(ref runner.GetPinnableReference(), outputEvent, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 36, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetUpdateEvent(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref UtilitiesEventWithTimestampHandle* outputEvent, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetUpdateEvent(ref runner.GetPinnableReference(), ref outputEvent, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 36, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetUpdateEvent(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref UtilitiesEventWithTimestampHandle* outputEvent, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetUpdateEvent(ref runner.GetPinnableReference(), ref outputEvent, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetSceneConstructionEvent(this NovelRT thisApi, Span<NovelRunnerHandle> runner, UtilitiesEventHandle** outputEvent, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetSceneConstructionEvent(ref runner.GetPinnableReference(), outputEvent, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetSceneConstructionEvent(this NovelRT thisApi, Span<NovelRunnerHandle> runner, UtilitiesEventHandle** outputEvent, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetSceneConstructionEvent(ref runner.GetPinnableReference(), outputEvent, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetSceneConstructionEvent(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref UtilitiesEventHandle* outputEvent, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetSceneConstructionEvent(ref runner.GetPinnableReference(), ref outputEvent, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/NovelRTNovelRunner.h")]
        public static unsafe int NovelRunnerGetSceneConstructionEvent(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ref UtilitiesEventHandle* outputEvent, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.NovelRunnerGetSceneConstructionEvent(ref runner.GetPinnableReference(), ref outputEvent, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameGetTexture(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, TextureHandle** outputTexture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameGetTexture(ref frame.GetPinnableReference(), outputTexture, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameGetTexture(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, TextureHandle** outputTexture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameGetTexture(ref frame.GetPinnableReference(), outputTexture, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameGetTexture(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, ref TextureHandle* outputTexture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameGetTexture(ref frame.GetPinnableReference(), ref outputTexture, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameGetTexture(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, ref TextureHandle* outputTexture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameGetTexture(ref frame.GetPinnableReference(), ref outputTexture, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetTexture(this NovelRT thisApi, SpriteAnimatorFrameHandle* frame, Span<TextureHandle> texture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetTexture(frame, ref texture.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetTexture(this NovelRT thisApi, SpriteAnimatorFrameHandle* frame, Span<TextureHandle> texture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetTexture(frame, ref texture.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetTexture(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, TextureHandle* texture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetTexture(ref frame.GetPinnableReference(), texture, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetTexture(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, TextureHandle* texture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetTexture(ref frame.GetPinnableReference(), texture, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetTexture(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, Span<TextureHandle> texture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetTexture(ref frame.GetPinnableReference(), ref texture.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetTexture(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, Span<TextureHandle> texture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetTexture(ref frame.GetPinnableReference(), ref texture.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameGetDuration(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, TimestampHandle** outputTimestamp, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameGetDuration(ref frame.GetPinnableReference(), outputTimestamp, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameGetDuration(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, TimestampHandle** outputTimestamp, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameGetDuration(ref frame.GetPinnableReference(), outputTimestamp, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameGetDuration(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, ref TimestampHandle* outputTimestamp, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameGetDuration(ref frame.GetPinnableReference(), ref outputTimestamp, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameGetDuration(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, ref TimestampHandle* outputTimestamp, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameGetDuration(ref frame.GetPinnableReference(), ref outputTimestamp, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetDuration(this NovelRT thisApi, SpriteAnimatorFrameHandle* frame, Span<TimestampHandle> timestamp, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetDuration(frame, ref timestamp.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetDuration(this NovelRT thisApi, SpriteAnimatorFrameHandle* frame, Span<TimestampHandle> timestamp, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetDuration(frame, ref timestamp.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetDuration(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, TimestampHandle* timestamp, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetDuration(ref frame.GetPinnableReference(), timestamp, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetDuration(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, TimestampHandle* timestamp, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetDuration(ref frame.GetPinnableReference(), timestamp, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetDuration(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, Span<TimestampHandle> timestamp, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetDuration(ref frame.GetPinnableReference(), ref timestamp.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameSetDuration(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, Span<TimestampHandle> timestamp, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameSetDuration(ref frame.GetPinnableReference(), ref timestamp.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameEnter<T0>(this NovelRT thisApi, SpriteAnimatorFrameHandle* frame, Span<T0> func, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameEnter(frame, ref func.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameEnter<T0>(this NovelRT thisApi, SpriteAnimatorFrameHandle* frame, Span<T0> func, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameEnter(frame, ref func.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameEnter(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, void* func, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameEnter(ref frame.GetPinnableReference(), func, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameEnter(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, void* func, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameEnter(ref frame.GetPinnableReference(), func, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameEnter<T0>(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, Span<T0> func, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameEnter(ref frame.GetPinnableReference(), ref func.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameEnter<T0>(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, Span<T0> func, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameEnter(ref frame.GetPinnableReference(), ref func.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameExit<T0>(this NovelRT thisApi, SpriteAnimatorFrameHandle* frame, Span<T0> func, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameExit(frame, ref func.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameExit<T0>(this NovelRT thisApi, SpriteAnimatorFrameHandle* frame, Span<T0> func, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameExit(frame, ref func.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameExit(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, void* func, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameExit(ref frame.GetPinnableReference(), func, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameExit(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, void* func, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameExit(ref frame.GetPinnableReference(), func, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameExit<T0>(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, Span<T0> func, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameExit(ref frame.GetPinnableReference(), ref func.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorFrame.h")]
        public static unsafe int SpriteAnimatorFrameAddFrameExit<T0>(this NovelRT thisApi, Span<SpriteAnimatorFrameHandle> frame, Span<T0> func, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameAddFrameExit(ref frame.GetPinnableReference(), ref func.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, SpriteAnimatorStateHandle* state, SpriteAnimatorStateHandle* stateTarget, Span<BoolFunctionVectorHandle> vector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(state, stateTarget, ref vector.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, SpriteAnimatorStateHandle* state, SpriteAnimatorStateHandle* stateTarget, Span<BoolFunctionVectorHandle> vector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(state, stateTarget, ref vector.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, SpriteAnimatorStateHandle* state, Span<SpriteAnimatorStateHandle> stateTarget, BoolFunctionVectorHandle* vector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(state, ref stateTarget.GetPinnableReference(), vector, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, SpriteAnimatorStateHandle* state, Span<SpriteAnimatorStateHandle> stateTarget, BoolFunctionVectorHandle* vector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(state, ref stateTarget.GetPinnableReference(), vector, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, SpriteAnimatorStateHandle* state, Span<SpriteAnimatorStateHandle> stateTarget, Span<BoolFunctionVectorHandle> vector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(state, ref stateTarget.GetPinnableReference(), ref vector.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, SpriteAnimatorStateHandle* state, Span<SpriteAnimatorStateHandle> stateTarget, Span<BoolFunctionVectorHandle> vector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(state, ref stateTarget.GetPinnableReference(), ref vector.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorStateHandle* stateTarget, BoolFunctionVectorHandle* vector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(ref state.GetPinnableReference(), stateTarget, vector, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorStateHandle* stateTarget, BoolFunctionVectorHandle* vector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(ref state.GetPinnableReference(), stateTarget, vector, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorStateHandle* stateTarget, Span<BoolFunctionVectorHandle> vector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(ref state.GetPinnableReference(), stateTarget, ref vector.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorStateHandle* stateTarget, Span<BoolFunctionVectorHandle> vector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(ref state.GetPinnableReference(), stateTarget, ref vector.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, Span<SpriteAnimatorStateHandle> stateTarget, BoolFunctionVectorHandle* vector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(ref state.GetPinnableReference(), ref stateTarget.GetPinnableReference(), vector, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, Span<SpriteAnimatorStateHandle> stateTarget, BoolFunctionVectorHandle* vector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(ref state.GetPinnableReference(), ref stateTarget.GetPinnableReference(), vector, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, Span<SpriteAnimatorStateHandle> stateTarget, Span<BoolFunctionVectorHandle> vector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(ref state.GetPinnableReference(), ref stateTarget.GetPinnableReference(), ref vector.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, Span<SpriteAnimatorStateHandle> stateTarget, Span<BoolFunctionVectorHandle> vector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateInsertNewState(ref state.GetPinnableReference(), ref stateTarget.GetPinnableReference(), ref vector.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateRemoveStateAtIndex(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, uint index, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateRemoveStateAtIndex(ref state.GetPinnableReference(), index, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateRemoveStateAtIndex(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, uint index, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateRemoveStateAtIndex(ref state.GetPinnableReference(), index, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetShouldLoop(this NovelRT thisApi, SpriteAnimatorStateHandle* state, Span<int> outputLoop, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetShouldLoop(state, ref outputLoop.GetPinnableReference(), errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetShouldLoop(this NovelRT thisApi, SpriteAnimatorStateHandle* state, Span<int> outputLoop, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetShouldLoop(state, ref outputLoop.GetPinnableReference(), ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetShouldLoop(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, int* outputLoop, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetShouldLoop(ref state.GetPinnableReference(), outputLoop, errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetShouldLoop(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, int* outputLoop, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetShouldLoop(ref state.GetPinnableReference(), outputLoop, ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetShouldLoop(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, Span<int> outputLoop, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetShouldLoop(ref state.GetPinnableReference(), ref outputLoop.GetPinnableReference(), errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetShouldLoop(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, Span<int> outputLoop, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetShouldLoop(ref state.GetPinnableReference(), ref outputLoop.GetPinnableReference(), ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateSetShouldLoop(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, int loop, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateSetShouldLoop(ref state.GetPinnableReference(), loop, errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateSetShouldLoop(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, int loop, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateSetShouldLoop(ref state.GetPinnableReference(), loop, ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetFrames(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorFrameVectorHandle** outputFramess, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetFrames(ref state.GetPinnableReference(), outputFramess, errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetFrames(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorFrameVectorHandle** outputFramess, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetFrames(ref state.GetPinnableReference(), outputFramess, ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetFrames(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, ref SpriteAnimatorFrameVectorHandle* outputFramess, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetFrames(ref state.GetPinnableReference(), ref outputFramess, errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateGetFrames(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, ref SpriteAnimatorFrameVectorHandle* outputFramess, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateGetFrames(ref state.GetPinnableReference(), ref outputFramess, ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateSetFrames(this NovelRT thisApi, SpriteAnimatorStateHandle* state, Span<SpriteAnimatorFrameVectorHandle> frames, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateSetFrames(state, ref frames.GetPinnableReference(), errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateSetFrames(this NovelRT thisApi, SpriteAnimatorStateHandle* state, Span<SpriteAnimatorFrameVectorHandle> frames, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateSetFrames(state, ref frames.GetPinnableReference(), ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateSetFrames(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorFrameVectorHandle* frames, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateSetFrames(ref state.GetPinnableReference(), frames, errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateSetFrames(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorFrameVectorHandle* frames, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateSetFrames(ref state.GetPinnableReference(), frames, ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateSetFrames(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, Span<SpriteAnimatorFrameVectorHandle> frames, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateSetFrames(ref state.GetPinnableReference(), ref frames.GetPinnableReference(), errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateSetFrames(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, Span<SpriteAnimatorFrameVectorHandle> frames, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateSetFrames(ref state.GetPinnableReference(), ref frames.GetPinnableReference(), ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateTryFindValidTransition(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorStateHandle** outputTransitionState, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateTryFindValidTransition(ref state.GetPinnableReference(), outputTransitionState, errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateTryFindValidTransition(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, SpriteAnimatorStateHandle** outputTransitionState, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateTryFindValidTransition(ref state.GetPinnableReference(), outputTransitionState, ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateTryFindValidTransition(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, ref SpriteAnimatorStateHandle* outputTransitionState, byte** errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateTryFindValidTransition(ref state.GetPinnableReference(), ref outputTransitionState, errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorStateTryFindValidTransition(this NovelRT thisApi, Span<SpriteAnimatorStateHandle> state, ref SpriteAnimatorStateHandle* outputTransitionState, ref byte* errorMesssage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStateTryFindValidTransition(ref state.GetPinnableReference(), ref outputTransitionState, ref errorMesssage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorAddFrame(this NovelRT thisApi, SpriteAnimatorFrameVectorHandle* vector, Span<SpriteAnimatorFrameHandle> frame, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorAddFrame(vector, ref frame.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorAddFrame(this NovelRT thisApi, SpriteAnimatorFrameVectorHandle* vector, Span<SpriteAnimatorFrameHandle> frame, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorAddFrame(vector, ref frame.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorAddFrame(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, SpriteAnimatorFrameHandle* frame, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorAddFrame(ref vector.GetPinnableReference(), frame, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorAddFrame(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, SpriteAnimatorFrameHandle* frame, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorAddFrame(ref vector.GetPinnableReference(), frame, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorAddFrame(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, Span<SpriteAnimatorFrameHandle> frame, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorAddFrame(ref vector.GetPinnableReference(), ref frame.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorAddFrame(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, Span<SpriteAnimatorFrameHandle> frame, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorAddFrame(ref vector.GetPinnableReference(), ref frame.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorGetFrameAtIndex(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, int index, SpriteAnimatorFrameHandle** outputFrame, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorGetFrameAtIndex(ref vector.GetPinnableReference(), index, outputFrame, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorGetFrameAtIndex(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, int index, SpriteAnimatorFrameHandle** outputFrame, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorGetFrameAtIndex(ref vector.GetPinnableReference(), index, outputFrame, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorGetFrameAtIndex(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, int index, ref SpriteAnimatorFrameHandle* outputFrame, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorGetFrameAtIndex(ref vector.GetPinnableReference(), index, ref outputFrame, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorGetFrameAtIndex(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, int index, ref SpriteAnimatorFrameHandle* outputFrame, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorGetFrameAtIndex(ref vector.GetPinnableReference(), index, ref outputFrame, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorRemoveFrameAtIndex(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, int index, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorRemoveFrameAtIndex(ref vector.GetPinnableReference(), index, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorRemoveFrameAtIndex(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, int index, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorRemoveFrameAtIndex(ref vector.GetPinnableReference(), index, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorDelete(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorDelete(ref vector.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimatorState.h")]
        public static unsafe int SpriteAnimatorFrameVectorDelete(this NovelRT thisApi, Span<SpriteAnimatorFrameVectorHandle> vector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorFrameVectorDelete(ref vector.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, NovelRunnerHandle* runner, Span<ImageRectHandle> rect, SpriteAnimatorHandle** outputAnimator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(runner, ref rect.GetPinnableReference(), outputAnimator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, NovelRunnerHandle* runner, Span<ImageRectHandle> rect, SpriteAnimatorHandle** outputAnimator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(runner, ref rect.GetPinnableReference(), outputAnimator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, NovelRunnerHandle* runner, Span<ImageRectHandle> rect, ref SpriteAnimatorHandle* outputAnimator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(runner, ref rect.GetPinnableReference(), ref outputAnimator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, NovelRunnerHandle* runner, Span<ImageRectHandle> rect, ref SpriteAnimatorHandle* outputAnimator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(runner, ref rect.GetPinnableReference(), ref outputAnimator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ImageRectHandle* rect, SpriteAnimatorHandle** outputAnimator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(ref runner.GetPinnableReference(), rect, outputAnimator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ImageRectHandle* rect, SpriteAnimatorHandle** outputAnimator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(ref runner.GetPinnableReference(), rect, outputAnimator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ImageRectHandle* rect, ref SpriteAnimatorHandle* outputAnimator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(ref runner.GetPinnableReference(), rect, ref outputAnimator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, ImageRectHandle* rect, ref SpriteAnimatorHandle* outputAnimator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(ref runner.GetPinnableReference(), rect, ref outputAnimator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, Span<ImageRectHandle> rect, SpriteAnimatorHandle** outputAnimator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(ref runner.GetPinnableReference(), ref rect.GetPinnableReference(), outputAnimator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, Span<ImageRectHandle> rect, SpriteAnimatorHandle** outputAnimator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(ref runner.GetPinnableReference(), ref rect.GetPinnableReference(), outputAnimator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, Span<ImageRectHandle> rect, ref SpriteAnimatorHandle* outputAnimator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(ref runner.GetPinnableReference(), ref rect.GetPinnableReference(), ref outputAnimator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorCreate(this NovelRT thisApi, Span<NovelRunnerHandle> runner, Span<ImageRectHandle> rect, ref SpriteAnimatorHandle* outputAnimator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorCreate(ref runner.GetPinnableReference(), ref rect.GetPinnableReference(), ref outputAnimator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorPlay(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorPlay(ref animator.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorPlay(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorPlay(ref animator.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorPause(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorPause(ref animator.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorPause(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorPause(ref animator.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorStop(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStop(ref animator.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorStop(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorStop(ref animator.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorGetCurrentPlayState(this NovelRT thisApi, SpriteAnimatorHandle* animator, Span<AnimatorPlayState> outputPlayState, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorGetCurrentPlayState(animator, ref outputPlayState.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorGetCurrentPlayState(this NovelRT thisApi, SpriteAnimatorHandle* animator, Span<AnimatorPlayState> outputPlayState, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorGetCurrentPlayState(animator, ref outputPlayState.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorGetCurrentPlayState(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, AnimatorPlayState* outputPlayState, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorGetCurrentPlayState(ref animator.GetPinnableReference(), outputPlayState, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorGetCurrentPlayState(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, AnimatorPlayState* outputPlayState, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorGetCurrentPlayState(ref animator.GetPinnableReference(), outputPlayState, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorGetCurrentPlayState(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, Span<AnimatorPlayState> outputPlayState, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorGetCurrentPlayState(ref animator.GetPinnableReference(), ref outputPlayState.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorGetCurrentPlayState(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, Span<AnimatorPlayState> outputPlayState, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorGetCurrentPlayState(ref animator.GetPinnableReference(), ref outputPlayState.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorInsertNewState(this NovelRT thisApi, SpriteAnimatorHandle* animator, Span<SpriteAnimatorStateHandle> state, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorInsertNewState(animator, ref state.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorInsertNewState(this NovelRT thisApi, SpriteAnimatorHandle* animator, Span<SpriteAnimatorStateHandle> state, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorInsertNewState(animator, ref state.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, SpriteAnimatorStateHandle* state, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorInsertNewState(ref animator.GetPinnableReference(), state, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, SpriteAnimatorStateHandle* state, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorInsertNewState(ref animator.GetPinnableReference(), state, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, Span<SpriteAnimatorStateHandle> state, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorInsertNewState(ref animator.GetPinnableReference(), ref state.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Animation/NovelRTSpriteAnimator.h")]
        public static unsafe int SpriteAnimatorInsertNewState(this NovelRT thisApi, Span<SpriteAnimatorHandle> animator, Span<SpriteAnimatorStateHandle> state, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SpriteAnimatorInsertNewState(ref animator.GetPinnableReference(), ref state.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetTransform(this NovelRT thisApi, BasicFillRectHandle* rect, Span<Transform> outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetTransform(rect, ref outputTransform.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetTransform(this NovelRT thisApi, BasicFillRectHandle* rect, Span<Transform> outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetTransform(rect, ref outputTransform.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetTransform(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Transform* outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetTransform(ref rect.GetPinnableReference(), outputTransform, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetTransform(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Transform* outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetTransform(ref rect.GetPinnableReference(), outputTransform, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetTransform(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Span<Transform> outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetTransform(ref rect.GetPinnableReference(), ref outputTransform.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetTransform(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Span<Transform> outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetTransform(ref rect.GetPinnableReference(), ref outputTransform.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetTransform(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Transform inputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetTransform(ref rect.GetPinnableReference(), inputTransform, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetTransform(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Transform inputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetTransform(ref rect.GetPinnableReference(), inputTransform, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetLayer(this NovelRT thisApi, BasicFillRectHandle* rect, Span<int> outputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetLayer(rect, ref outputLayer.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetLayer(this NovelRT thisApi, BasicFillRectHandle* rect, Span<int> outputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetLayer(rect, ref outputLayer.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetLayer(this NovelRT thisApi, Span<BasicFillRectHandle> rect, int* outputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetLayer(ref rect.GetPinnableReference(), outputLayer, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetLayer(this NovelRT thisApi, Span<BasicFillRectHandle> rect, int* outputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetLayer(ref rect.GetPinnableReference(), outputLayer, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetLayer(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Span<int> outputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetLayer(ref rect.GetPinnableReference(), ref outputLayer.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetLayer(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Span<int> outputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetLayer(ref rect.GetPinnableReference(), ref outputLayer.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetLayer(this NovelRT thisApi, Span<BasicFillRectHandle> rect, int inputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetLayer(ref rect.GetPinnableReference(), inputLayer, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetLayer(this NovelRT thisApi, Span<BasicFillRectHandle> rect, int inputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetLayer(ref rect.GetPinnableReference(), inputLayer, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetActive(this NovelRT thisApi, BasicFillRectHandle* rect, Span<int> outputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetActive(rect, ref outputBool.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetActive(this NovelRT thisApi, BasicFillRectHandle* rect, Span<int> outputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetActive(rect, ref outputBool.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetActive(this NovelRT thisApi, Span<BasicFillRectHandle> rect, int* outputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetActive(ref rect.GetPinnableReference(), outputBool, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetActive(this NovelRT thisApi, Span<BasicFillRectHandle> rect, int* outputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetActive(ref rect.GetPinnableReference(), outputBool, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetActive(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Span<int> outputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetActive(ref rect.GetPinnableReference(), ref outputBool.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetActive(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Span<int> outputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetActive(ref rect.GetPinnableReference(), ref outputBool.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetActive(this NovelRT thisApi, Span<BasicFillRectHandle> rect, int inputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetActive(ref rect.GetPinnableReference(), inputBool, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetActive(this NovelRT thisApi, Span<BasicFillRectHandle> rect, int inputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetActive(ref rect.GetPinnableReference(), inputBool, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectExecuteObjectBehaviour(this NovelRT thisApi, Span<BasicFillRectHandle> rect, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectExecuteObjectBehaviour(ref rect.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectExecuteObjectBehaviour(this NovelRT thisApi, Span<BasicFillRectHandle> rect, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectExecuteObjectBehaviour(ref rect.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetColourConfig(this NovelRT thisApi, Span<BasicFillRectHandle> rect, RGBAConfigHandle** outputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetColourConfig(ref rect.GetPinnableReference(), outputColourConfig, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetColourConfig(this NovelRT thisApi, Span<BasicFillRectHandle> rect, RGBAConfigHandle** outputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetColourConfig(ref rect.GetPinnableReference(), outputColourConfig, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetColourConfig(this NovelRT thisApi, Span<BasicFillRectHandle> rect, ref RGBAConfigHandle* outputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetColourConfig(ref rect.GetPinnableReference(), ref outputColourConfig, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetColourConfig(this NovelRT thisApi, Span<BasicFillRectHandle> rect, ref RGBAConfigHandle* outputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetColourConfig(ref rect.GetPinnableReference(), ref outputColourConfig, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetColourConfig(this NovelRT thisApi, BasicFillRectHandle* rect, Span<RGBAConfigHandle> inputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetColourConfig(rect, ref inputColourConfig.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetColourConfig(this NovelRT thisApi, BasicFillRectHandle* rect, Span<RGBAConfigHandle> inputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetColourConfig(rect, ref inputColourConfig.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetColourConfig(this NovelRT thisApi, Span<BasicFillRectHandle> rect, RGBAConfigHandle* inputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetColourConfig(ref rect.GetPinnableReference(), inputColourConfig, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetColourConfig(this NovelRT thisApi, Span<BasicFillRectHandle> rect, RGBAConfigHandle* inputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetColourConfig(ref rect.GetPinnableReference(), inputColourConfig, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetColourConfig(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Span<RGBAConfigHandle> inputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetColourConfig(ref rect.GetPinnableReference(), ref inputColourConfig.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectSetColourConfig(this NovelRT thisApi, Span<BasicFillRectHandle> rect, Span<RGBAConfigHandle> inputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectSetColourConfig(ref rect.GetPinnableReference(), ref inputColourConfig.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<BasicFillRectHandle> rect, RenderObjectHandle** outputRenderObject, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), outputRenderObject, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<BasicFillRectHandle> rect, RenderObjectHandle** outputRenderObject, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), outputRenderObject, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<BasicFillRectHandle> rect, ref RenderObjectHandle* outputRenderObject, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), ref outputRenderObject, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTBasicFillRect.h")]
        public static unsafe int BasicFillRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<BasicFillRectHandle> rect, ref RenderObjectHandle* outputRenderObject, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.BasicFillRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), ref outputRenderObject, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FRotateToAngleAroundPoint(this NovelRT thisApi, Span<GeoVector3F> vector, float angleRotationValue, GeoVector3F point, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FRotateToAngleAroundPoint(ref vector.GetPinnableReference(), angleRotationValue, point, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FRotateToAngleAroundPoint(this NovelRT thisApi, Span<GeoVector3F> vector, float angleRotationValue, GeoVector3F point, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FRotateToAngleAroundPoint(ref vector.GetPinnableReference(), angleRotationValue, point, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FAddVector(this NovelRT thisApi, GeoVector3F lhs, GeoVector3F rhs, Span<GeoVector3F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FAddVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FAddVector(this NovelRT thisApi, GeoVector3F lhs, GeoVector3F rhs, Span<GeoVector3F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FAddVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FSubtractVector(this NovelRT thisApi, GeoVector3F lhs, GeoVector3F rhs, Span<GeoVector3F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FSubtractVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FSubtractVector(this NovelRT thisApi, GeoVector3F lhs, GeoVector3F rhs, Span<GeoVector3F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FSubtractVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 36, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FMultiplyVector(this NovelRT thisApi, GeoVector3F lhs, GeoVector3F rhs, Span<GeoVector3F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FMultiplyVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 36, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FMultiplyVector(this NovelRT thisApi, GeoVector3F lhs, GeoVector3F rhs, Span<GeoVector3F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FMultiplyVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FDivideVector(this NovelRT thisApi, GeoVector3F lhs, GeoVector3F rhs, Span<GeoVector3F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FDivideVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FDivideVector(this NovelRT thisApi, GeoVector3F lhs, GeoVector3F rhs, Span<GeoVector3F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FDivideVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 38, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FAddFloat(this NovelRT thisApi, GeoVector3F lhs, float rhs, Span<GeoVector3F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FAddFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 38, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FAddFloat(this NovelRT thisApi, GeoVector3F lhs, float rhs, Span<GeoVector3F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FAddFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 39, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FSubtractFloat(this NovelRT thisApi, GeoVector3F lhs, float rhs, Span<GeoVector3F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FSubtractFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 39, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FSubtractFloat(this NovelRT thisApi, GeoVector3F lhs, float rhs, Span<GeoVector3F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FSubtractFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 40, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FMultiplyFloat(this NovelRT thisApi, GeoVector3F lhs, float rhs, Span<GeoVector3F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FMultiplyFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 40, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FMultiplyFloat(this NovelRT thisApi, GeoVector3F lhs, float rhs, Span<GeoVector3F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FMultiplyFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 41, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FDivideFloat(this NovelRT thisApi, GeoVector3F lhs, float rhs, Span<GeoVector3F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FDivideFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 41, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FDivideFloat(this NovelRT thisApi, GeoVector3F lhs, float rhs, Span<GeoVector3F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FDivideFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 42, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FAddAssignVector(this NovelRT thisApi, Span<GeoVector3F> lhs, GeoVector3F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FAddAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 42, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FAddAssignVector(this NovelRT thisApi, Span<GeoVector3F> lhs, GeoVector3F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FAddAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 43, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FSubtractAssignVector(this NovelRT thisApi, Span<GeoVector3F> lhs, GeoVector3F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FSubtractAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 43, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FSubtractAssignVector(this NovelRT thisApi, Span<GeoVector3F> lhs, GeoVector3F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FSubtractAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 44, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FMultiplyAssignVector(this NovelRT thisApi, Span<GeoVector3F> lhs, GeoVector3F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FMultiplyAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 44, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FMultiplyAssignVector(this NovelRT thisApi, Span<GeoVector3F> lhs, GeoVector3F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FMultiplyAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 45, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FDivideAssignVector(this NovelRT thisApi, Span<GeoVector3F> lhs, GeoVector3F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FDivideAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 45, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FDivideAssignVector(this NovelRT thisApi, Span<GeoVector3F> lhs, GeoVector3F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FDivideAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 46, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FAddAssignFloat(this NovelRT thisApi, Span<GeoVector3F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FAddAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 46, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FAddAssignFloat(this NovelRT thisApi, Span<GeoVector3F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FAddAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 47, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FSubtractAssignFloat(this NovelRT thisApi, Span<GeoVector3F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FSubtractAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 47, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FSubtractAssignFloat(this NovelRT thisApi, Span<GeoVector3F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FSubtractAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 48, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FMultiplyAssignFloat(this NovelRT thisApi, Span<GeoVector3F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FMultiplyAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 48, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FMultiplyAssignFloat(this NovelRT thisApi, Span<GeoVector3F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FMultiplyAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 49, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FDivideAssignFloat(this NovelRT thisApi, Span<GeoVector3F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FDivideAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 49, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector3F.h")]
        public static unsafe int GeoVector3FDivideAssignFloat(this NovelRT thisApi, Span<GeoVector3F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector3FDivideAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FRotateToAngleAroundPoint(this NovelRT thisApi, Span<GeoVector4F> vector, float angleRotationValue, GeoVector3F point, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FRotateToAngleAroundPoint(ref vector.GetPinnableReference(), angleRotationValue, point, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FRotateToAngleAroundPoint(this NovelRT thisApi, Span<GeoVector4F> vector, float angleRotationValue, GeoVector3F point, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FRotateToAngleAroundPoint(ref vector.GetPinnableReference(), angleRotationValue, point, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FAddVector(this NovelRT thisApi, GeoVector4F lhs, GeoVector4F rhs, Span<GeoVector4F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FAddVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 37, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FAddVector(this NovelRT thisApi, GeoVector4F lhs, GeoVector4F rhs, Span<GeoVector4F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FAddVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 38, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FSubtractVector(this NovelRT thisApi, GeoVector4F lhs, GeoVector4F rhs, Span<GeoVector4F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FSubtractVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 38, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FSubtractVector(this NovelRT thisApi, GeoVector4F lhs, GeoVector4F rhs, Span<GeoVector4F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FSubtractVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 39, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FMultiplyVector(this NovelRT thisApi, GeoVector4F lhs, GeoVector4F rhs, Span<GeoVector4F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FMultiplyVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 39, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FMultiplyVector(this NovelRT thisApi, GeoVector4F lhs, GeoVector4F rhs, Span<GeoVector4F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FMultiplyVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 40, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FDivideVector(this NovelRT thisApi, GeoVector4F lhs, GeoVector4F rhs, Span<GeoVector4F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FDivideVector(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 40, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FDivideVector(this NovelRT thisApi, GeoVector4F lhs, GeoVector4F rhs, Span<GeoVector4F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FDivideVector(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 41, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FAddFloat(this NovelRT thisApi, GeoVector4F lhs, float rhs, Span<GeoVector4F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FAddFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 41, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FAddFloat(this NovelRT thisApi, GeoVector4F lhs, float rhs, Span<GeoVector4F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FAddFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 42, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FSubtractFloat(this NovelRT thisApi, GeoVector4F lhs, float rhs, Span<GeoVector4F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FSubtractFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 42, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FSubtractFloat(this NovelRT thisApi, GeoVector4F lhs, float rhs, Span<GeoVector4F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FSubtractFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 43, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FMultiplyFloat(this NovelRT thisApi, GeoVector4F lhs, float rhs, Span<GeoVector4F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FMultiplyFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 43, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FMultiplyFloat(this NovelRT thisApi, GeoVector4F lhs, float rhs, Span<GeoVector4F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FMultiplyFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 44, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FDivideFloat(this NovelRT thisApi, GeoVector4F lhs, float rhs, Span<GeoVector4F> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FDivideFloat(lhs, rhs, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 44, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FDivideFloat(this NovelRT thisApi, GeoVector4F lhs, float rhs, Span<GeoVector4F> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FDivideFloat(lhs, rhs, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 45, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FAddAssignVector(this NovelRT thisApi, Span<GeoVector4F> lhs, GeoVector4F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FAddAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 45, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FAddAssignVector(this NovelRT thisApi, Span<GeoVector4F> lhs, GeoVector4F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FAddAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 46, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FSubtractAssignVector(this NovelRT thisApi, Span<GeoVector4F> lhs, GeoVector4F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FSubtractAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 46, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FSubtractAssignVector(this NovelRT thisApi, Span<GeoVector4F> lhs, GeoVector4F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FSubtractAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 47, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FMultiplyAssignVector(this NovelRT thisApi, Span<GeoVector4F> lhs, GeoVector4F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FMultiplyAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 47, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FMultiplyAssignVector(this NovelRT thisApi, Span<GeoVector4F> lhs, GeoVector4F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FMultiplyAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 48, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FDivideAssignVector(this NovelRT thisApi, Span<GeoVector4F> lhs, GeoVector4F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FDivideAssignVector(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 48, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FDivideAssignVector(this NovelRT thisApi, Span<GeoVector4F> lhs, GeoVector4F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FDivideAssignVector(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 49, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FAddAssignFloat(this NovelRT thisApi, Span<GeoVector4F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FAddAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 49, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FAddAssignFloat(this NovelRT thisApi, Span<GeoVector4F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FAddAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 50, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FSubtractAssignFloat(this NovelRT thisApi, Span<GeoVector4F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FSubtractAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 50, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FSubtractAssignFloat(this NovelRT thisApi, Span<GeoVector4F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FSubtractAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 51, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FMultiplyAssignFloat(this NovelRT thisApi, Span<GeoVector4F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FMultiplyAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 51, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FMultiplyAssignFloat(this NovelRT thisApi, Span<GeoVector4F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FMultiplyAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 52, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FDivideAssignFloat(this NovelRT thisApi, Span<GeoVector4F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FDivideAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 52, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoVector4F.h")]
        public static unsafe int GeoVector4FDivideAssignFloat(this NovelRT thisApi, Span<GeoVector4F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoVector4FDivideAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FAddMatrix(this NovelRT thisApi, GeoMatrix4x4F lhs, GeoMatrix4x4F rhs, Span<GeoMatrix4x4F> result, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FAddMatrix(lhs, rhs, ref result.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FAddMatrix(this NovelRT thisApi, GeoMatrix4x4F lhs, GeoMatrix4x4F rhs, Span<GeoMatrix4x4F> result, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FAddMatrix(lhs, rhs, ref result.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FSubtractMatrix(this NovelRT thisApi, GeoMatrix4x4F lhs, GeoMatrix4x4F rhs, Span<GeoMatrix4x4F> result, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FSubtractMatrix(lhs, rhs, ref result.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FSubtractMatrix(this NovelRT thisApi, GeoMatrix4x4F lhs, GeoMatrix4x4F rhs, Span<GeoMatrix4x4F> result, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FSubtractMatrix(lhs, rhs, ref result.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FMultiplyMatrix(this NovelRT thisApi, GeoMatrix4x4F lhs, GeoMatrix4x4F rhs, Span<GeoMatrix4x4F> result, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FMultiplyMatrix(lhs, rhs, ref result.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FMultiplyMatrix(this NovelRT thisApi, GeoMatrix4x4F lhs, GeoMatrix4x4F rhs, Span<GeoMatrix4x4F> result, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FMultiplyMatrix(lhs, rhs, ref result.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FAddAssignMatrix(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, GeoMatrix4x4F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FAddAssignMatrix(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FAddAssignMatrix(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, GeoMatrix4x4F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FAddAssignMatrix(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FSubtractAssignMatrix(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, GeoMatrix4x4F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FSubtractAssignMatrix(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FSubtractAssignMatrix(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, GeoMatrix4x4F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FSubtractAssignMatrix(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FMultiplyAssignMatrix(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, GeoMatrix4x4F rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FMultiplyAssignMatrix(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FMultiplyAssignMatrix(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, GeoMatrix4x4F rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FMultiplyAssignMatrix(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FAddFloat(this NovelRT thisApi, GeoMatrix4x4F lhs, float rhs, Span<GeoMatrix4x4F> result, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FAddFloat(lhs, rhs, ref result.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FAddFloat(this NovelRT thisApi, GeoMatrix4x4F lhs, float rhs, Span<GeoMatrix4x4F> result, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FAddFloat(lhs, rhs, ref result.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FSubtractFloat(this NovelRT thisApi, GeoMatrix4x4F lhs, float rhs, Span<GeoMatrix4x4F> result, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FSubtractFloat(lhs, rhs, ref result.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FSubtractFloat(this NovelRT thisApi, GeoMatrix4x4F lhs, float rhs, Span<GeoMatrix4x4F> result, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FSubtractFloat(lhs, rhs, ref result.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FMultiplyFloat(this NovelRT thisApi, GeoMatrix4x4F lhs, float rhs, Span<GeoMatrix4x4F> result, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FMultiplyFloat(lhs, rhs, ref result.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FMultiplyFloat(this NovelRT thisApi, GeoMatrix4x4F lhs, float rhs, Span<GeoMatrix4x4F> result, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FMultiplyFloat(lhs, rhs, ref result.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FAddAssignFloat(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FAddAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FAddAssignFloat(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FAddAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FSubtractAssignFloat(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FSubtractAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 34, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FSubtractAssignFloat(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FSubtractAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FMultiplyAssignFloat(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, float rhs, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FMultiplyAssignFloat(ref lhs.GetPinnableReference(), rhs, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 35, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTGeoMatrix4x4F.h")]
        public static unsafe int GeoMatrix4x4FMultiplyAssignFloat(this NovelRT thisApi, Span<GeoMatrix4x4F> lhs, float rhs, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.GeoMatrix4x4FMultiplyAssignFloat(ref lhs.GetPinnableReference(), rhs, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetViewMatrix(this NovelRT thisApi, CameraHandle* camera, Span<GeoMatrix4x4F> outputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetViewMatrix(camera, ref outputMatrix.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetViewMatrix(this NovelRT thisApi, CameraHandle* camera, Span<GeoMatrix4x4F> outputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetViewMatrix(camera, ref outputMatrix.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetViewMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F* outputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetViewMatrix(ref camera.GetPinnableReference(), outputMatrix, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetViewMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F* outputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetViewMatrix(ref camera.GetPinnableReference(), outputMatrix, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetViewMatrix(this NovelRT thisApi, Span<CameraHandle> camera, Span<GeoMatrix4x4F> outputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetViewMatrix(ref camera.GetPinnableReference(), ref outputMatrix.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetViewMatrix(this NovelRT thisApi, Span<CameraHandle> camera, Span<GeoMatrix4x4F> outputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetViewMatrix(ref camera.GetPinnableReference(), ref outputMatrix.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetViewMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F inputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraSetViewMatrix(ref camera.GetPinnableReference(), inputMatrix, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetViewMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F inputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraSetViewMatrix(ref camera.GetPinnableReference(), inputMatrix, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetProjectionMatrix(this NovelRT thisApi, CameraHandle* camera, Span<GeoMatrix4x4F> outputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetProjectionMatrix(camera, ref outputMatrix.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetProjectionMatrix(this NovelRT thisApi, CameraHandle* camera, Span<GeoMatrix4x4F> outputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetProjectionMatrix(camera, ref outputMatrix.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetProjectionMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F* outputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetProjectionMatrix(ref camera.GetPinnableReference(), outputMatrix, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetProjectionMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F* outputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetProjectionMatrix(ref camera.GetPinnableReference(), outputMatrix, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetProjectionMatrix(this NovelRT thisApi, Span<CameraHandle> camera, Span<GeoMatrix4x4F> outputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetProjectionMatrix(ref camera.GetPinnableReference(), ref outputMatrix.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetProjectionMatrix(this NovelRT thisApi, Span<CameraHandle> camera, Span<GeoMatrix4x4F> outputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetProjectionMatrix(ref camera.GetPinnableReference(), ref outputMatrix.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetProjectionMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F inputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraSetProjectionMatrix(ref camera.GetPinnableReference(), inputMatrix, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetProjectionMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F inputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraSetProjectionMatrix(ref camera.GetPinnableReference(), inputMatrix, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetCameraUboMatrix(this NovelRT thisApi, CameraHandle* camera, Span<GeoMatrix4x4F> outputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetCameraUboMatrix(camera, ref outputMatrix.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetCameraUboMatrix(this NovelRT thisApi, CameraHandle* camera, Span<GeoMatrix4x4F> outputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetCameraUboMatrix(camera, ref outputMatrix.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetCameraUboMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F* outputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetCameraUboMatrix(ref camera.GetPinnableReference(), outputMatrix, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetCameraUboMatrix(this NovelRT thisApi, Span<CameraHandle> camera, GeoMatrix4x4F* outputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetCameraUboMatrix(ref camera.GetPinnableReference(), outputMatrix, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetCameraUboMatrix(this NovelRT thisApi, Span<CameraHandle> camera, Span<GeoMatrix4x4F> outputMatrix, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetCameraUboMatrix(ref camera.GetPinnableReference(), ref outputMatrix.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetCameraUboMatrix(this NovelRT thisApi, Span<CameraHandle> camera, Span<GeoMatrix4x4F> outputMatrix, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetCameraUboMatrix(ref camera.GetPinnableReference(), ref outputMatrix.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetFrameState(this NovelRT thisApi, CameraHandle* camera, Span<CameraFrameState> outputFrameState, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetFrameState(camera, ref outputFrameState.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetFrameState(this NovelRT thisApi, CameraHandle* camera, Span<CameraFrameState> outputFrameState, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetFrameState(camera, ref outputFrameState.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetFrameState(this NovelRT thisApi, Span<CameraHandle> camera, CameraFrameState* outputFrameState, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetFrameState(ref camera.GetPinnableReference(), outputFrameState, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetFrameState(this NovelRT thisApi, Span<CameraHandle> camera, CameraFrameState* outputFrameState, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetFrameState(ref camera.GetPinnableReference(), outputFrameState, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetFrameState(this NovelRT thisApi, Span<CameraHandle> camera, Span<CameraFrameState> outputFrameState, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetFrameState(ref camera.GetPinnableReference(), ref outputFrameState.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraGetFrameState(this NovelRT thisApi, Span<CameraHandle> camera, Span<CameraFrameState> outputFrameState, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraGetFrameState(ref camera.GetPinnableReference(), ref outputFrameState.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetForceResizeCallback<T0>(this NovelRT thisApi, CameraHandle* camera, Span<T0> callback, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CameraSetForceResizeCallback(camera, ref callback.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetForceResizeCallback<T0>(this NovelRT thisApi, CameraHandle* camera, Span<T0> callback, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CameraSetForceResizeCallback(camera, ref callback.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetForceResizeCallback(this NovelRT thisApi, Span<CameraHandle> camera, void* callback, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraSetForceResizeCallback(ref camera.GetPinnableReference(), callback, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetForceResizeCallback(this NovelRT thisApi, Span<CameraHandle> camera, void* callback, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraSetForceResizeCallback(ref camera.GetPinnableReference(), callback, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetForceResizeCallback<T0>(this NovelRT thisApi, Span<CameraHandle> camera, Span<T0> callback, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CameraSetForceResizeCallback(ref camera.GetPinnableReference(), ref callback.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraSetForceResizeCallback<T0>(this NovelRT thisApi, Span<CameraHandle> camera, Span<T0> callback, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CameraSetForceResizeCallback(ref camera.GetPinnableReference(), ref callback.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraDestroy(this NovelRT thisApi, Span<CameraHandle> camera, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraDestroy(ref camera.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTCamera.h")]
        public static unsafe int CameraDestroy(this NovelRT thisApi, Span<CameraHandle> camera, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.CameraDestroy(ref camera.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetLoadFontAsTextureSet(this NovelRT thisApi, FontSetHandle* fontSet, Span<byte> file, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetLoadFontAsTextureSet(fontSet, ref file.GetPinnableReference(), fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetLoadFontAsTextureSet(this NovelRT thisApi, FontSetHandle* fontSet, Span<byte> file, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetLoadFontAsTextureSet(fontSet, ref file.GetPinnableReference(), fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetLoadFontAsTextureSet(this NovelRT thisApi, Span<FontSetHandle> fontSet, byte* file, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetLoadFontAsTextureSet(ref fontSet.GetPinnableReference(), file, fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetLoadFontAsTextureSet(this NovelRT thisApi, Span<FontSetHandle> fontSet, byte* file, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetLoadFontAsTextureSet(ref fontSet.GetPinnableReference(), file, fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetLoadFontAsTextureSet(this NovelRT thisApi, Span<FontSetHandle> fontSet, Span<byte> file, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetLoadFontAsTextureSet(ref fontSet.GetPinnableReference(), ref file.GetPinnableReference(), fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetLoadFontAsTextureSet(this NovelRT thisApi, Span<FontSetHandle> fontSet, Span<byte> file, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetLoadFontAsTextureSet(ref fontSet.GetPinnableReference(), ref file.GetPinnableReference(), fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetLoadFontAsTextureSet(this NovelRT thisApi, Span<FontSetHandle> fontSet, string file, float fontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetLoadFontAsTextureSet(ref fontSet.GetPinnableReference(), file, fontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetLoadFontAsTextureSet(this NovelRT thisApi, Span<FontSetHandle> fontSet, string file, float fontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetLoadFontAsTextureSet(ref fontSet.GetPinnableReference(), file, fontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontFile(this NovelRT thisApi, Span<FontSetHandle> fontSet, byte** outputFontFile, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontFile(ref fontSet.GetPinnableReference(), outputFontFile, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontFile(this NovelRT thisApi, Span<FontSetHandle> fontSet, byte** outputFontFile, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontFile(ref fontSet.GetPinnableReference(), outputFontFile, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontFile(this NovelRT thisApi, Span<FontSetHandle> fontSet, ref byte* outputFontFile, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontFile(ref fontSet.GetPinnableReference(), ref outputFontFile, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontFile(this NovelRT thisApi, Span<FontSetHandle> fontSet, ref byte* outputFontFile, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontFile(ref fontSet.GetPinnableReference(), ref outputFontFile, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontSize(this NovelRT thisApi, FontSetHandle* fontSet, Span<float> outputFontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontSize(fontSet, ref outputFontSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontSize(this NovelRT thisApi, FontSetHandle* fontSet, Span<float> outputFontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontSize(fontSet, ref outputFontSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontSize(this NovelRT thisApi, Span<FontSetHandle> fontSet, float* outputFontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontSize(ref fontSet.GetPinnableReference(), outputFontSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontSize(this NovelRT thisApi, Span<FontSetHandle> fontSet, float* outputFontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontSize(ref fontSet.GetPinnableReference(), outputFontSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontSize(this NovelRT thisApi, Span<FontSetHandle> fontSet, Span<float> outputFontSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontSize(ref fontSet.GetPinnableReference(), ref outputFontSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTFontSet.h")]
        public static unsafe int FontSetGetFontSize(this NovelRT thisApi, Span<FontSetHandle> fontSet, Span<float> outputFontSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.FontSetGetFontSize(ref fontSet.GetPinnableReference(), ref outputFontSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTransform(this NovelRT thisApi, ImageRectHandle* rect, Span<Transform> outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTransform(rect, ref outputTransform.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTransform(this NovelRT thisApi, ImageRectHandle* rect, Span<Transform> outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTransform(rect, ref outputTransform.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTransform(this NovelRT thisApi, Span<ImageRectHandle> rect, Transform* outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTransform(ref rect.GetPinnableReference(), outputTransform, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTransform(this NovelRT thisApi, Span<ImageRectHandle> rect, Transform* outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTransform(ref rect.GetPinnableReference(), outputTransform, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTransform(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<Transform> outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTransform(ref rect.GetPinnableReference(), ref outputTransform.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 14, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTransform(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<Transform> outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTransform(ref rect.GetPinnableReference(), ref outputTransform.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetTransform(this NovelRT thisApi, Span<ImageRectHandle> rect, Transform inputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetTransform(ref rect.GetPinnableReference(), inputTransform, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetTransform(this NovelRT thisApi, Span<ImageRectHandle> rect, Transform inputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetTransform(ref rect.GetPinnableReference(), inputTransform, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetLayer(this NovelRT thisApi, ImageRectHandle* rect, Span<int> outputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetLayer(rect, ref outputLayer.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetLayer(this NovelRT thisApi, ImageRectHandle* rect, Span<int> outputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetLayer(rect, ref outputLayer.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetLayer(this NovelRT thisApi, Span<ImageRectHandle> rect, int* outputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetLayer(ref rect.GetPinnableReference(), outputLayer, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetLayer(this NovelRT thisApi, Span<ImageRectHandle> rect, int* outputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetLayer(ref rect.GetPinnableReference(), outputLayer, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetLayer(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<int> outputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetLayer(ref rect.GetPinnableReference(), ref outputLayer.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetLayer(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<int> outputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetLayer(ref rect.GetPinnableReference(), ref outputLayer.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetLayer(this NovelRT thisApi, Span<ImageRectHandle> rect, int inputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetLayer(ref rect.GetPinnableReference(), inputLayer, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetLayer(this NovelRT thisApi, Span<ImageRectHandle> rect, int inputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetLayer(ref rect.GetPinnableReference(), inputLayer, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetActive(this NovelRT thisApi, ImageRectHandle* rect, Span<int> outputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetActive(rect, ref outputBool.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetActive(this NovelRT thisApi, ImageRectHandle* rect, Span<int> outputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetActive(rect, ref outputBool.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetActive(this NovelRT thisApi, Span<ImageRectHandle> rect, int* outputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetActive(ref rect.GetPinnableReference(), outputBool, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetActive(this NovelRT thisApi, Span<ImageRectHandle> rect, int* outputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetActive(ref rect.GetPinnableReference(), outputBool, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetActive(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<int> outputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetActive(ref rect.GetPinnableReference(), ref outputBool.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetActive(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<int> outputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetActive(ref rect.GetPinnableReference(), ref outputBool.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetActive(this NovelRT thisApi, Span<ImageRectHandle> rect, int inputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetActive(ref rect.GetPinnableReference(), inputBool, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetActive(this NovelRT thisApi, Span<ImageRectHandle> rect, int inputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetActive(ref rect.GetPinnableReference(), inputBool, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectExecuteObjectBehaviour(this NovelRT thisApi, Span<ImageRectHandle> rect, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectExecuteObjectBehaviour(ref rect.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectExecuteObjectBehaviour(this NovelRT thisApi, Span<ImageRectHandle> rect, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectExecuteObjectBehaviour(ref rect.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTexture(this NovelRT thisApi, Span<ImageRectHandle> rect, TextureHandle** outputTexture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTexture(ref rect.GetPinnableReference(), outputTexture, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTexture(this NovelRT thisApi, Span<ImageRectHandle> rect, TextureHandle** outputTexture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTexture(ref rect.GetPinnableReference(), outputTexture, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTexture(this NovelRT thisApi, Span<ImageRectHandle> rect, ref TextureHandle* outputTexture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTexture(ref rect.GetPinnableReference(), ref outputTexture, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetTexture(this NovelRT thisApi, Span<ImageRectHandle> rect, ref TextureHandle* outputTexture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetTexture(ref rect.GetPinnableReference(), ref outputTexture, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetTexture(this NovelRT thisApi, ImageRectHandle* rect, Span<TextureHandle> inputTexture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetTexture(rect, ref inputTexture.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetTexture(this NovelRT thisApi, ImageRectHandle* rect, Span<TextureHandle> inputTexture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetTexture(rect, ref inputTexture.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetTexture(this NovelRT thisApi, Span<ImageRectHandle> rect, TextureHandle* inputTexture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetTexture(ref rect.GetPinnableReference(), inputTexture, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetTexture(this NovelRT thisApi, Span<ImageRectHandle> rect, TextureHandle* inputTexture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetTexture(ref rect.GetPinnableReference(), inputTexture, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetTexture(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<TextureHandle> inputTexture, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetTexture(ref rect.GetPinnableReference(), ref inputTexture.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetTexture(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<TextureHandle> inputTexture, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetTexture(ref rect.GetPinnableReference(), ref inputTexture.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetColourTint(this NovelRT thisApi, Span<ImageRectHandle> rect, RGBAConfigHandle** outputColourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetColourTint(ref rect.GetPinnableReference(), outputColourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetColourTint(this NovelRT thisApi, Span<ImageRectHandle> rect, RGBAConfigHandle** outputColourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetColourTint(ref rect.GetPinnableReference(), outputColourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetColourTint(this NovelRT thisApi, Span<ImageRectHandle> rect, ref RGBAConfigHandle* outputColourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetColourTint(ref rect.GetPinnableReference(), ref outputColourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetColourTint(this NovelRT thisApi, Span<ImageRectHandle> rect, ref RGBAConfigHandle* outputColourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetColourTint(ref rect.GetPinnableReference(), ref outputColourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetColourTint(this NovelRT thisApi, ImageRectHandle* rect, Span<RGBAConfigHandle> inputColourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetColourTint(rect, ref inputColourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetColourTint(this NovelRT thisApi, ImageRectHandle* rect, Span<RGBAConfigHandle> inputColourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetColourTint(rect, ref inputColourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetColourTint(this NovelRT thisApi, Span<ImageRectHandle> rect, RGBAConfigHandle* inputColourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetColourTint(ref rect.GetPinnableReference(), inputColourTint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetColourTint(this NovelRT thisApi, Span<ImageRectHandle> rect, RGBAConfigHandle* inputColourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetColourTint(ref rect.GetPinnableReference(), inputColourTint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetColourTint(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<RGBAConfigHandle> inputColourTint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetColourTint(ref rect.GetPinnableReference(), ref inputColourTint.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectSetColourTint(this NovelRT thisApi, Span<ImageRectHandle> rect, Span<RGBAConfigHandle> inputColourTint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectSetColourTint(ref rect.GetPinnableReference(), ref inputColourTint.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<ImageRectHandle> rect, RenderObjectHandle** outputRenderObject, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), outputRenderObject, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<ImageRectHandle> rect, RenderObjectHandle** outputRenderObject, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), outputRenderObject, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<ImageRectHandle> rect, ref RenderObjectHandle* outputRenderObject, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), ref outputRenderObject, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTImageRect.h")]
        public static unsafe int ImageRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<ImageRectHandle> rect, ref RenderObjectHandle* outputRenderObject, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.ImageRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), ref outputRenderObject, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetTransform(this NovelRT thisApi, TextRectHandle* rect, Span<Transform> outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetTransform(rect, ref outputTransform.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetTransform(this NovelRT thisApi, TextRectHandle* rect, Span<Transform> outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetTransform(rect, ref outputTransform.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetTransform(this NovelRT thisApi, Span<TextRectHandle> rect, Transform* outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetTransform(ref rect.GetPinnableReference(), outputTransform, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetTransform(this NovelRT thisApi, Span<TextRectHandle> rect, Transform* outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetTransform(ref rect.GetPinnableReference(), outputTransform, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetTransform(this NovelRT thisApi, Span<TextRectHandle> rect, Span<Transform> outputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetTransform(ref rect.GetPinnableReference(), ref outputTransform.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetTransform(this NovelRT thisApi, Span<TextRectHandle> rect, Span<Transform> outputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetTransform(ref rect.GetPinnableReference(), ref outputTransform.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetTransform(this NovelRT thisApi, Span<TextRectHandle> rect, Transform inputTransform, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetTransform(ref rect.GetPinnableReference(), inputTransform, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetTransform(this NovelRT thisApi, Span<TextRectHandle> rect, Transform inputTransform, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetTransform(ref rect.GetPinnableReference(), inputTransform, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetLayer(this NovelRT thisApi, TextRectHandle* rect, Span<int> outputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetLayer(rect, ref outputLayer.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetLayer(this NovelRT thisApi, TextRectHandle* rect, Span<int> outputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetLayer(rect, ref outputLayer.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetLayer(this NovelRT thisApi, Span<TextRectHandle> rect, int* outputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetLayer(ref rect.GetPinnableReference(), outputLayer, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetLayer(this NovelRT thisApi, Span<TextRectHandle> rect, int* outputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetLayer(ref rect.GetPinnableReference(), outputLayer, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetLayer(this NovelRT thisApi, Span<TextRectHandle> rect, Span<int> outputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetLayer(ref rect.GetPinnableReference(), ref outputLayer.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetLayer(this NovelRT thisApi, Span<TextRectHandle> rect, Span<int> outputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetLayer(ref rect.GetPinnableReference(), ref outputLayer.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetLayer(this NovelRT thisApi, Span<TextRectHandle> rect, int inputLayer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetLayer(ref rect.GetPinnableReference(), inputLayer, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetLayer(this NovelRT thisApi, Span<TextRectHandle> rect, int inputLayer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetLayer(ref rect.GetPinnableReference(), inputLayer, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetActive(this NovelRT thisApi, TextRectHandle* rect, Span<int> outputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetActive(rect, ref outputBool.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetActive(this NovelRT thisApi, TextRectHandle* rect, Span<int> outputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetActive(rect, ref outputBool.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetActive(this NovelRT thisApi, Span<TextRectHandle> rect, int* outputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetActive(ref rect.GetPinnableReference(), outputBool, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetActive(this NovelRT thisApi, Span<TextRectHandle> rect, int* outputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetActive(ref rect.GetPinnableReference(), outputBool, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetActive(this NovelRT thisApi, Span<TextRectHandle> rect, Span<int> outputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetActive(ref rect.GetPinnableReference(), ref outputBool.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetActive(this NovelRT thisApi, Span<TextRectHandle> rect, Span<int> outputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetActive(ref rect.GetPinnableReference(), ref outputBool.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetActive(this NovelRT thisApi, Span<TextRectHandle> rect, int inputBool, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetActive(ref rect.GetPinnableReference(), inputBool, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetActive(this NovelRT thisApi, Span<TextRectHandle> rect, int inputBool, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetActive(ref rect.GetPinnableReference(), inputBool, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectExecuteObjectBehaviour(this NovelRT thisApi, Span<TextRectHandle> rect, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectExecuteObjectBehaviour(ref rect.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectExecuteObjectBehaviour(this NovelRT thisApi, Span<TextRectHandle> rect, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectExecuteObjectBehaviour(ref rect.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetColourConfig(this NovelRT thisApi, Span<TextRectHandle> rect, RGBAConfigHandle** outputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetColourConfig(ref rect.GetPinnableReference(), outputColourConfig, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetColourConfig(this NovelRT thisApi, Span<TextRectHandle> rect, RGBAConfigHandle** outputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetColourConfig(ref rect.GetPinnableReference(), outputColourConfig, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetColourConfig(this NovelRT thisApi, Span<TextRectHandle> rect, ref RGBAConfigHandle* outputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetColourConfig(ref rect.GetPinnableReference(), ref outputColourConfig, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetColourConfig(this NovelRT thisApi, Span<TextRectHandle> rect, ref RGBAConfigHandle* outputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetColourConfig(ref rect.GetPinnableReference(), ref outputColourConfig, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetColourConfig(this NovelRT thisApi, TextRectHandle* rect, Span<RGBAConfigHandle> inputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetColourConfig(rect, ref inputColourConfig.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetColourConfig(this NovelRT thisApi, TextRectHandle* rect, Span<RGBAConfigHandle> inputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetColourConfig(rect, ref inputColourConfig.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetColourConfig(this NovelRT thisApi, Span<TextRectHandle> rect, RGBAConfigHandle* inputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetColourConfig(ref rect.GetPinnableReference(), inputColourConfig, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetColourConfig(this NovelRT thisApi, Span<TextRectHandle> rect, RGBAConfigHandle* inputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetColourConfig(ref rect.GetPinnableReference(), inputColourConfig, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetColourConfig(this NovelRT thisApi, Span<TextRectHandle> rect, Span<RGBAConfigHandle> inputColourConfig, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetColourConfig(ref rect.GetPinnableReference(), ref inputColourConfig.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetColourConfig(this NovelRT thisApi, Span<TextRectHandle> rect, Span<RGBAConfigHandle> inputColourConfig, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetColourConfig(ref rect.GetPinnableReference(), ref inputColourConfig.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetText(this NovelRT thisApi, Span<TextRectHandle> rect, byte** outputText, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetText(ref rect.GetPinnableReference(), outputText, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetText(this NovelRT thisApi, Span<TextRectHandle> rect, byte** outputText, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetText(ref rect.GetPinnableReference(), outputText, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetText(this NovelRT thisApi, Span<TextRectHandle> rect, ref byte* outputText, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetText(ref rect.GetPinnableReference(), ref outputText, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetText(this NovelRT thisApi, Span<TextRectHandle> rect, ref byte* outputText, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetText(ref rect.GetPinnableReference(), ref outputText, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetText(this NovelRT thisApi, TextRectHandle* rect, Span<byte> inputText, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetText(rect, ref inputText.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetText(this NovelRT thisApi, TextRectHandle* rect, Span<byte> inputText, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetText(rect, ref inputText.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetText(this NovelRT thisApi, Span<TextRectHandle> rect, byte* inputText, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetText(ref rect.GetPinnableReference(), inputText, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetText(this NovelRT thisApi, Span<TextRectHandle> rect, byte* inputText, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetText(ref rect.GetPinnableReference(), inputText, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetText(this NovelRT thisApi, Span<TextRectHandle> rect, Span<byte> inputText, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetText(ref rect.GetPinnableReference(), ref inputText.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetText(this NovelRT thisApi, Span<TextRectHandle> rect, Span<byte> inputText, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetText(ref rect.GetPinnableReference(), ref inputText.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetText(this NovelRT thisApi, Span<TextRectHandle> rect, string inputText, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetText(ref rect.GetPinnableReference(), inputText, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetText(this NovelRT thisApi, Span<TextRectHandle> rect, string inputText, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetText(ref rect.GetPinnableReference(), inputText, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetFontSet(this NovelRT thisApi, Span<TextRectHandle> rect, FontSetHandle** outputFontSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetFontSet(ref rect.GetPinnableReference(), outputFontSet, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetFontSet(this NovelRT thisApi, Span<TextRectHandle> rect, FontSetHandle** outputFontSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetFontSet(ref rect.GetPinnableReference(), outputFontSet, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetFontSet(this NovelRT thisApi, Span<TextRectHandle> rect, ref FontSetHandle* outputFontSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetFontSet(ref rect.GetPinnableReference(), ref outputFontSet, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetFontSet(this NovelRT thisApi, Span<TextRectHandle> rect, ref FontSetHandle* outputFontSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetFontSet(ref rect.GetPinnableReference(), ref outputFontSet, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetFontSet(this NovelRT thisApi, TextRectHandle* rect, Span<FontSetHandle> inputFontSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetFontSet(rect, ref inputFontSet.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetFontSet(this NovelRT thisApi, TextRectHandle* rect, Span<FontSetHandle> inputFontSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetFontSet(rect, ref inputFontSet.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetFontSet(this NovelRT thisApi, Span<TextRectHandle> rect, FontSetHandle* inputFontSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetFontSet(ref rect.GetPinnableReference(), inputFontSet, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetFontSet(this NovelRT thisApi, Span<TextRectHandle> rect, FontSetHandle* inputFontSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetFontSet(ref rect.GetPinnableReference(), inputFontSet, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetFontSet(this NovelRT thisApi, Span<TextRectHandle> rect, Span<FontSetHandle> inputFontSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetFontSet(ref rect.GetPinnableReference(), ref inputFontSet.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectSetFontSet(this NovelRT thisApi, Span<TextRectHandle> rect, Span<FontSetHandle> inputFontSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectSetFontSet(ref rect.GetPinnableReference(), ref inputFontSet.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<TextRectHandle> rect, RenderObjectHandle** outputRenderObject, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), outputRenderObject, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<TextRectHandle> rect, RenderObjectHandle** outputRenderObject, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), outputRenderObject, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<TextRectHandle> rect, ref RenderObjectHandle* outputRenderObject, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), ref outputRenderObject, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTextRect.h")]
        public static unsafe int TextRectGetAsRenderObjectPtr(this NovelRT thisApi, Span<TextRectHandle> rect, ref RenderObjectHandle* outputRenderObject, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextRectGetAsRenderObjectPtr(ref rect.GetPinnableReference(), ref outputRenderObject, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureLoadPngAsTexture(this NovelRT thisApi, TextureHandle* targetTexture, Span<byte> file, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureLoadPngAsTexture(targetTexture, ref file.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureLoadPngAsTexture(this NovelRT thisApi, TextureHandle* targetTexture, Span<byte> file, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureLoadPngAsTexture(targetTexture, ref file.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureLoadPngAsTexture(this NovelRT thisApi, Span<TextureHandle> targetTexture, byte* file, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureLoadPngAsTexture(ref targetTexture.GetPinnableReference(), file, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureLoadPngAsTexture(this NovelRT thisApi, Span<TextureHandle> targetTexture, byte* file, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureLoadPngAsTexture(ref targetTexture.GetPinnableReference(), file, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureLoadPngAsTexture(this NovelRT thisApi, Span<TextureHandle> targetTexture, Span<byte> file, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureLoadPngAsTexture(ref targetTexture.GetPinnableReference(), ref file.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureLoadPngAsTexture(this NovelRT thisApi, Span<TextureHandle> targetTexture, Span<byte> file, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureLoadPngAsTexture(ref targetTexture.GetPinnableReference(), ref file.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureLoadPngAsTexture(this NovelRT thisApi, Span<TextureHandle> targetTexture, string file, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureLoadPngAsTexture(ref targetTexture.GetPinnableReference(), file, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureLoadPngAsTexture(this NovelRT thisApi, Span<TextureHandle> targetTexture, string file, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureLoadPngAsTexture(ref targetTexture.GetPinnableReference(), file, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetTextureFile(this NovelRT thisApi, Span<TextureHandle> targetTexture, byte** outputFile, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetTextureFile(ref targetTexture.GetPinnableReference(), outputFile, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetTextureFile(this NovelRT thisApi, Span<TextureHandle> targetTexture, byte** outputFile, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetTextureFile(ref targetTexture.GetPinnableReference(), outputFile, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetTextureFile(this NovelRT thisApi, Span<TextureHandle> targetTexture, ref byte* outputFile, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetTextureFile(ref targetTexture.GetPinnableReference(), ref outputFile, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetTextureFile(this NovelRT thisApi, Span<TextureHandle> targetTexture, ref byte* outputFile, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetTextureFile(ref targetTexture.GetPinnableReference(), ref outputFile, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetSize(this NovelRT thisApi, TextureHandle* targetTexture, Span<GeoVector2F> outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetSize(targetTexture, ref outputSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetSize(this NovelRT thisApi, TextureHandle* targetTexture, Span<GeoVector2F> outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetSize(targetTexture, ref outputSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetSize(this NovelRT thisApi, Span<TextureHandle> targetTexture, GeoVector2F* outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetSize(ref targetTexture.GetPinnableReference(), outputSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetSize(this NovelRT thisApi, Span<TextureHandle> targetTexture, GeoVector2F* outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetSize(ref targetTexture.GetPinnableReference(), outputSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetSize(this NovelRT thisApi, Span<TextureHandle> targetTexture, Span<GeoVector2F> outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetSize(ref targetTexture.GetPinnableReference(), ref outputSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Graphics/NovelRTTexture.h")]
        public static unsafe int TextureGetSize(this NovelRT thisApi, Span<TextureHandle> targetTexture, Span<GeoVector2F> outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.TextureGetSize(ref targetTexture.GetPinnableReference(), ref outputSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTreePoint.h")]
        public static unsafe int QuadTreePointGetPosition(this NovelRT thisApi, QuadtreePoint* point, Span<GeoVector2F> outputPosition, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreePointGetPosition(point, ref outputPosition.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTreePoint.h")]
        public static unsafe int QuadTreePointGetPosition(this NovelRT thisApi, QuadtreePoint* point, Span<GeoVector2F> outputPosition, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreePointGetPosition(point, ref outputPosition.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTreePoint.h")]
        public static unsafe int QuadTreePointGetPosition(this NovelRT thisApi, Span<QuadtreePoint> point, GeoVector2F* outputPosition, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreePointGetPosition(ref point.GetPinnableReference(), outputPosition, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTreePoint.h")]
        public static unsafe int QuadTreePointGetPosition(this NovelRT thisApi, Span<QuadtreePoint> point, GeoVector2F* outputPosition, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreePointGetPosition(ref point.GetPinnableReference(), outputPosition, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTreePoint.h")]
        public static unsafe int QuadTreePointGetPosition(this NovelRT thisApi, Span<QuadtreePoint> point, Span<GeoVector2F> outputPosition, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreePointGetPosition(ref point.GetPinnableReference(), ref outputPosition.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 15, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTreePoint.h")]
        public static unsafe int QuadTreePointGetPosition(this NovelRT thisApi, Span<QuadtreePoint> point, Span<GeoVector2F> outputPosition, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreePointGetPosition(ref point.GetPinnableReference(), ref outputPosition.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTreePoint.h")]
        public static unsafe int QuadTreePointDelete(this NovelRT thisApi, Span<QuadtreePoint> point, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreePointDelete(ref point.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTreePoint.h")]
        public static unsafe int QuadTreePointDelete(this NovelRT thisApi, Span<QuadtreePoint> point, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreePointDelete(ref point.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetParent(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputParentTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetParent(ref tree.GetPinnableReference(), outputParentTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetParent(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputParentTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetParent(ref tree.GetPinnableReference(), outputParentTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetParent(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputParentTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetParent(ref tree.GetPinnableReference(), ref outputParentTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetParent(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputParentTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetParent(ref tree.GetPinnableReference(), ref outputParentTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBounds(this NovelRT thisApi, QuadTreeHandle* tree, Span<GeoBounds> outputGeoBounds, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBounds(tree, ref outputGeoBounds.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBounds(this NovelRT thisApi, QuadTreeHandle* tree, Span<GeoBounds> outputGeoBounds, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBounds(tree, ref outputGeoBounds.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBounds(this NovelRT thisApi, Span<QuadTreeHandle> tree, GeoBounds* outputGeoBounds, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBounds(ref tree.GetPinnableReference(), outputGeoBounds, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBounds(this NovelRT thisApi, Span<QuadTreeHandle> tree, GeoBounds* outputGeoBounds, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBounds(ref tree.GetPinnableReference(), outputGeoBounds, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBounds(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<GeoBounds> outputGeoBounds, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBounds(ref tree.GetPinnableReference(), ref outputGeoBounds.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBounds(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<GeoBounds> outputGeoBounds, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBounds(ref tree.GetPinnableReference(), ref outputGeoBounds.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPoint(this NovelRT thisApi, Span<QuadTreeHandle> tree, uint index, QuadtreePoint** outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPoint(ref tree.GetPinnableReference(), index, outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPoint(this NovelRT thisApi, Span<QuadTreeHandle> tree, uint index, QuadtreePoint** outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPoint(ref tree.GetPinnableReference(), index, outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPoint(this NovelRT thisApi, Span<QuadTreeHandle> tree, uint index, ref QuadtreePoint* outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPoint(ref tree.GetPinnableReference(), index, ref outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPoint(this NovelRT thisApi, Span<QuadTreeHandle> tree, uint index, ref QuadtreePoint* outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPoint(ref tree.GetPinnableReference(), index, ref outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPointCount(this NovelRT thisApi, QuadTreeHandle* tree, Span<uint> outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPointCount(tree, ref outputSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPointCount(this NovelRT thisApi, QuadTreeHandle* tree, Span<uint> outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPointCount(tree, ref outputSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPointCount(this NovelRT thisApi, Span<QuadTreeHandle> tree, uint* outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPointCount(ref tree.GetPinnableReference(), outputSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPointCount(this NovelRT thisApi, Span<QuadTreeHandle> tree, uint* outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPointCount(ref tree.GetPinnableReference(), outputSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPointCount(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<uint> outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPointCount(ref tree.GetPinnableReference(), ref outputSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetPointCount(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<uint> outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetPointCount(ref tree.GetPinnableReference(), ref outputSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetTopLeft(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputCornerTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetTopLeft(ref tree.GetPinnableReference(), outputCornerTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetTopLeft(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputCornerTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetTopLeft(ref tree.GetPinnableReference(), outputCornerTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetTopLeft(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputCornerTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetTopLeft(ref tree.GetPinnableReference(), ref outputCornerTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetTopLeft(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputCornerTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetTopLeft(ref tree.GetPinnableReference(), ref outputCornerTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetTopRight(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputCornerTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetTopRight(ref tree.GetPinnableReference(), outputCornerTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetTopRight(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputCornerTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetTopRight(ref tree.GetPinnableReference(), outputCornerTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetTopRight(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputCornerTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetTopRight(ref tree.GetPinnableReference(), ref outputCornerTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetTopRight(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputCornerTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetTopRight(ref tree.GetPinnableReference(), ref outputCornerTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBottomLeft(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputCornerTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBottomLeft(ref tree.GetPinnableReference(), outputCornerTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBottomLeft(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputCornerTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBottomLeft(ref tree.GetPinnableReference(), outputCornerTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBottomLeft(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputCornerTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBottomLeft(ref tree.GetPinnableReference(), ref outputCornerTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBottomLeft(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputCornerTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBottomLeft(ref tree.GetPinnableReference(), ref outputCornerTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBottomRight(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputCornerTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBottomRight(ref tree.GetPinnableReference(), outputCornerTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBottomRight(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadTreeHandle** outputCornerTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBottomRight(ref tree.GetPinnableReference(), outputCornerTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBottomRight(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputCornerTree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBottomRight(ref tree.GetPinnableReference(), ref outputCornerTree, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetBottomRight(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref QuadTreeHandle* outputCornerTree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetBottomRight(ref tree.GetPinnableReference(), ref outputCornerTree, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, QuadTreeHandle* tree, QuadtreePoint* point, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(tree, point, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, QuadTreeHandle* tree, QuadtreePoint* point, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(tree, point, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, QuadTreeHandle* tree, Span<QuadtreePoint> point, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(tree, ref point.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, QuadTreeHandle* tree, Span<QuadtreePoint> point, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(tree, ref point.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, QuadTreeHandle* tree, Span<QuadtreePoint> point, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(tree, ref point.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, QuadTreeHandle* tree, Span<QuadtreePoint> point, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(tree, ref point.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadtreePoint* point, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(ref tree.GetPinnableReference(), point, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadtreePoint* point, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(ref tree.GetPinnableReference(), point, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadtreePoint* point, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(ref tree.GetPinnableReference(), point, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadtreePoint* point, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(ref tree.GetPinnableReference(), point, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<QuadtreePoint> point, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(ref tree.GetPinnableReference(), ref point.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<QuadtreePoint> point, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(ref tree.GetPinnableReference(), ref point.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<QuadtreePoint> point, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(ref tree.GetPinnableReference(), ref point.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryInsert(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<QuadtreePoint> point, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryInsert(ref tree.GetPinnableReference(), ref point.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, QuadTreeHandle* tree, QuadtreePoint* point, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(tree, point, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, QuadTreeHandle* tree, QuadtreePoint* point, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(tree, point, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, QuadTreeHandle* tree, Span<QuadtreePoint> point, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(tree, ref point.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, QuadTreeHandle* tree, Span<QuadtreePoint> point, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(tree, ref point.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, QuadTreeHandle* tree, Span<QuadtreePoint> point, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(tree, ref point.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, QuadTreeHandle* tree, Span<QuadtreePoint> point, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(tree, ref point.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadtreePoint* point, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(ref tree.GetPinnableReference(), point, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadtreePoint* point, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(ref tree.GetPinnableReference(), point, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadtreePoint* point, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(ref tree.GetPinnableReference(), point, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, Span<QuadTreeHandle> tree, QuadtreePoint* point, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(ref tree.GetPinnableReference(), point, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<QuadtreePoint> point, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(ref tree.GetPinnableReference(), ref point.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<QuadtreePoint> point, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(ref tree.GetPinnableReference(), ref point.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<QuadtreePoint> point, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(ref tree.GetPinnableReference(), ref point.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeTryRemove(this NovelRT thisApi, Span<QuadTreeHandle> tree, Span<QuadtreePoint> point, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeTryRemove(ref tree.GetPinnableReference(), ref point.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetIntersectingPoints(this NovelRT thisApi, Span<QuadTreeHandle> tree, GeoBounds bounds, StdVectorQuadTreePoint** outputResultVector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetIntersectingPoints(ref tree.GetPinnableReference(), bounds, outputResultVector, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetIntersectingPoints(this NovelRT thisApi, Span<QuadTreeHandle> tree, GeoBounds bounds, StdVectorQuadTreePoint** outputResultVector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetIntersectingPoints(ref tree.GetPinnableReference(), bounds, outputResultVector, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetIntersectingPoints(this NovelRT thisApi, Span<QuadTreeHandle> tree, GeoBounds bounds, ref StdVectorQuadTreePoint* outputResultVector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetIntersectingPoints(ref tree.GetPinnableReference(), bounds, ref outputResultVector, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 29, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeGetIntersectingPoints(this NovelRT thisApi, Span<QuadTreeHandle> tree, GeoBounds bounds, ref StdVectorQuadTreePoint* outputResultVector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeGetIntersectingPoints(ref tree.GetPinnableReference(), bounds, ref outputResultVector, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorDelete(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorDelete(ref vector.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorDelete(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorDelete(ref vector.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetSize(this NovelRT thisApi, StdVectorQuadTreePoint* vector, Span<uint> outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetSize(vector, ref outputSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetSize(this NovelRT thisApi, StdVectorQuadTreePoint* vector, Span<uint> outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetSize(vector, ref outputSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetSize(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, uint* outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetSize(ref vector.GetPinnableReference(), outputSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetSize(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, uint* outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetSize(ref vector.GetPinnableReference(), outputSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetSize(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, Span<uint> outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetSize(ref vector.GetPinnableReference(), ref outputSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetSize(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, Span<uint> outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetSize(ref vector.GetPinnableReference(), ref outputSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetPointFromIndex(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, uint index, QuadtreePoint** outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetPointFromIndex(ref vector.GetPinnableReference(), index, outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetPointFromIndex(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, uint index, QuadtreePoint** outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetPointFromIndex(ref vector.GetPinnableReference(), index, outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetPointFromIndex(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, uint index, ref QuadtreePoint* outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetPointFromIndex(ref vector.GetPinnableReference(), index, ref outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int PointVectorGetPointFromIndex(this NovelRT thisApi, Span<StdVectorQuadTreePoint> vector, uint index, ref QuadtreePoint* outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.PointVectorGetPointFromIndex(ref vector.GetPinnableReference(), index, ref outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeDelete(this NovelRT thisApi, Span<QuadTreeHandle> tree, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeDelete(ref tree.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 33, Column 11 in ext/NovelRT/include\\NovelRT.Interop/Maths/NovelRTQuadTree.h")]
        public static unsafe int QuadTreeDelete(this NovelRT thisApi, Span<QuadTreeHandle> tree, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeDelete(ref tree.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeCreate(this NovelRT thisApi, Span<QuadTreeScenePointArray> points, QuadTreeNodeHandle** outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeCreate(ref points.GetPinnableReference(), outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeCreate(this NovelRT thisApi, Span<QuadTreeScenePointArray> points, QuadTreeNodeHandle** outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeCreate(ref points.GetPinnableReference(), outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeCreate(this NovelRT thisApi, Span<QuadTreeScenePointArray> points, ref QuadTreeNodeHandle* outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeCreate(ref points.GetPinnableReference(), ref outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeCreate(this NovelRT thisApi, Span<QuadTreeScenePointArray> points, ref QuadTreeNodeHandle* outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeCreate(ref points.GetPinnableReference(), ref outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetTopLeft(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, QuadTreeScenePointHandle** outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetTopLeft(ref node.GetPinnableReference(), outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetTopLeft(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, QuadTreeScenePointHandle** outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetTopLeft(ref node.GetPinnableReference(), outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetTopLeft(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetTopLeft(ref node.GetPinnableReference(), ref outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetTopLeft(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetTopLeft(ref node.GetPinnableReference(), ref outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetTopRight(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, QuadTreeScenePointHandle** outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetTopRight(ref node.GetPinnableReference(), outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetTopRight(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, QuadTreeScenePointHandle** outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetTopRight(ref node.GetPinnableReference(), outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetTopRight(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetTopRight(ref node.GetPinnableReference(), ref outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetTopRight(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetTopRight(ref node.GetPinnableReference(), ref outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetBottomLeft(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, QuadTreeScenePointHandle** outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetBottomLeft(ref node.GetPinnableReference(), outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetBottomLeft(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, QuadTreeScenePointHandle** outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetBottomLeft(ref node.GetPinnableReference(), outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetBottomLeft(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetBottomLeft(ref node.GetPinnableReference(), ref outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetBottomLeft(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetBottomLeft(ref node.GetPinnableReference(), ref outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetBottomRight(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, QuadTreeScenePointHandle** outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetBottomRight(ref node.GetPinnableReference(), outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetBottomRight(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, QuadTreeScenePointHandle** outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetBottomRight(ref node.GetPinnableReference(), outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetBottomRight(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetBottomRight(ref node.GetPinnableReference(), ref outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeNodeGetBottomRight(this NovelRT thisApi, Span<QuadTreeNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeNodeGetBottomRight(ref node.GetPinnableReference(), ref outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, pointThree, ref pointFour.GetPinnableReference(), outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, pointThree, ref pointFour.GetPinnableReference(), outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, pointThree, ref pointFour.GetPinnableReference(), ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, pointThree, ref pointFour.GetPinnableReference(), ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, ref pointThree.GetPinnableReference(), pointFour, outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, ref pointThree.GetPinnableReference(), pointFour, outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, ref pointThree.GetPinnableReference(), pointFour, ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, ref pointThree.GetPinnableReference(), pointFour, ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, pointTwo, ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), pointThree, pointFour, outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), pointThree, pointFour, outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), pointThree, pointFour, ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), pointThree, pointFour, ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), pointThree, ref pointFour.GetPinnableReference(), outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), pointThree, ref pointFour.GetPinnableReference(), outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), pointThree, ref pointFour.GetPinnableReference(), ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), pointThree, ref pointFour.GetPinnableReference(), ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), pointFour, outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), pointFour, outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), pointFour, ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), pointFour, ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, QuadTreeScenePointHandle* pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(pointOne, ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, pointThree, pointFour, outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, pointThree, pointFour, outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, pointThree, pointFour, ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, pointThree, pointFour, ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, pointThree, ref pointFour.GetPinnableReference(), outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, pointThree, ref pointFour.GetPinnableReference(), outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, pointThree, ref pointFour.GetPinnableReference(), ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, pointThree, ref pointFour.GetPinnableReference(), ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, ref pointThree.GetPinnableReference(), pointFour, outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, ref pointThree.GetPinnableReference(), pointFour, outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, ref pointThree.GetPinnableReference(), pointFour, ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, ref pointThree.GetPinnableReference(), pointFour, ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, QuadTreeScenePointHandle* pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), pointTwo, ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), pointThree, pointFour, outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), pointThree, pointFour, outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), pointThree, pointFour, ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), pointThree, pointFour, ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), pointThree, ref pointFour.GetPinnableReference(), outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), pointThree, ref pointFour.GetPinnableReference(), outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), pointThree, ref pointFour.GetPinnableReference(), ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, QuadTreeScenePointHandle* pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), pointThree, ref pointFour.GetPinnableReference(), ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), pointFour, outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), pointFour, outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), pointFour, ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, QuadTreeScenePointHandle* pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), pointFour, ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, QuadTreeScenePointArray** outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), ref outputArray, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeNode.h")]
        public static unsafe int QuadTreeScenePointArrayCreate(this NovelRT thisApi, Span<QuadTreeScenePointHandle> pointOne, Span<QuadTreeScenePointHandle> pointTwo, Span<QuadTreeScenePointHandle> pointThree, Span<QuadTreeScenePointHandle> pointFour, ref QuadTreeScenePointArray* outputArray, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointArrayCreate(ref pointOne.GetPinnableReference(), ref pointTwo.GetPinnableReference(), ref pointThree.GetPinnableReference(), ref pointFour.GetPinnableReference(), ref outputArray, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointCreateVector(this NovelRT thisApi, GeoVector2F position, Span<SceneNodeHandle> node, QuadTreeScenePointHandle** outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointCreateVector(position, ref node.GetPinnableReference(), outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointCreateVector(this NovelRT thisApi, GeoVector2F position, Span<SceneNodeHandle> node, QuadTreeScenePointHandle** outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointCreateVector(position, ref node.GetPinnableReference(), outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointCreateVector(this NovelRT thisApi, GeoVector2F position, Span<SceneNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointCreateVector(position, ref node.GetPinnableReference(), ref outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointCreateVector(this NovelRT thisApi, GeoVector2F position, Span<SceneNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointCreateVector(position, ref node.GetPinnableReference(), ref outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointCreateFloat(this NovelRT thisApi, float x, float y, Span<SceneNodeHandle> node, QuadTreeScenePointHandle** outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointCreateFloat(x, y, ref node.GetPinnableReference(), outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointCreateFloat(this NovelRT thisApi, float x, float y, Span<SceneNodeHandle> node, QuadTreeScenePointHandle** outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointCreateFloat(x, y, ref node.GetPinnableReference(), outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointCreateFloat(this NovelRT thisApi, float x, float y, Span<SceneNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointCreateFloat(x, y, ref node.GetPinnableReference(), ref outputPoint, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointCreateFloat(this NovelRT thisApi, float x, float y, Span<SceneNodeHandle> node, ref QuadTreeScenePointHandle* outputPoint, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointCreateFloat(x, y, ref node.GetPinnableReference(), ref outputPoint, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointGetSceneNode(this NovelRT thisApi, Span<QuadTreeScenePointHandle> point, SceneNodeHandle** outputNode, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointGetSceneNode(ref point.GetPinnableReference(), outputNode, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointGetSceneNode(this NovelRT thisApi, Span<QuadTreeScenePointHandle> point, SceneNodeHandle** outputNode, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointGetSceneNode(ref point.GetPinnableReference(), outputNode, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointGetSceneNode(this NovelRT thisApi, Span<QuadTreeScenePointHandle> point, ref SceneNodeHandle* outputNode, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointGetSceneNode(ref point.GetPinnableReference(), ref outputNode, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTQuadTreeScenePoint.h")]
        public static unsafe int QuadTreeScenePointGetSceneNode(this NovelRT thisApi, Span<QuadTreeScenePointHandle> point, ref SceneNodeHandle* outputNode, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.QuadTreeScenePointGetSceneNode(ref point.GetPinnableReference(), ref outputNode, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeCreate(this NovelRT thisApi, Span<RenderObjectHandle> @object, RenderObjectNodeHandle** outputNode, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeCreate(ref @object.GetPinnableReference(), outputNode, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeCreate(this NovelRT thisApi, Span<RenderObjectHandle> @object, RenderObjectNodeHandle** outputNode, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeCreate(ref @object.GetPinnableReference(), outputNode, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeCreate(this NovelRT thisApi, Span<RenderObjectHandle> @object, ref RenderObjectNodeHandle* outputNode, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeCreate(ref @object.GetPinnableReference(), ref outputNode, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeCreate(this NovelRT thisApi, Span<RenderObjectHandle> @object, ref RenderObjectNodeHandle* outputNode, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeCreate(ref @object.GetPinnableReference(), ref outputNode, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeGetRenderObject(this NovelRT thisApi, Span<RenderObjectNodeHandle> node, RenderObjectHandle** outputObject, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeGetRenderObject(ref node.GetPinnableReference(), outputObject, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeGetRenderObject(this NovelRT thisApi, Span<RenderObjectNodeHandle> node, RenderObjectHandle** outputObject, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeGetRenderObject(ref node.GetPinnableReference(), outputObject, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeGetRenderObject(this NovelRT thisApi, Span<RenderObjectNodeHandle> node, ref RenderObjectHandle* outputObject, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeGetRenderObject(ref node.GetPinnableReference(), ref outputObject, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeGetRenderObject(this NovelRT thisApi, Span<RenderObjectNodeHandle> node, ref RenderObjectHandle* outputObject, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeGetRenderObject(ref node.GetPinnableReference(), ref outputObject, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeDelete(this NovelRT thisApi, Span<RenderObjectNodeHandle> node, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeDelete(ref node.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTRenderObjectNode.h")]
        public static unsafe int RenderObjectNodeDelete(this NovelRT thisApi, Span<RenderObjectNodeHandle> node, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.RenderObjectNodeDelete(ref node.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneGetNodes(this NovelRT thisApi, Span<SceneHandle> scene, StdSetSceneNode** outputSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneGetNodes(ref scene.GetPinnableReference(), outputSet, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneGetNodes(this NovelRT thisApi, Span<SceneHandle> scene, StdSetSceneNode** outputSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneGetNodes(ref scene.GetPinnableReference(), outputSet, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneGetNodes(this NovelRT thisApi, Span<SceneHandle> scene, ref StdSetSceneNode* outputSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneGetNodes(ref scene.GetPinnableReference(), ref outputSet, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneGetNodes(this NovelRT thisApi, Span<SceneHandle> scene, ref StdSetSceneNode* outputSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneGetNodes(ref scene.GetPinnableReference(), ref outputSet, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, SceneHandle* scene, SceneNodeHandle* nodeToInsert, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(scene, nodeToInsert, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, SceneHandle* scene, SceneNodeHandle* nodeToInsert, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(scene, nodeToInsert, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, SceneHandle* scene, Span<SceneNodeHandle> nodeToInsert, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(scene, ref nodeToInsert.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, SceneHandle* scene, Span<SceneNodeHandle> nodeToInsert, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(scene, ref nodeToInsert.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, SceneHandle* scene, Span<SceneNodeHandle> nodeToInsert, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(scene, ref nodeToInsert.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, SceneHandle* scene, Span<SceneNodeHandle> nodeToInsert, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(scene, ref nodeToInsert.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, Span<SceneHandle> scene, SceneNodeHandle* nodeToInsert, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(ref scene.GetPinnableReference(), nodeToInsert, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, Span<SceneHandle> scene, SceneNodeHandle* nodeToInsert, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(ref scene.GetPinnableReference(), nodeToInsert, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, Span<SceneHandle> scene, SceneNodeHandle* nodeToInsert, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(ref scene.GetPinnableReference(), nodeToInsert, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, Span<SceneHandle> scene, SceneNodeHandle* nodeToInsert, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(ref scene.GetPinnableReference(), nodeToInsert, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, Span<SceneHandle> scene, Span<SceneNodeHandle> nodeToInsert, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(ref scene.GetPinnableReference(), ref nodeToInsert.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, Span<SceneHandle> scene, Span<SceneNodeHandle> nodeToInsert, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(ref scene.GetPinnableReference(), ref nodeToInsert.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, Span<SceneHandle> scene, Span<SceneNodeHandle> nodeToInsert, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(ref scene.GetPinnableReference(), ref nodeToInsert.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneInsert(this NovelRT thisApi, Span<SceneHandle> scene, Span<SceneNodeHandle> nodeToInsert, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneInsert(ref scene.GetPinnableReference(), ref nodeToInsert.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, SceneHandle* scene, SceneNodeHandle* nodeToRemove, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(scene, nodeToRemove, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, SceneHandle* scene, SceneNodeHandle* nodeToRemove, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(scene, nodeToRemove, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, SceneHandle* scene, Span<SceneNodeHandle> nodeToRemove, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(scene, ref nodeToRemove.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, SceneHandle* scene, Span<SceneNodeHandle> nodeToRemove, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(scene, ref nodeToRemove.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, SceneHandle* scene, Span<SceneNodeHandle> nodeToRemove, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(scene, ref nodeToRemove.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, SceneHandle* scene, Span<SceneNodeHandle> nodeToRemove, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(scene, ref nodeToRemove.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, Span<SceneHandle> scene, SceneNodeHandle* nodeToRemove, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(ref scene.GetPinnableReference(), nodeToRemove, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, Span<SceneHandle> scene, SceneNodeHandle* nodeToRemove, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(ref scene.GetPinnableReference(), nodeToRemove, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, Span<SceneHandle> scene, SceneNodeHandle* nodeToRemove, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(ref scene.GetPinnableReference(), nodeToRemove, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, Span<SceneHandle> scene, SceneNodeHandle* nodeToRemove, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(ref scene.GetPinnableReference(), nodeToRemove, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, Span<SceneHandle> scene, Span<SceneNodeHandle> nodeToRemove, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(ref scene.GetPinnableReference(), ref nodeToRemove.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, Span<SceneHandle> scene, Span<SceneNodeHandle> nodeToRemove, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(ref scene.GetPinnableReference(), ref nodeToRemove.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, Span<SceneHandle> scene, Span<SceneNodeHandle> nodeToRemove, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(ref scene.GetPinnableReference(), ref nodeToRemove.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneRemove(this NovelRT thisApi, Span<SceneHandle> scene, Span<SceneNodeHandle> nodeToRemove, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneRemove(ref scene.GetPinnableReference(), ref nodeToRemove.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneDelete(this NovelRT thisApi, Span<SceneHandle> scene, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneDelete(ref scene.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTScene.h")]
        public static unsafe int SceneDelete(this NovelRT thisApi, Span<SceneHandle> scene, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneDelete(ref scene.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeGetChildren(this NovelRT thisApi, Span<SceneNodeHandle> node, StdSetSceneNode** outputSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeGetChildren(ref node.GetPinnableReference(), outputSet, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeGetChildren(this NovelRT thisApi, Span<SceneNodeHandle> node, StdSetSceneNode** outputSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeGetChildren(ref node.GetPinnableReference(), outputSet, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeGetChildren(this NovelRT thisApi, Span<SceneNodeHandle> node, ref StdSetSceneNode* outputSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeGetChildren(ref node.GetPinnableReference(), ref outputSet, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeGetChildren(this NovelRT thisApi, Span<SceneNodeHandle> node, ref StdSetSceneNode* outputSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeGetChildren(ref node.GetPinnableReference(), ref outputSet, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeGetParents(this NovelRT thisApi, Span<SceneNodeHandle> node, StdSetSceneNode** outputSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeGetParents(ref node.GetPinnableReference(), outputSet, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeGetParents(this NovelRT thisApi, Span<SceneNodeHandle> node, StdSetSceneNode** outputSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeGetParents(ref node.GetPinnableReference(), outputSet, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeGetParents(this NovelRT thisApi, Span<SceneNodeHandle> node, ref StdSetSceneNode* outputSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeGetParents(ref node.GetPinnableReference(), ref outputSet, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeGetParents(this NovelRT thisApi, Span<SceneNodeHandle> node, ref StdSetSceneNode* outputSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeGetParents(ref node.GetPinnableReference(), ref outputSet, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, SceneNodeHandle* node, SceneNodeHandle* nodeToInsert, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(node, nodeToInsert, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, SceneNodeHandle* node, SceneNodeHandle* nodeToInsert, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(node, nodeToInsert, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, SceneNodeHandle* node, Span<SceneNodeHandle> nodeToInsert, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(node, ref nodeToInsert.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, SceneNodeHandle* node, Span<SceneNodeHandle> nodeToInsert, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(node, ref nodeToInsert.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, SceneNodeHandle* node, Span<SceneNodeHandle> nodeToInsert, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(node, ref nodeToInsert.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, SceneNodeHandle* node, Span<SceneNodeHandle> nodeToInsert, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(node, ref nodeToInsert.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, Span<SceneNodeHandle> node, SceneNodeHandle* nodeToInsert, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(ref node.GetPinnableReference(), nodeToInsert, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, Span<SceneNodeHandle> node, SceneNodeHandle* nodeToInsert, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(ref node.GetPinnableReference(), nodeToInsert, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, Span<SceneNodeHandle> node, SceneNodeHandle* nodeToInsert, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(ref node.GetPinnableReference(), nodeToInsert, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, Span<SceneNodeHandle> node, SceneNodeHandle* nodeToInsert, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(ref node.GetPinnableReference(), nodeToInsert, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<SceneNodeHandle> nodeToInsert, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(ref node.GetPinnableReference(), ref nodeToInsert.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<SceneNodeHandle> nodeToInsert, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(ref node.GetPinnableReference(), ref nodeToInsert.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<SceneNodeHandle> nodeToInsert, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(ref node.GetPinnableReference(), ref nodeToInsert.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeInsert(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<SceneNodeHandle> nodeToInsert, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeInsert(ref node.GetPinnableReference(), ref nodeToInsert.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, SceneNodeHandle* node, SceneNodeHandle* nodeToRemove, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(node, nodeToRemove, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, SceneNodeHandle* node, SceneNodeHandle* nodeToRemove, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(node, nodeToRemove, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, SceneNodeHandle* node, Span<SceneNodeHandle> nodeToRemove, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(node, ref nodeToRemove.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, SceneNodeHandle* node, Span<SceneNodeHandle> nodeToRemove, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(node, ref nodeToRemove.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, SceneNodeHandle* node, Span<SceneNodeHandle> nodeToRemove, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(node, ref nodeToRemove.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, SceneNodeHandle* node, Span<SceneNodeHandle> nodeToRemove, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(node, ref nodeToRemove.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, Span<SceneNodeHandle> node, SceneNodeHandle* nodeToRemove, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(ref node.GetPinnableReference(), nodeToRemove, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, Span<SceneNodeHandle> node, SceneNodeHandle* nodeToRemove, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(ref node.GetPinnableReference(), nodeToRemove, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, Span<SceneNodeHandle> node, SceneNodeHandle* nodeToRemove, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(ref node.GetPinnableReference(), nodeToRemove, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, Span<SceneNodeHandle> node, SceneNodeHandle* nodeToRemove, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(ref node.GetPinnableReference(), nodeToRemove, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<SceneNodeHandle> nodeToRemove, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(ref node.GetPinnableReference(), ref nodeToRemove.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<SceneNodeHandle> nodeToRemove, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(ref node.GetPinnableReference(), ref nodeToRemove.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<SceneNodeHandle> nodeToRemove, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(ref node.GetPinnableReference(), ref nodeToRemove.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeRemove(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<SceneNodeHandle> nodeToRemove, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeRemove(ref node.GetPinnableReference(), ref nodeToRemove.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, SceneNodeHandle* firstNode, SceneNodeHandle* secondNode, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(firstNode, secondNode, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, SceneNodeHandle* firstNode, SceneNodeHandle* secondNode, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(firstNode, secondNode, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, SceneNodeHandle* firstNode, Span<SceneNodeHandle> secondNode, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(firstNode, ref secondNode.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, SceneNodeHandle* firstNode, Span<SceneNodeHandle> secondNode, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(firstNode, ref secondNode.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, SceneNodeHandle* firstNode, Span<SceneNodeHandle> secondNode, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(firstNode, ref secondNode.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, SceneNodeHandle* firstNode, Span<SceneNodeHandle> secondNode, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(firstNode, ref secondNode.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, SceneNodeHandle* secondNode, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(ref firstNode.GetPinnableReference(), secondNode, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, SceneNodeHandle* secondNode, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(ref firstNode.GetPinnableReference(), secondNode, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, SceneNodeHandle* secondNode, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(ref firstNode.GetPinnableReference(), secondNode, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, SceneNodeHandle* secondNode, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(ref firstNode.GetPinnableReference(), secondNode, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, Span<SceneNodeHandle> secondNode, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(ref firstNode.GetPinnableReference(), ref secondNode.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, Span<SceneNodeHandle> secondNode, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(ref firstNode.GetPinnableReference(), ref secondNode.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, Span<SceneNodeHandle> secondNode, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(ref firstNode.GetPinnableReference(), ref secondNode.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeIsAdjacent(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, Span<SceneNodeHandle> secondNode, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeIsAdjacent(ref firstNode.GetPinnableReference(), ref secondNode.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirst<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirst(node, ref action.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirst<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirst(node, ref action.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirst(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirst(ref node.GetPinnableReference(), action, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirst(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirst(ref node.GetPinnableReference(), action, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirst<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirst(ref node.GetPinnableReference(), ref action.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirst<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirst(ref node.GetPinnableReference(), ref action.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, BreadthFirstIterator** outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(node, ref action.GetPinnableReference(), outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, BreadthFirstIterator** outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(node, ref action.GetPinnableReference(), outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, ref BreadthFirstIterator* outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(node, ref action.GetPinnableReference(), ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, ref BreadthFirstIterator* outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(node, ref action.GetPinnableReference(), ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, BreadthFirstIterator** outputIterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(ref node.GetPinnableReference(), action, outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, BreadthFirstIterator** outputIterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(ref node.GetPinnableReference(), action, outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, ref BreadthFirstIterator* outputIterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(ref node.GetPinnableReference(), action, ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, ref BreadthFirstIterator* outputIterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(ref node.GetPinnableReference(), action, ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, BreadthFirstIterator** outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(ref node.GetPinnableReference(), ref action.GetPinnableReference(), outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, BreadthFirstIterator** outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(ref node.GetPinnableReference(), ref action.GetPinnableReference(), outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, ref BreadthFirstIterator* outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(ref node.GetPinnableReference(), ref action.GetPinnableReference(), ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseBreadthFirstWithIterator<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, ref BreadthFirstIterator* outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseBreadthFirstWithIterator(ref node.GetPinnableReference(), ref action.GetPinnableReference(), ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirst<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirst(node, ref action.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirst<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirst(node, ref action.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirst(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirst(ref node.GetPinnableReference(), action, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirst(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirst(ref node.GetPinnableReference(), action, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirst<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirst(ref node.GetPinnableReference(), ref action.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirst<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirst(ref node.GetPinnableReference(), ref action.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, DepthFirstIterator** outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(node, ref action.GetPinnableReference(), outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, DepthFirstIterator** outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(node, ref action.GetPinnableReference(), outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, ref DepthFirstIterator* outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(node, ref action.GetPinnableReference(), ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> action, ref DepthFirstIterator* outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(node, ref action.GetPinnableReference(), ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, DepthFirstIterator** outputIterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(ref node.GetPinnableReference(), action, outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, DepthFirstIterator** outputIterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(ref node.GetPinnableReference(), action, outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, ref DepthFirstIterator* outputIterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(ref node.GetPinnableReference(), action, ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator(this NovelRT thisApi, Span<SceneNodeHandle> node, void* action, ref DepthFirstIterator* outputIterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(ref node.GetPinnableReference(), action, ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, DepthFirstIterator** outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(ref node.GetPinnableReference(), ref action.GetPinnableReference(), outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, DepthFirstIterator** outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(ref node.GetPinnableReference(), ref action.GetPinnableReference(), outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, ref DepthFirstIterator* outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(ref node.GetPinnableReference(), ref action.GetPinnableReference(), ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeTraverseDepthFirstWithIterator<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> action, ref DepthFirstIterator* outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeTraverseDepthFirstWithIterator(ref node.GetPinnableReference(), ref action.GetPinnableReference(), ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, SceneNodeHandle* firstNode, SceneNodeHandle* secondNode, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(firstNode, secondNode, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, SceneNodeHandle* firstNode, SceneNodeHandle* secondNode, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(firstNode, secondNode, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, SceneNodeHandle* firstNode, Span<SceneNodeHandle> secondNode, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(firstNode, ref secondNode.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, SceneNodeHandle* firstNode, Span<SceneNodeHandle> secondNode, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(firstNode, ref secondNode.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, SceneNodeHandle* firstNode, Span<SceneNodeHandle> secondNode, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(firstNode, ref secondNode.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, SceneNodeHandle* firstNode, Span<SceneNodeHandle> secondNode, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(firstNode, ref secondNode.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, SceneNodeHandle* secondNode, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(ref firstNode.GetPinnableReference(), secondNode, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, SceneNodeHandle* secondNode, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(ref firstNode.GetPinnableReference(), secondNode, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, SceneNodeHandle* secondNode, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(ref firstNode.GetPinnableReference(), secondNode, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, SceneNodeHandle* secondNode, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(ref firstNode.GetPinnableReference(), secondNode, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, Span<SceneNodeHandle> secondNode, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(ref firstNode.GetPinnableReference(), ref secondNode.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, Span<SceneNodeHandle> secondNode, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(ref firstNode.GetPinnableReference(), ref secondNode.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, Span<SceneNodeHandle> secondNode, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(ref firstNode.GetPinnableReference(), ref secondNode.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeCanReach(this NovelRT thisApi, Span<SceneNodeHandle> firstNode, Span<SceneNodeHandle> secondNode, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeCanReach(ref firstNode.GetPinnableReference(), ref secondNode.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeDelete(this NovelRT thisApi, Span<SceneNodeHandle> node, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDelete(ref node.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeDelete(this NovelRT thisApi, Span<SceneNodeHandle> node, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDelete(ref node.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetDelete(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetDelete(ref nodeSet.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetDelete(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetDelete(ref nodeSet.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSize(this NovelRT thisApi, StdSetSceneNode* nodeSet, Span<uint> outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSize(nodeSet, ref outputSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSize(this NovelRT thisApi, StdSetSceneNode* nodeSet, Span<uint> outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSize(nodeSet, ref outputSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSize(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, uint* outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSize(ref nodeSet.GetPinnableReference(), outputSize, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSize(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, uint* outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSize(ref nodeSet.GetPinnableReference(), outputSize, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSize(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, Span<uint> outputSize, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSize(ref nodeSet.GetPinnableReference(), ref outputSize.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 31, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSize(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, Span<uint> outputSize, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSize(ref nodeSet.GetPinnableReference(), ref outputSize.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSceneNodeFromIndex(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, uint index, SceneNodeHandle** outputSceneNode, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSceneNodeFromIndex(ref nodeSet.GetPinnableReference(), index, outputSceneNode, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSceneNodeFromIndex(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, uint index, SceneNodeHandle** outputSceneNode, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSceneNodeFromIndex(ref nodeSet.GetPinnableReference(), index, outputSceneNode, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSceneNodeFromIndex(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, uint index, ref SceneNodeHandle* outputSceneNode, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSceneNodeFromIndex(ref nodeSet.GetPinnableReference(), index, ref outputSceneNode, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 32, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNode.h")]
        public static unsafe int SceneNodeSetGetSceneNodeFromIndex(this NovelRT thisApi, Span<StdSetSceneNode> nodeSet, uint index, ref SceneNodeHandle* outputSceneNode, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeSetGetSceneNodeFromIndex(ref nodeSet.GetPinnableReference(), index, ref outputSceneNode, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> func, BreadthFirstIterator** outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(node, ref func.GetPinnableReference(), outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> func, BreadthFirstIterator** outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(node, ref func.GetPinnableReference(), outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> func, ref BreadthFirstIterator* outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(node, ref func.GetPinnableReference(), ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> func, ref BreadthFirstIterator* outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(node, ref func.GetPinnableReference(), ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate(this NovelRT thisApi, Span<SceneNodeHandle> node, void* func, BreadthFirstIterator** outputIterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(ref node.GetPinnableReference(), func, outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate(this NovelRT thisApi, Span<SceneNodeHandle> node, void* func, BreadthFirstIterator** outputIterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(ref node.GetPinnableReference(), func, outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate(this NovelRT thisApi, Span<SceneNodeHandle> node, void* func, ref BreadthFirstIterator* outputIterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(ref node.GetPinnableReference(), func, ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate(this NovelRT thisApi, Span<SceneNodeHandle> node, void* func, ref BreadthFirstIterator* outputIterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(ref node.GetPinnableReference(), func, ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> func, BreadthFirstIterator** outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(ref node.GetPinnableReference(), ref func.GetPinnableReference(), outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> func, BreadthFirstIterator** outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(ref node.GetPinnableReference(), ref func.GetPinnableReference(), outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> func, ref BreadthFirstIterator* outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(ref node.GetPinnableReference(), ref func.GetPinnableReference(), ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorCreate<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> func, ref BreadthFirstIterator* outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorCreate(ref node.GetPinnableReference(), ref func.GetPinnableReference(), ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIncrement(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIncrement(ref iterator.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIncrement(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIncrement(ref iterator.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorPostFixIncrement(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorPostFixIncrement(ref iterator.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorPostFixIncrement(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorPostFixIncrement(ref iterator.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEnd(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEnd(iterator, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEnd(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEnd(iterator, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEnd(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEnd(ref iterator.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEnd(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEnd(ref iterator.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEnd(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEnd(ref iterator.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEnd(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEnd(ref iterator.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorRunFunction(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorRunFunction(iterator, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorRunFunction(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorRunFunction(iterator, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorRunFunction(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorRunFunction(ref iterator.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorRunFunction(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorRunFunction(ref iterator.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorRunFunction(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorRunFunction(ref iterator.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorRunFunction(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorRunFunction(ref iterator.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, BreadthFirstIterator* other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(iterator, other, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, BreadthFirstIterator* other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(iterator, other, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<BreadthFirstIterator> other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(iterator, ref other.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<BreadthFirstIterator> other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(iterator, ref other.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<BreadthFirstIterator> other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(iterator, ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<BreadthFirstIterator> other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(iterator, ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, BreadthFirstIterator* other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), other, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, BreadthFirstIterator* other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), other, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, BreadthFirstIterator* other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), other, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, BreadthFirstIterator* other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), other, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<BreadthFirstIterator> other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<BreadthFirstIterator> other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<BreadthFirstIterator> other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<BreadthFirstIterator> other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, BreadthFirstIterator* other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(iterator, other, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, BreadthFirstIterator* other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(iterator, other, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<BreadthFirstIterator> other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(iterator, ref other.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<BreadthFirstIterator> other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(iterator, ref other.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<BreadthFirstIterator> other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(iterator, ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, BreadthFirstIterator* iterator, Span<BreadthFirstIterator> other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(iterator, ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, BreadthFirstIterator* other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), other, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, BreadthFirstIterator* other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), other, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, BreadthFirstIterator* other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), other, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, BreadthFirstIterator* other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), other, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<BreadthFirstIterator> other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<BreadthFirstIterator> other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<BreadthFirstIterator> other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeBreadthFirstIterator.h")]
        public static unsafe int SceneNodeBreadthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<BreadthFirstIterator> iterator, Span<BreadthFirstIterator> other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeBreadthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> func, DepthFirstIterator** outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(node, ref func.GetPinnableReference(), outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> func, DepthFirstIterator** outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(node, ref func.GetPinnableReference(), outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> func, ref DepthFirstIterator* outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(node, ref func.GetPinnableReference(), ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate<T0>(this NovelRT thisApi, SceneNodeHandle* node, Span<T0> func, ref DepthFirstIterator* outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(node, ref func.GetPinnableReference(), ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate(this NovelRT thisApi, Span<SceneNodeHandle> node, void* func, DepthFirstIterator** outputIterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(ref node.GetPinnableReference(), func, outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate(this NovelRT thisApi, Span<SceneNodeHandle> node, void* func, DepthFirstIterator** outputIterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(ref node.GetPinnableReference(), func, outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate(this NovelRT thisApi, Span<SceneNodeHandle> node, void* func, ref DepthFirstIterator* outputIterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(ref node.GetPinnableReference(), func, ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate(this NovelRT thisApi, Span<SceneNodeHandle> node, void* func, ref DepthFirstIterator* outputIterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(ref node.GetPinnableReference(), func, ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> func, DepthFirstIterator** outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(ref node.GetPinnableReference(), ref func.GetPinnableReference(), outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> func, DepthFirstIterator** outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(ref node.GetPinnableReference(), ref func.GetPinnableReference(), outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> func, ref DepthFirstIterator* outputIterator, byte** errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(ref node.GetPinnableReference(), ref func.GetPinnableReference(), ref outputIterator, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorCreate<T0>(this NovelRT thisApi, Span<SceneNodeHandle> node, Span<T0> func, ref DepthFirstIterator* outputIterator, ref byte* errorMessage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorCreate(ref node.GetPinnableReference(), ref func.GetPinnableReference(), ref outputIterator, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIncrement(this NovelRT thisApi, Span<DepthFirstIterator> iterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIncrement(ref iterator.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIncrement(this NovelRT thisApi, Span<DepthFirstIterator> iterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIncrement(ref iterator.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorPostFixIncrement(this NovelRT thisApi, Span<DepthFirstIterator> iterator, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorPostFixIncrement(ref iterator.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorPostFixIncrement(this NovelRT thisApi, Span<DepthFirstIterator> iterator, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorPostFixIncrement(ref iterator.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEnd(this NovelRT thisApi, DepthFirstIterator* iterator, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEnd(iterator, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEnd(this NovelRT thisApi, DepthFirstIterator* iterator, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEnd(iterator, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEnd(this NovelRT thisApi, Span<DepthFirstIterator> iterator, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEnd(ref iterator.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEnd(this NovelRT thisApi, Span<DepthFirstIterator> iterator, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEnd(ref iterator.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEnd(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEnd(ref iterator.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEnd(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEnd(ref iterator.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorRunFunction(this NovelRT thisApi, DepthFirstIterator* iterator, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorRunFunction(iterator, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorRunFunction(this NovelRT thisApi, DepthFirstIterator* iterator, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorRunFunction(iterator, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorRunFunction(this NovelRT thisApi, Span<DepthFirstIterator> iterator, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorRunFunction(ref iterator.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorRunFunction(this NovelRT thisApi, Span<DepthFirstIterator> iterator, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorRunFunction(ref iterator.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorRunFunction(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorRunFunction(ref iterator.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorRunFunction(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorRunFunction(ref iterator.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, DepthFirstIterator* iterator, DepthFirstIterator* other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(iterator, other, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, DepthFirstIterator* iterator, DepthFirstIterator* other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(iterator, other, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, DepthFirstIterator* iterator, Span<DepthFirstIterator> other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(iterator, ref other.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, DepthFirstIterator* iterator, Span<DepthFirstIterator> other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(iterator, ref other.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, DepthFirstIterator* iterator, Span<DepthFirstIterator> other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(iterator, ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, DepthFirstIterator* iterator, Span<DepthFirstIterator> other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(iterator, ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, DepthFirstIterator* other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), other, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, DepthFirstIterator* other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), other, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, DepthFirstIterator* other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), other, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, DepthFirstIterator* other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), other, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<DepthFirstIterator> other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<DepthFirstIterator> other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<DepthFirstIterator> other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<DepthFirstIterator> other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, DepthFirstIterator* iterator, DepthFirstIterator* other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(iterator, other, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, DepthFirstIterator* iterator, DepthFirstIterator* other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(iterator, other, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, DepthFirstIterator* iterator, Span<DepthFirstIterator> other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(iterator, ref other.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, DepthFirstIterator* iterator, Span<DepthFirstIterator> other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(iterator, ref other.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, DepthFirstIterator* iterator, Span<DepthFirstIterator> other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(iterator, ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, DepthFirstIterator* iterator, Span<DepthFirstIterator> other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(iterator, ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, DepthFirstIterator* other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), other, outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, DepthFirstIterator* other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), other, outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, DepthFirstIterator* other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), other, ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, DepthFirstIterator* other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), other, ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<DepthFirstIterator> other, int* outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), outputResult, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<DepthFirstIterator> other, int* outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), outputResult, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<DepthFirstIterator> other, Span<int> outputResult, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/SceneGraph/NovelRTSceneNodeDepthFirstIterator.h")]
        public static unsafe int SceneNodeDepthFirstIteratorIsNotEqual(this NovelRT thisApi, Span<DepthFirstIterator> iterator, Span<DepthFirstIterator> other, Span<int> outputResult, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.SceneNodeDepthFirstIteratorIsNotEqual(ref iterator.GetPinnableReference(), ref other.GetPinnableReference(), ref outputResult.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTicks(this NovelRT thisApi, StepTimerHandle* timer, Span<ulong> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTicks(timer, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTicks(this NovelRT thisApi, StepTimerHandle* timer, Span<ulong> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTicks(timer, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, ulong* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTicks(ref timer.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, ulong* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTicks(ref timer.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<ulong> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTicks(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 16, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<ulong> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTicks(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTicks(this NovelRT thisApi, StepTimerHandle* timer, Span<ulong> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTicks(timer, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTicks(this NovelRT thisApi, StepTimerHandle* timer, Span<ulong> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTicks(timer, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, ulong* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTicks(ref timer.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, ulong* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTicks(ref timer.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<ulong> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTicks(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 17, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<ulong> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTicks(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTime(ref timer.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTime(ref timer.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTime(ref timer.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetElapsedTime(ref timer.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTime(this NovelRT thisApi, Span<StepTimerHandle> timer, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTime(ref timer.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTime(this NovelRT thisApi, Span<StepTimerHandle> timer, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTime(ref timer.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTime(this NovelRT thisApi, Span<StepTimerHandle> timer, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTime(ref timer.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 19, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTotalTime(this NovelRT thisApi, Span<StepTimerHandle> timer, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTotalTime(ref timer.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTicks(this NovelRT thisApi, StepTimerHandle* timer, Span<ulong> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTicks(timer, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTicks(this NovelRT thisApi, StepTimerHandle* timer, Span<ulong> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTicks(timer, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, ulong* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTicks(ref timer.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, ulong* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTicks(ref timer.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<ulong> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTicks(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 20, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<ulong> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTicks(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetTargetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, ulong input, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetTargetElapsedTicks(ref timer.GetPinnableReference(), input, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 21, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetTargetElapsedTicks(this NovelRT thisApi, Span<StepTimerHandle> timer, ulong input, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetTargetElapsedTicks(ref timer.GetPinnableReference(), input, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, TimestampHandle** output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTime(ref timer.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, TimestampHandle** output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTime(ref timer.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, ref TimestampHandle* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTime(ref timer.GetPinnableReference(), ref output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 22, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetTargetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, ref TimestampHandle* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetTargetElapsedTime(ref timer.GetPinnableReference(), ref output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetTargetElapsedTime(this NovelRT thisApi, StepTimerHandle* timer, Span<TimestampHandle> target, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetTargetElapsedTime(timer, ref target.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetTargetElapsedTime(this NovelRT thisApi, StepTimerHandle* timer, Span<TimestampHandle> target, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetTargetElapsedTime(timer, ref target.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetTargetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, TimestampHandle* target, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetTargetElapsedTime(ref timer.GetPinnableReference(), target, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetTargetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, TimestampHandle* target, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetTargetElapsedTime(ref timer.GetPinnableReference(), target, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetTargetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<TimestampHandle> target, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetTargetElapsedTime(ref timer.GetPinnableReference(), ref target.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 23, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetTargetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<TimestampHandle> target, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetTargetElapsedTime(ref timer.GetPinnableReference(), ref target.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFrameCount(this NovelRT thisApi, StepTimerHandle* timer, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFrameCount(timer, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFrameCount(this NovelRT thisApi, StepTimerHandle* timer, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFrameCount(timer, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFrameCount(this NovelRT thisApi, Span<StepTimerHandle> timer, uint* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFrameCount(ref timer.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFrameCount(this NovelRT thisApi, Span<StepTimerHandle> timer, uint* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFrameCount(ref timer.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFrameCount(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFrameCount(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 24, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFrameCount(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFrameCount(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFramesPerSecond(this NovelRT thisApi, StepTimerHandle* timer, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFramesPerSecond(timer, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFramesPerSecond(this NovelRT thisApi, StepTimerHandle* timer, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFramesPerSecond(timer, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFramesPerSecond(this NovelRT thisApi, Span<StepTimerHandle> timer, uint* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFramesPerSecond(ref timer.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFramesPerSecond(this NovelRT thisApi, Span<StepTimerHandle> timer, uint* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFramesPerSecond(ref timer.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFramesPerSecond(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<uint> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFramesPerSecond(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 25, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetFramesPerSecond(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<uint> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetFramesPerSecond(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetIsFixedTimeStep(this NovelRT thisApi, StepTimerHandle* timer, Span<int> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetIsFixedTimeStep(timer, ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetIsFixedTimeStep(this NovelRT thisApi, StepTimerHandle* timer, Span<int> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetIsFixedTimeStep(timer, ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetIsFixedTimeStep(this NovelRT thisApi, Span<StepTimerHandle> timer, int* output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetIsFixedTimeStep(ref timer.GetPinnableReference(), output, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetIsFixedTimeStep(this NovelRT thisApi, Span<StepTimerHandle> timer, int* output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetIsFixedTimeStep(ref timer.GetPinnableReference(), output, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetIsFixedTimeStep(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<int> output, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetIsFixedTimeStep(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 26, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerGetIsFixedTimeStep(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<int> output, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerGetIsFixedTimeStep(ref timer.GetPinnableReference(), ref output.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetIsFixedTimeStep(this NovelRT thisApi, Span<StepTimerHandle> timer, int input, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetIsFixedTimeStep(ref timer.GetPinnableReference(), input, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 27, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerSetIsFixedTimeStep(this NovelRT thisApi, Span<StepTimerHandle> timer, int input, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerSetIsFixedTimeStep(ref timer.GetPinnableReference(), input, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerResetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerResetElapsedTime(ref timer.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 28, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerResetElapsedTime(this NovelRT thisApi, Span<StepTimerHandle> timer, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerResetElapsedTime(ref timer.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerTick(this NovelRT thisApi, StepTimerHandle* timer, Span<UtilitiesEventWithTimestampHandle> @event, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerTick(timer, ref @event.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerTick(this NovelRT thisApi, StepTimerHandle* timer, Span<UtilitiesEventWithTimestampHandle> @event, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerTick(timer, ref @event.GetPinnableReference(), ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerTick(this NovelRT thisApi, Span<StepTimerHandle> timer, UtilitiesEventWithTimestampHandle* @event, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerTick(ref timer.GetPinnableReference(), @event, errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerTick(this NovelRT thisApi, Span<StepTimerHandle> timer, UtilitiesEventWithTimestampHandle* @event, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerTick(ref timer.GetPinnableReference(), @event, ref errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerTick(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<UtilitiesEventWithTimestampHandle> @event, byte** errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerTick(ref timer.GetPinnableReference(), ref @event.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 30, Column 9 in ext/NovelRT/include\\NovelRT.Interop/Timing/NovelRTStepTimer.h")]
        public static unsafe int StepTimerTick(this NovelRT thisApi, Span<StepTimerHandle> timer, Span<UtilitiesEventWithTimestampHandle> @event, ref byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.StepTimerTick(ref timer.GetPinnableReference(), ref @event.GetPinnableReference(), ref errorMessage);
        }

    }
}

