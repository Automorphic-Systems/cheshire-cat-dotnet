using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UDPClient
{
    public class LEDEffects
    {
        private int[] _sparks;
        private int _globali;
        public readonly int PERC_SPARKS = 100;
        public readonly int NUM_SPARKS = 255;
        private Random _rnd;

        public LEDEffects()
        {
            this._rnd = new Random(NUM_SPARKS);// use framesize as seed

            // initialize sparks
            _sparks = new int[NUM_SPARKS];

            for (int i = 0; i < 255; i++)
            {
                _sparks[i] = _rnd.Next(0, 255);
            }

            _globali = 0;
        }


        //Applies a single twinkle operation and returns a frame
        public Byte[] Twinkle(int frameSize, Byte[][] rgbPalette)
        {
            int bufferSize = (frameSize + 2) * 3;

            // Bytes = pixels + 2 for signaling * 3 for rgb
            Byte[] result = new byte[bufferSize];

            // Put reset to say new frame
            for (int i = 0; i < Helpers.START.Length; i++)
                result[i] = Helpers.START[i];

            // Set it all to black 
            for (int i = Helpers.START.Length; i < result.Length; i++)
                result[i] = 0;


            int cntr = 3;
            int pixel = 0;

            while  (cntr < bufferSize - 3)
            {
                if (_sparks[pixel % NUM_SPARKS] > 0)
                {
                    // set led from rgb palette
                    int gint = ((int)(_globali / 5) + pixel) % 16;

                    result[cntr] = rgbPalette[gint][0];
                    result[cntr+1] = rgbPalette[gint][1];
                    result[cntr+2] = rgbPalette[gint][2];

                    // loop through sparks
                    for (int d = 0; d < (255 - _sparks[pixel % NUM_SPARKS]); d++) //some sort of fading. 
                    {
                        if (result[cntr] > 0) result[cntr]--;
                        if (result[cntr + 1] > 0) result[cntr + 1]--;
                        if (result[cntr + 2] > 0) result[cntr + 2]--;
                    }
                }

                cntr = cntr + 3;
                pixel++;
            }

            // Put the clear to tell the thing to display frame.
            for (int i = Helpers.END.Length; i > 0; i--)
                result[result.Length - i] = Helpers.END[Helpers.END.Length - i];

            // update spark values
            for (int i = 0; i < NUM_SPARKS; i++)
            {
                if (_sparks[i] > 0)
                {
                    _sparks[i]--;

                    if (_sparks[i] < 5 || _sparks[i] > 255)
                        _sparks[i] = 0;
                }
                else
                {
                    if (_rnd.Next(0, 100) < PERC_SPARKS)
                        _sparks[i] = _rnd.Next(0, 255);
                }
            }

            _globali++;
            return result;
        }
    }
}
