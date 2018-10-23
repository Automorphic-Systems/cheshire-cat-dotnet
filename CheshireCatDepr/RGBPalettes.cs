using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UDPClient
{
    // Somewhat experimental - each palette contains 48 bytes of color data
    public unsafe struct URGBPalette
    {
        public const short RGB_SIZE = 3;
        public const short PALETTE_SIZE = 16;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public Byte[] Colors;

    }


    //public struct RGBPalette
    //{
    //    public RGBPalette(Byte[][] colors)
    //    {
    //        this.Colors = colors;
    //    }

    //    public Byte[][] Colors { get; }
    //}

    public class RGBPalettes
    {
        public readonly URGBPalette ULAVA = new URGBPalette() { Colors = RGBColors.Black };
        public void test()
        {
            System.Buffer.BlockCopy(RGBColors.Black, 0, ULAVA.Colors, 0, 3);
            System.Buffer.BlockCopy(RGBColors.Black, 0, ULAVA.Colors, 0, 3);
        }

        public static readonly Byte[][] LAVA = new Byte[][]{
                                        RGBColors.Black,
                                        RGBColors.Maroon,
                                        RGBColors.Black,
                                        RGBColors.Maroon,
                                        RGBColors.DarkRed,
                                        RGBColors.Maroon,
                                        RGBColors.DarkRed,
                                        RGBColors.DarkRed,
                                        RGBColors.DarkRed,
                                        RGBColors.Red,
                                        RGBColors.Orange,
                                        RGBColors.White,
                                        RGBColors.Orange,
                                        RGBColors.Red,
                                        RGBColors.DarkRed,
                                        RGBColors.Gold
        };

        public static readonly Byte[][] OCEAN = new Byte[][]{
                                        RGBColors.MidnightBlue,
                                        RGBColors.DarkBlue,
                                        RGBColors.MidnightBlue,
                                        RGBColors.Navy,
                                        RGBColors.DarkBlue,
                                        RGBColors.MediumBlue,
                                        RGBColors.SeaGreen,
                                        RGBColors.Teal,
                                        RGBColors.CadetBlue,
                                        RGBColors.Blue,
                                        RGBColors.DarkCyan,
                                        RGBColors.CornflowerBlue,
                                        RGBColors.Aquamarine,
                                        RGBColors.SeaGreen,
                                        RGBColors.Aqua,
                                        RGBColors.LightSkyBlue
        };

    }
}
