using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

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


        public static Bitmap RainbowFilterParallel(Bitmap bmp)
        {

            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
            int raz = bmp.Width / 5;

            Parallel.For(0, bmp.Width, i =>
            {
                //Parallel.For(0, bmp.Height, x =>
                //{

                    //if (i < (raz))
                    //{
                    //    temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B));
                    //}
                    //else if (i < (raz * 2))
                    //{
                    //    temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B));
                    //}
                    //else if (i < (raz * 3))
                    //{
                    //    temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
                    //}
                    //else if (i < (raz * 4))
                    //{
                    //    temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
                    //}
                    //else
                    //{
                    //    temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B / 5));
                  //  }

                //});

                for (int x = 0; x < bmp.Height; x++)
                {
                    var t1 = Task.Factory.StartNew(() => DoSomeToBlue(temp, bmp, i, x, raz));
                }
                    
                //for (int x = 0; x < bmp.Height; x++)
                //{
                //    var t1 = Task.Factory.StartNew(() => DoSomeToBlue(temp, bmp, i, x, raz));
                //    var t2 = Task.Factory.StartNew(() => DoSomeToViolet(temp, bmp, i, x, raz));
                //    var t3 = Task.Factory.StartNew(() => DoSomeToYellow(temp, bmp, i, x, raz));
                //    var t4 = Task.Factory.StartNew(() => DoSomeToGreen(temp, bmp, i, x, raz));
                //    var t5 = Task.Factory.StartNew(() => DoSomeToBlack(temp, bmp, i, x, raz));
                //}
                
            });
            return temp;
        }



        static void DoSomeToBlue(Bitmap temp, Bitmap bmp, int i, int x, int raz)
        {
            //if (i < raz)
            //{
                temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B));     
            //}   
        }

        static void DoSomeToViolet(Bitmap temp, Bitmap bmp, int i, int x, int raz)
        {
            if (i < (raz * 2))
            {
                temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B));
            }
        }

        static void DoSomeToYellow(Bitmap temp, Bitmap bmp, int i, int x, int raz)
        {
            if (i < (raz * 3))
            {
                temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
            }
        }

        static void DoSomeToGreen(Bitmap temp, Bitmap bmp, int i, int x, int raz)
        {
            if (i < (raz * 4))
            {
                temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
            }
        }

        static void DoSomeToBlack(Bitmap temp, Bitmap bmp, int i, int x, int raz)
        {
            if (i < (raz * 5))
            {
                temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B / 5));
            }
        }

    }
}
