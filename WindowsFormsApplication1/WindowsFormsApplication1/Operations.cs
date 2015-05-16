using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Section finished...
    /// </summary>
    class Operations
    {
        ///----------------------------- Image Processing Parallel and Secuential Section (All Methods) ------------------------------------------------

        ///-------------------------------------- Gray Scale filter Parallel and Secuential --------------------------------------------------------

        public static Bitmap grayScaleFilterSecuential(Bitmap bmp)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    int grayScale = (int)((bmp.GetPixel(i, x).R * .3) + (bmp.GetPixel(i, x).G * .59) + (bmp.GetPixel(i, x).B * .11)); 
                    temp.SetPixel(i, x, Color.FromArgb(grayScale, grayScale, grayScale));
                }

            }
            return temp;
        }

        public static Bitmap grayScaleInParallelProcesing(Bitmap bmp)
        {
            Bitmap temp = bmp; // work with a copy of the original.
            BitmapData bitmapData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, temp.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(temp.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * temp.Height;
            byte[] pixels = new byte[byteCount];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;


            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    int oldBlue = (int)(pixels[currentLine + x] * .11);
                    int oldGreen = (int)(pixels[currentLine + x + 1] * .59);
                    int oldRed = (int)(pixels[currentLine + x + 2] * .3);

                    int grayScale = oldRed + oldGreen + oldBlue;

                    // calculate new pixel value
                    pixels[currentLine + x] = (byte)grayScale;
                    pixels[currentLine + x + 1] = (byte)grayScale;
                    pixels[currentLine + x + 2] = (byte)grayScale;
                }
            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            temp.UnlockBits(bitmapData);

            return temp;
        }

        /// -------------------------------------- Gray Scale filter Parallel and Secuential, finish Section --------------------------------------------------------

        /// --------------------------------------------- Sepia filter Parallel and Secuential ----------------------------------------------------------------------

        public static Bitmap sepiaFilterSecuential(Bitmap bmp)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    int Red = bmp.GetPixel(i, x).R;
                    int Green = bmp.GetPixel(i, x).G;
                    int Blue = bmp.GetPixel(i, x).B;

                    int newRed = (int)Math.Min((Red * .393) + (Green * .769) + (Blue * .189), 255.0);
                    int newGreen = (int)Math.Min((Red * .349) + (Green * .686) + (Blue * .168), 255.0);
                    int newBlue = (int)Math.Min((Red * .272) + (Green * .534) + (Blue * .131), 255.0);
                    temp.SetPixel(i, x, Color.FromArgb(newRed, newGreen, newBlue));
                }

            }
            return temp;
        }

        public static Bitmap sepiaScaleInParallelProcesing(Bitmap bmp)
        {
            Bitmap temp = bmp; // work with a copy of the original.
            BitmapData bitmapData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, temp.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(temp.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * temp.Height;
            byte[] pixels = new byte[byteCount];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;


            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    int oldBlue = pixels[currentLine + x];
                    int oldGreen = pixels[currentLine + x + 1];
                    int oldRed = pixels[currentLine + x + 2];

                    // calculate new pixel value
                    pixels[currentLine + x] = (byte)Math.Min((oldRed * .272) + (oldGreen * .534) + (oldBlue * .131), 255.0);     //Blue
                    pixels[currentLine + x + 1] = (byte)Math.Min((oldRed * .349) + (oldGreen * .686) + (oldBlue * .168), 255.0); //Green
                    pixels[currentLine + x + 2] = (byte)Math.Min((oldRed * .393) + (oldGreen * .769) + (oldBlue * .189), 255.0); //Red

                    if ((pixels[currentLine + x]) > 255)
                    {
                        pixels[currentLine + x] = 255;
                    }

                    if ((pixels[currentLine + x + 1]) > 255)
                    {
                        pixels[currentLine + x + 1] = 255;
                    }
                    if ((pixels[currentLine + x + 2]) > 255)
                    {
                        pixels[currentLine + x + 2] = 255;
                    }


                }
            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            temp.UnlockBits(bitmapData);

            return temp;
        }

        /// --------------------------------------------- Sepia filter Parallel and Secuential, finish section ----------------------------------------------------------

        ///-------------------------------------- Opacity filter Parallel and Secuential --------------------------------------------------------

        public static Bitmap OpacityFilterSecuential(Bitmap bmp, double opacity)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    int rGet = bmp.GetPixel(i, x).R;
                    int gGet = bmp.GetPixel(i, x).G;
                    int bGet = bmp.GetPixel(i, x).B;
                    int aOpacityChange = (int)(bmp.GetPixel(i, x).A * opacity);
                    temp.SetPixel(i, x, Color.FromArgb(aOpacityChange, rGet, gGet, bGet));
                }

            }
            return temp;
        }

        /// <summary>
        /// Error in this scope, the method can't get the Alpha Image info
        /// and for that the algorithm doesn't work correctly.!!!!!
        /// 
        /// Ready, to go! Work!
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="opacity"></param>
        /// <returns></returns>

        public static Bitmap OpacityInParallelProcesing(Bitmap bmp, double opacity)
        {
            Bitmap temp = (Bitmap)bmp.Clone(); // work with a copy of the original.
            BitmapData bitmapData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppPArgb);

            int bytesPerPixel = 4;
            
            int byteCount = bitmapData.Stride * temp.Height;
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;

            int numBytes = widthInBytes * heightInPixels;
            byte[] pixels = new byte[numBytes];

            Marshal.Copy(ptrFirstPixel, pixels, 0, numBytes);

            for (int cont = 0; cont < pixels.Length; cont += bytesPerPixel)
            {
                if (pixels[cont + bytesPerPixel - 1] == 0)
                    continue;

                int pos = 0;
                pos++;
                pos++;
                pos++;

                pixels[cont + pos] = (byte)(pixels[cont + pos] * opacity);
                
            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, numBytes);
            temp.UnlockBits(bitmapData);

            return temp;
        }

        /// -------------------------------------- Opacity filter Parallel and Secuential, finish Section --------------------------------------------------------

        ///-------------------------------------- Invert Colors filter Parallel and Secuential --------------------------------------------------------

        public static Bitmap invertColorsFilterSecuential(Bitmap bmp)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color pixelColor = bmp.GetPixel(i, x);
                    int rGet = 255 - pixelColor.R;
                    int gGet = 255 - pixelColor.G;
                    int bGet = 255 - pixelColor.B;

                    temp.SetPixel(i, x, Color.FromArgb(rGet, gGet, bGet));
                }

            }
            return temp;
        }

        public static Bitmap invertColorsInParallelProcesing(Bitmap bmp)
        {
            Bitmap temp = bmp; // work with a copy of the original.
            BitmapData bitmapData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, temp.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(temp.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * temp.Height;
            byte[] pixels = new byte[byteCount];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;


            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    int oldBlue = (int)(255 - pixels[currentLine + x]);
                    int oldGreen = (int)(255 - pixels[currentLine + x + 1]);
                    int oldRed = (int)(255 - pixels[currentLine + x + 2]);

                    // calculate new pixel value
                    pixels[currentLine + x] = (byte)oldBlue;
                    pixels[currentLine + x + 1] = (byte)oldGreen;
                    pixels[currentLine + x + 2] = (byte)oldRed;
                }
            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            temp.UnlockBits(bitmapData);

            return temp;
        }

        /// -------------------------------------- Invert Colors filter Parallel and Secuential, finish Section --------------------------------------------------------

        ///-------------------------------------- Gaussin blur filter Parallel and Secuential --------------------------------------------------------

        public static Bitmap gaussinBlurColorsFilterSecuential(Bitmap bmp, int gaussinFactor)
        {
            ///Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
            Bitmap temp = bmp;

            for (int x = gaussinFactor; x <= temp.Width - gaussinFactor; x++)
            {
                for (int y = gaussinFactor; y <= temp.Height - gaussinFactor; y++)
                {
                    try
                    {
                        ///int pXN = (x - gaussinFactor < 0 ? 0 : x - gaussinFactor);
                        Color prevX = temp.GetPixel(x - gaussinFactor, y);

                        ///int pXP = (x + gaussinFactor < 0 ? 0 : x + gaussinFactor);
                        Color nextX = temp.GetPixel(x + gaussinFactor, y);

                        ///int pYN = (y - gaussinFactor < 0 ? 0 : y - gaussinFactor);
                        Color prevY = temp.GetPixel(x, y - gaussinFactor);

                        ///int pYP = (y + gaussinFactor < 0 ? 0 : y + gaussinFactor);
                        Color nextY = temp.GetPixel(x, y + gaussinFactor);

                        int R = (int)((prevX.R + nextX.R + prevY.R + nextY.R) / 4);
                        int G = (int)((prevX.G + nextX.G + prevY.G + nextY.G) / 4);
                        int B = (int)((prevX.B + nextX.B + prevY.B + nextY.B) / 4);

                        temp.SetPixel(x, y, Color.FromArgb(R, G, B));
                    }catch(Exception){

                    }
                }
               
            }
                return temp;
        }


        public static Bitmap gaussinBlurInParallelProcesing(Bitmap bmp, int gaussinFactor)
        {
            Bitmap temp = bmp; // work with a copy of the original.
            BitmapData bitmapData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, temp.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(temp.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * temp.Height;
            byte[] pixels = new byte[byteCount];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;


            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    try
                    {
                        int pYP = (currentLine - gaussinFactor < 0 ? 0 : currentLine - gaussinFactor);

                        int prevYOldBlue = (int)pixels[pYP + x];
                        int prevYOldGreen = (int)pixels[pYP + x + 1];
                        int prevYOldRed = (int)pixels[pYP + x + 2];

                        int pYN = (currentLine + gaussinFactor > heightInPixels ? currentLine : currentLine + gaussinFactor);

                        int nextYOldBlue = (int)pixels[pYN + x];
                        int nextYOldGreen = (int)pixels[pYN + x + 1];
                        int nextYOldRed = (int)pixels[pYN + x + 2];

                        int pXP = (x - (gaussinFactor * bytesPerPixel) < 0 ? 0 : x - (gaussinFactor * bytesPerPixel));

                        int prevXOldBlue = (int)pixels[currentLine + pXP];
                        int prevXOldGreen = (int)pixels[currentLine + pXP + 1];
                        int prevXOldRed = (int)pixels[currentLine + pXP + 2];

                        int pXN = (x + (gaussinFactor * bytesPerPixel) > (widthInBytes * y) ? x : x + (gaussinFactor * bytesPerPixel));

                        int nextXOldBlue = (int)pixels[currentLine + pXN];
                        int nextXOldGreen = (int)pixels[currentLine + pXN + 1];
                        int nextXOldRed = (int)pixels[currentLine + pXN + 2];


                        // calculate new pixel value
                        pixels[currentLine + x] = (byte)((prevYOldBlue + nextYOldBlue + prevXOldBlue + nextXOldBlue) / 4);
                        pixels[currentLine + x + 1] = (byte)((prevYOldGreen + nextYOldGreen + prevXOldGreen + nextXOldGreen) / 4);
                        pixels[currentLine + x + 2] = (byte)((prevYOldRed + nextYOldRed + prevXOldRed + nextXOldRed) / 4);

                    }catch(Exception){

                    }
                    
                }
            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            temp.UnlockBits(bitmapData);

            return temp;
        }

        /// -------------------------------------- Gaussin blur filter Parallel and Secuential, finish Section --------------------------------------------------------

        ///-------------------------------------- Adjusting brightness filter Parallel and Secuential --------------------------------------------------------

        public static Bitmap adjustingBrightnessFilterSecuential(Bitmap bmp, double brightnessValue)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color pixelColor = bmp.GetPixel(i, x);
                    int rGet = pixelColor.R + (int)brightnessValue;
                    int gGet = pixelColor.G + (int)brightnessValue;
                    int bGet = pixelColor.B + (int)brightnessValue;

                    rGet = (rGet > 255 ? 255 : (rGet < 0 ? 0 : rGet));
                    gGet = (gGet > 255 ? 255 : (gGet < 0 ? 0 : gGet));
                    bGet = (bGet > 255 ? 255 : (bGet < 0 ? 0 : bGet));

                    temp.SetPixel(i, x, Color.FromArgb(rGet, gGet, bGet));
                }

            }
            return temp;
        }

        public static Bitmap adjustingBrightnessInParallelProcesing(Bitmap bmp, double brightnessValue)
        {
            Bitmap temp = bmp; // work with a copy of the original.
            BitmapData bitmapData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, temp.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(temp.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * temp.Height;
            byte[] pixels = new byte[byteCount];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;


            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    int oldBlue = (int)pixels[currentLine + x] + (int)brightnessValue;
                    int oldGreen = (int)pixels[currentLine + x + 1] + (int)brightnessValue;
                    int oldRed = (int)pixels[currentLine + x + 2] + (int)brightnessValue;

                    oldBlue = (oldBlue > 255 ? 255 : (oldBlue < 0 ? 0 : oldBlue));
                    oldGreen = (oldGreen > 255 ? 255 : (oldGreen < 0 ? 0 : oldGreen));
                    oldRed = (oldRed > 255 ? 255 : (oldRed < 0 ? 0 : oldRed));


                    // calculate new pixel value
                    pixels[currentLine + x] = (byte)oldBlue;
                    pixels[currentLine + x + 1] = (byte)oldGreen;
                    pixels[currentLine + x + 2] = (byte)oldRed;
                }
            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            temp.UnlockBits(bitmapData);

            return temp;
        }

        /// -------------------------------------- Adjusting brightness filter Parallel and Secuential, finish Section --------------------------------------------------------

        /// ---------------------------------------------------- Rainbow filter Parallel and Secuential -----------------------------------------------------------------

        public static Bitmap RainbowFilter(Bitmap bmp)
        {

            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
            int raz = bmp.Width / 5;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {

                    if (i < (raz))
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B));
                    }
                    else if (i < (raz * 2))
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B));
                    }
                    else if (i < (raz * 3))
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
                    }
                    else if (i < (raz * 4))
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
                    }
                    else
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B / 5));
                    }
                }

            }
            return temp;
        }

        public static Bitmap RainbowFilterInParallelProcesing(Bitmap bmp)
        {
            Bitmap temp = bmp;
            BitmapData bitmapData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, temp.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(temp.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * temp.Height;
            byte[] pixels = new byte[byteCount];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;
            int raz = widthInBytes / 5;


            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    if (x < (raz))
                    {
                        int oldBlue = pixels[currentLine + x];
                        int oldGreen = pixels[currentLine + x + 1];
                        int oldRed = pixels[currentLine + x + 2] / 5;

                        // calculate new pixel value
                        pixels[currentLine + x] = (byte)oldBlue;
                        pixels[currentLine + x + 1] = (byte)oldGreen;
                        pixels[currentLine + x + 2] = (byte)oldRed;
                    }
                    
                    else if (x < (raz * 2))
                    {
                        int oldBlue = pixels[currentLine + x];
                        int oldGreen = pixels[currentLine + x + 1] / 5;
                        int oldRed = pixels[currentLine + x + 2];

                        // calculate new pixel value
                        pixels[currentLine + x] = (byte)oldBlue;
                        pixels[currentLine + x + 1] = (byte)oldGreen;
                        pixels[currentLine + x + 2] = (byte)oldRed;
                    }

                    else if (x < (raz * 3))
                    {
                        int oldBlue = pixels[currentLine + x] / 5;
                        int oldGreen = pixels[currentLine + x + 1];
                        int oldRed = pixels[currentLine + x + 2];

                        // calculate new pixel value
                        pixels[currentLine + x] = (byte)oldBlue;
                        pixels[currentLine + x + 1] = (byte)oldGreen;
                        pixels[currentLine + x + 2] = (byte)oldRed;
                    }

                    else if (x < (raz * 4))
                    {
                        int oldBlue = pixels[currentLine + x] / 5;
                        int oldGreen = pixels[currentLine + x + 1];
                        int oldRed = pixels[currentLine + x + 2] / 5;

                        // calculate new pixel value
                        pixels[currentLine + x] = (byte)oldBlue;
                        pixels[currentLine + x + 1] = (byte)oldGreen;
                        pixels[currentLine + x + 2] = (byte)oldRed;
                    }

                    else
                    {
                        int oldBlue = pixels[currentLine + x] / 5;
                        int oldGreen = pixels[currentLine + x + 1] / 5;
                        int oldRed = pixels[currentLine + x + 2] / 5;

                        // calculate new pixel value
                        pixels[currentLine + x] = (byte)oldBlue;
                        pixels[currentLine + x + 1] = (byte)oldGreen;
                        pixels[currentLine + x + 2] = (byte)oldRed;
                    }

                    
                }
            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            temp.UnlockBits(bitmapData);

            return temp;
        }

        /// ---------------------------------------------------- Rainbow filter Parallel and Secuential, finish Section ------------------------------------------------------

        ///----------------------------------------------------------- Blues Balance filter Parallel and Secuential ----------------------------------------------------------

        public static Bitmap bluesBalanceFilterSecuential(Bitmap bmp)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    int rGet = (int)(bmp.GetPixel(i, x).R * .1);
                    int gGet = bmp.GetPixel(i, x).G;
                    int bGet = bmp.GetPixel(i, x).B;
                    temp.SetPixel(i, x, Color.FromArgb(rGet, gGet, bGet));
                }

            }
            return temp;
        }

        public static Bitmap bluesBalanceInParallelProcesing(Bitmap bmp)
        {
            Bitmap temp = (Bitmap)bmp.Clone(); // work with a copy of the original.
            BitmapData bitmapData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppPArgb);

            int bytesPerPixel = 4;

            int byteCount = bitmapData.Stride * temp.Height;
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;

            int numBytes = widthInBytes * heightInPixels;
            byte[] pixels = new byte[numBytes];

            Marshal.Copy(ptrFirstPixel, pixels, 0, numBytes);

            for (int cont = 0; cont < pixels.Length; cont += bytesPerPixel)
            {
                if (pixels[cont + bytesPerPixel - 1] == 0)
                    continue;

                int pos = 2;

                pixels[cont + pos] = (byte)(pixels[cont + pos] * 0.1);

            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, numBytes);
            temp.UnlockBits(bitmapData);

            return temp;
        }

        /// -------------------------------------- Blues Balance Parallel and Secuential, finish Section --------------------------------------------------------





        ///-------------------------------------------- Text Processing Parallel and Secuential Section (All Methods) -----------------------------------------------

        public static String[] splitLines(String lines)
        {

            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n', '\a', '\f', '\r', '/' };

            String[] words = lines.Split(delimiterChars);

            return words;
        }

        public static String  wordMostLargeInLinesSecuential(String[] words)
        {
            String word = "";
            try
            {

                foreach (String wordInProcess in words)
                {
                    if (wordInProcess.Length > word.Length)
                        word = wordInProcess;
                }
            }
            catch (Exception)
            {

            }
            return word;
        }


        public static String[] nWordsMostCommonSecuential(String lineas, String[] words, int n)
        {
            foreach (string x in words)
            {
                int cant = lineas.LongCount(palabra=> palabra.ToString() == x);
            }








            String[] nWordsMostCommon = new String[n+1];
            String[] WordsToReturn = new String[n];
            String word = "";

            int inc = 0;

            while (inc <= n)
            {
                int wordMostUsedBef = 0;

                for(int i = 0; words.Length > i; i++)
                {
                    
                    foreach(String comprove in nWordsMostCommon){
                        if (words[i] == comprove)
                            goto Next;

                    }

                    int cont = 0;
                    foreach (String wordToCompare in words)
                    {
                        if (wordToCompare == words[i])
                        {
                            cont++;
                        }

                    }
                    if (words[i] != "\n")
                    {
                        if (wordMostUsedBef < cont)
                        {
                            word = words[i];
                            wordMostUsedBef = cont;
                        }
                    }

                    

                    Next:
                        i++;

                }

                nWordsMostCommon[inc] = word; 

                inc++;
            }

            for (int i = 0; nWordsMostCommon.Length > i; i++)
            {
                if (!(i == 0))
                {
                    WordsToReturn[i - 1] = nWordsMostCommon[i];
                }
            }
            return WordsToReturn;
        }


        public static int wordNTimesSecuential(String[] words, String reference)
        {
            int numberOfTimes = 0;

            foreach (String inProcess in words)
            {
                if (inProcess.Equals(reference)){
                    numberOfTimes++;
                }                
            }

            return numberOfTimes;
        }
    }
}
