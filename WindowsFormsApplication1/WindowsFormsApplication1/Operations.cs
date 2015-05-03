using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    class Operations
    {

        /// Rainbow filter try

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

        public static Bitmap RainbowFilterParallelLockbits(Bitmap bmp)
        {
            Bitmap temp = null;
            temp = new Bitmap(bmp);
            int raz = bmp.Height / 4;
            int height = bmp.Height;
            int width = bmp.Width;
            Rectangle rect = new Rectangle(Point.Empty, bmp.Size);

            BitmapData bmpData = temp.LockBits(rect, ImageLockMode.ReadOnly, temp.PixelFormat);
            int bpp = (temp.PixelFormat == PixelFormat.Format32bppArgb) ? 4 : 3;
            int size = bmpData.Stride * bmpData.Height;
            byte[] data = new byte[size];
            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, data, 0, size);

            var options = new ParallelOptions();
            int maxCore = Environment.ProcessorCount - 1;
            options.MaxDegreeOfParallelism = maxCore > 0 ? maxCore : 1;

            Parallel.For(0, height, options, y =>
            {
                for (int x = 0; x < width; x++)
                {
                    {
                        int index = y * bmpData.Stride + x * bpp;

                        if (y < (raz)) data[index + 2] = (byte)(data[index + 2] / 5);
                        else if (y < (raz * 2)) data[index + 1] = (byte)(data[index + 1] / 5);
                        else if (y < (raz * 3)) data[index] = (byte)(data[index] / 5);
                        else if (y < (raz * 4))
                        {
                            data[index + 2] = (byte)(data[index + 2] / 5);
                            data[index] = (byte)(data[index] / 5);
                        }
                        else
                        {
                            data[index + 2] = (byte)(data[index + 2] / 5);
                            data[index + 1] = (byte)(data[index + 1] / 5);
                            data[index] = (byte)(data[index] / 5);
                        }
                    };
                };

            });
            temp.UnlockBits(bmpData);
            return temp;
        }

        
        
    }
}
