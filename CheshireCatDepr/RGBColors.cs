﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPClient
{
    public class RGBColor 
    {
        Byte red;
        Byte green;
        Byte blue;
    }

    /// <summary>
    /// Shamelessly converted from FastLED's color set, which is actually W3C's standard color set.
    /// </summary>
    public class RGBColors
    {
        public static Byte[] AliceBlue = { 0xF0, 0xF8, 0xFF };
        public static Byte[] Amethyst = { 0x99, 0x66, 0xCC };
        public static Byte[] AntiqueWhite = { 0xFA, 0xEB, 0xD7 };
        public static Byte[] Aqua = { 0x00, 0xFF, 0xFF };
        public static Byte[] Aquamarine = { 0x7F, 0xFF, 0xD4 };
        public static Byte[] Azure = { 0xF0, 0xFF, 0xFF };
        public static Byte[] Beige = { 0xF5, 0xF5, 0xDC };
        public static Byte[] Bisque = { 0xFF, 0xE4, 0xC4 };
        public static Byte[] Black = { 0x00, 0x00, 0x00 };
        public static Byte[] BlanchedAlmond = { 0xFF, 0xEB, 0xCD };
        public static Byte[] Blue = { 0x00, 0x00, 0xFF };
        public static Byte[] BlueViolet = { 0x8A, 0x2B, 0xE2 };
        public static Byte[] Brown = { 0xA5, 0x2A, 0x2A };
        public static Byte[] BurlyWood = { 0xDE, 0xB8, 0x87 };
        public static Byte[] CadetBlue = { 0x5F, 0x9E, 0xA0 };
        public static Byte[] Chartreuse = { 0x7F, 0xFF, 0x00 };
        public static Byte[] Chocolate = { 0xD2, 0x69, 0x1E };
        public static Byte[] Coral = { 0xFF, 0x7F, 0x50 };
        public static Byte[] CornflowerBlue = { 0x64, 0x95, 0xED };
        public static Byte[] Cornsilk = { 0xFF, 0xF8, 0xDC };
        public static Byte[] Crimson = { 0xDC, 0x14, 0x3C };
        public static Byte[] Cyan = { 0x00, 0xFF, 0xFF };
        public static Byte[] DarkBlue = { 0x00, 0x00, 0x8B };
        public static Byte[] DarkCyan = { 0x00, 0x8B, 0x8B };
        public static Byte[] DarkGoldenrod = { 0xB8, 0x86, 0x0B };
        public static Byte[] DarkGray = { 0xA9, 0xA9, 0xA9 };
        public static Byte[] DarkGreen = { 0x00, 0x64, 0x00 };
        public static Byte[] DarkKhaki = { 0xBD, 0xB7, 0x6B };
        public static Byte[] DarkMagenta = { 0x8B, 0x00, 0x8B };
        public static Byte[] DarkOliveGreen = { 0x55, 0x6B, 0x2F };
        public static Byte[] DarkOrange = { 0xFF, 0x8C, 0x00 };
        public static Byte[] DarkOrchid = { 0x99, 0x32, 0xCC };
        public static Byte[] DarkRed = { 0x8B, 0x00, 0x00 };
        public static Byte[] DarkSalmon = { 0xE9, 0x96, 0x7A };
        public static Byte[] DarkSeaGreen = { 0x8F, 0xBC, 0x8F };
        public static Byte[] DarkSlateBlue = { 0x48, 0x3D, 0x8B };
        public static Byte[] DarkSlateGray = { 0x2F, 0x4F, 0x4F };
        public static Byte[] DarkTurquoise = { 0x00, 0xCE, 0xD1 };
        public static Byte[] DarkViolet = { 0x94, 0x00, 0xD3 };
        public static Byte[] DeepPink = { 0xFF, 0x14, 0x93 };
        public static Byte[] DeepSkyBlue = { 0x00, 0xBF, 0xFF };
        public static Byte[] DimGray = { 0x69, 0x69, 0x69 };
        public static Byte[] DodgerBlue = { 0x1E, 0x90, 0xFF };
        public static Byte[] FireBrick = { 0xB2, 0x22, 0x22 };
        public static Byte[] FloralWhite = { 0xFF, 0xFA, 0xF0 };
        public static Byte[] ForestGreen = { 0x22, 0x8B, 0x22 };
        public static Byte[] Fuchsia = { 0xFF, 0x00, 0xFF };
        public static Byte[] Gainsboro = { 0xDC, 0xDC, 0xDC };
        public static Byte[] GhostWhite = { 0xF8, 0xF8, 0xFF };
        public static Byte[] Gold = { 0xFF, 0xD7, 0x00 };
        public static Byte[] Goldenrod = { 0xDA, 0xA5, 0x20 };
        public static Byte[] Gray = { 0x80, 0x80, 0x80 };
        public static Byte[] Green = { 0x00, 0x80, 0x00 };
        public static Byte[] GreenYellow = { 0xAD, 0xFF, 0x2F };
        public static Byte[] Honeydew = { 0xF0, 0xFF, 0xF0 };
        public static Byte[] HotPink = { 0xFF, 0x69, 0xB4 };
        public static Byte[] IndianRed = { 0xCD, 0x5C, 0x5C };
        public static Byte[] Indigo = { 0x4B, 0x00, 0x82 };
        public static Byte[] Ivory = { 0xFF, 0xFF, 0xF0 };
        public static Byte[] Khaki = { 0xF0, 0xE6, 0x8C };
        public static Byte[] Lavender = { 0xE6, 0xE6, 0xFA };
        public static Byte[] LavenderBlush = { 0xFF, 0xF0, 0xF5 };
        public static Byte[] LawnGreen = { 0x7C, 0xFC, 0x00 };
        public static Byte[] LemonChiffon = { 0xFF, 0xFA, 0xCD };
        public static Byte[] LightBlue = { 0xAD, 0xD8, 0xE6 };
        public static Byte[] LightCoral = { 0xF0, 0x80, 0x80 };
        public static Byte[] LightCyan = { 0xE0, 0xFF, 0xFF };
        public static Byte[] LightGoldenrodYellow = { 0xFA, 0xFA, 0xD2 };
        public static Byte[] LightGreen = { 0x90, 0xEE, 0x90 };
        public static Byte[] LightGrey = { 0xD3, 0xD3, 0xD3 };
        public static Byte[] LightPink = { 0xFF, 0xB6, 0xC1 };
        public static Byte[] LightSalmon = { 0xFF, 0xA0, 0x7A };
        public static Byte[] LightSeaGreen = { 0x20, 0xB2, 0xAA };
        public static Byte[] LightSkyBlue = { 0x87, 0xCE, 0xFA };
        public static Byte[] LightSlateGray = { 0x77, 0x88, 0x99 };
        public static Byte[] LightSteelBlue = { 0xB0, 0xC4, 0xDE };
        public static Byte[] LightYellow = { 0xFF, 0xFF, 0xE0 };
        public static Byte[] Lime = { 0x00, 0xFF, 0x00 };
        public static Byte[] LimeGreen = { 0x32, 0xCD, 0x32 };
        public static Byte[] Linen = { 0xFA, 0xF0, 0xE6 };
        public static Byte[] Magenta = { 0xFF, 0x00, 0xFF };
        public static Byte[] Maroon = { 0x80, 0x00, 0x00 };
        public static Byte[] MediumAquamarine = { 0x66, 0xCD, 0xAA };
        public static Byte[] MediumBlue = { 0x00, 0x00, 0xCD };
        public static Byte[] MediumOrchid = { 0xBA, 0x55, 0xD3 };
        public static Byte[] MediumPurple = { 0x93, 0x70, 0xDB };
        public static Byte[] MediumSeaGreen = { 0x3C, 0xB3, 0x71 };
        public static Byte[] MediumSlateBlue = { 0x7B, 0x68, 0xEE };
        public static Byte[] MediumSpringGreen = { 0x00, 0xFA, 0x9A };
        public static Byte[] MediumTurquoise = { 0x48, 0xD1, 0xCC };
        public static Byte[] MediumVioletRed = { 0xC7, 0x15, 0x85 };
        public static Byte[] MidnightBlue = { 0x19, 0x19, 0x70 };
        public static Byte[] MintCream = { 0xF5, 0xFF, 0xFA };
        public static Byte[] MistyRose = { 0xFF, 0xE4, 0xE1 };
        public static Byte[] Moccasin = { 0xFF, 0xE4, 0xB5 };
        public static Byte[] NavajoWhite = { 0xFF, 0xDE, 0xAD };
        public static Byte[] Navy = { 0x00, 0x00, 0x80 };
        public static Byte[] OldLace = { 0xFD, 0xF5, 0xE6 };
        public static Byte[] Olive = { 0x80, 0x80, 0x00 };
        public static Byte[] OliveDrab = { 0x6B, 0x8E, 0x23 };
        public static Byte[] Orange = { 0xFF, 0xA5, 0x00 };
        public static Byte[] OrangeRed = { 0xFF, 0x45, 0x00 };
        public static Byte[] Orchid = { 0xDA, 0x70, 0xD6 };
        public static Byte[] PaleGoldenrod = { 0xEE, 0xE8, 0xAA };
        public static Byte[] PaleGreen = { 0x98, 0xFB, 0x98 };
        public static Byte[] PaleTurquoise = { 0xAF, 0xEE, 0xEE };
        public static Byte[] PaleVioletRed = { 0xDB, 0x70, 0x93 };
        public static Byte[] PapayaWhip = { 0xFF, 0xEF, 0xD5 };
        public static Byte[] PeachPuff = { 0xFF, 0xDA, 0xB9 };
        public static Byte[] Peru = { 0xCD, 0x85, 0x3F };
        public static Byte[] Pink = { 0xFF, 0xC0, 0xCB };
        public static Byte[] Plaid = { 0xCC, 0x55, 0x33 };
        public static Byte[] Plum = { 0xDD, 0xA0, 0xDD };
        public static Byte[] PowderBlue = { 0xB0, 0xE0, 0xE6 };
        public static Byte[] Purple = { 0x80, 0x00, 0x80 };
        public static Byte[] Red = { 0xFF, 0x00, 0x00 };
        public static Byte[] RosyBrown = { 0xBC, 0x8F, 0x8F };
        public static Byte[] RoyalBlue = { 0x41, 0x69, 0xE1 };
        public static Byte[] SaddleBrown = { 0x8B, 0x45, 0x13 };
        public static Byte[] Salmon = { 0xFA, 0x80, 0x72 };
        public static Byte[] SandyBrown = { 0xF4, 0xA4, 0x60 };
        public static Byte[] SeaGreen = { 0x2E, 0x8B, 0x57 };
        public static Byte[] Seashell = { 0xFF, 0xF5, 0xEE };
        public static Byte[] Sienna = { 0xA0, 0x52, 0x2D };
        public static Byte[] Silver = { 0xC0, 0xC0, 0xC0 };
        public static Byte[] SkyBlue = { 0x87, 0xCE, 0xEB };
        public static Byte[] SlateBlue = { 0x6A, 0x5A, 0xCD };
        public static Byte[] SlateGray = { 0x70, 0x80, 0x90 };
        public static Byte[] Snow = { 0xFF, 0xFA, 0xFA };
        public static Byte[] SpringGreen = { 0x00, 0xFF, 0x7F };
        public static Byte[] SteelBlue = { 0x46, 0x82, 0xB4 };
        public static Byte[] Tan = { 0xD2, 0xB4, 0x8C };
        public static Byte[] Teal = { 0x00, 0x80, 0x80 };
        public static Byte[] Thistle = { 0xD8, 0xBF, 0xD8 };
        public static Byte[] Tomato = { 0xFF, 0x63, 0x47 };
        public static Byte[] Turquoise = { 0x40, 0xE0, 0xD0 };
        public static Byte[] Violet = { 0xEE, 0x82, 0xEE };
        public static Byte[] Wheat = { 0xF5, 0xDE, 0xB3 };
        public static Byte[] White = { 0xFF, 0xFF, 0xFF };
        public static Byte[] WhiteSmoke = { 0xF5, 0xF5, 0xF5 };
        public static Byte[] Yellow = { 0xFF, 0xFF, 0x00 };
        public static Byte[] YellowGreen = { 0x9A, 0xCD, 0x32 };
    }
}
