using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPClient
{
    /// <summary>
    /// Helper methods for diagnostics, etc. 
    /// </summary>
    public class Helpers
    {

        public static readonly Byte[] END = { 0x01, 0x00, 0x01 };   // clear
        public static readonly Byte[] START = { 0x01, 0x01, 0x00 }; // reset

        public static void WriteLEDBenchmarks(int frameSize, int sequenceLength, int iterations, int delay, TimeSpan elapsedTime)
        {
            long frameWrites = sequenceLength * iterations;
            long totalBytes = frameWrites * 3 * (frameSize + 2);
            long writeTime = (long)elapsedTime.Milliseconds - sequenceLength * iterations * delay;
            double frameRate = frameWrites * 1000 / elapsedTime.Milliseconds;
            double pixelRate = frameRate * frameSize;
            double byteRate = frameRate * 3 * (frameSize + 2);
            double throughputPixels = pixelRate / 30;


            Console.WriteLine("========LED BENCHMARKS========");
            Console.WriteLine($"Total number of frame writes: {frameWrites}");
            Console.WriteLine($"Total number of iterations: {iterations}");
            Console.WriteLine($"Frame size: {frameSize} pixels");
            Console.WriteLine($"Bytes per frame: {3 * (frameSize + 2)} bytes");
            Console.WriteLine($"Total bytes written: {totalBytes} bytes");
            Console.WriteLine($"Pixel delay: {delay} ms");
            Console.WriteLine($"Elapsed time: {elapsedTime.Milliseconds} ms ");
            Console.WriteLine($"Estimated write time {writeTime} ms");
            Console.WriteLine($"Frame rate: {frameRate} frames/s");
            Console.WriteLine($"Pixel rate: {pixelRate} pixels/s");
            Console.WriteLine($"Byte rate: {byteRate} bytes/s");
            Console.WriteLine($"Estimated throughput: {throughputPixels} LEDs " +
                $"at 30 frames/s");
        }


        /// <summary>
        /// Returns the next color in the color space
        /// 
        /// TODO: Need to split this into multiple methods, to handle different color spaces
        /// such as HSV
        /// </summary>
        /// <param name="currcolor"></param>
        /// <returns></returns>
        public static int NextColor(int currcolor)
        {
            int toreturn = 0;

            byte r = (byte)(currcolor & 0x110000 >> 16);
            byte g = (byte)(currcolor & 0x001100 >> 8);
            byte b = (byte)(currcolor & 0x000011);

            //one color is set, increment it. 
            if (r > 0 && r < 255 && b == 0 && g == 0)
                r++;
            if (g > 0 && g < 255 && r == 0 && g == 0)
                g++;
            if (b > 0 && b < 255 && r == 0 && g == 0)
                b++;

            return (r << 16) | (g << 8) | (b);
        }

    }
}
