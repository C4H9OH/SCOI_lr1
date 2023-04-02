using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace IMGapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ(int a, int b)
            {
                int tmp = a + b;
                if (tmp > 255) tmp = 255;
                return tmp;
            }

            int max(int a, int b)
            {
                if (a > b) return a; else return b;
            }

            string tmp1, tmp2;

            Console.WriteLine("Укажите имя первого файла:");
            tmp1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Укажите имя второго файла:");
            tmp2 = Convert.ToString(Console.ReadLine());
            




            void NumberOne(string tmpName1, string tmpName2)
            {
                using (var img1 = new Bitmap($"..\\..\\{tmpName1}"))    
                {    

                var img2 = new Bitmap($"..\\..\\{tmpName2}");

                

                var w = img1.Width;
                    var h = img1.Height;

                    var w2 = img2.Width;
                    var h2 = img2.Height;

                    using (var img_out = new Bitmap(w, h))   
                    {
                        var img_out2 = new Bitmap(w, h);

                        var time1 = DateTime.Now;
                        Stopwatch timer = new Stopwatch();
                        timer.Start();

   
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {                                
                                var pix = img1.GetPixel(j, i);
                                var pix2 = img2.GetPixel(j, i);
                                
                                int r = pix.R;
                                int g = pix.G;
                                int b = pix.B;

                                int r2 = pix2.R;
                                int g2 = pix2.G;
                                int b2 = pix2.B;
                                
                                r = (int)Clamp(summ(r, r2), 0, 255);
                                g = (int)Clamp(summ(g, g2), 0, 255);
                                b = (int)Clamp(summ(b, b2), 0, 255);


                            
                                pix = Color.FromArgb(r, g, b);
                                img_out.SetPixel(j, i, pix);

                                
                            }
                        }

                       
                        timer.Stop();

                        Console.WriteLine("Обработал изображение за " + timer.ElapsedMilliseconds + " мс.");

                       
                        Console.WriteLine("Укажите имя итогового файла:");
                        string zxc1 = Convert.ToString(Console.ReadLine());

                        img_out.Save($"..\\..\\{zxc1}");

                        Console.WriteLine("Выходное изображение было сохренено по пути " + Directory.GetParent("..\\..\\") + $"{zxc1}");
                        Console.ReadKey();

                    }

                }
            }

            void NumberTwo(string tmpName1, string tmpName2)
            {
                using (var img1 = new Bitmap($"..\\..\\{tmpName1}"))   
                {    

                    var img2 = new Bitmap($"..\\..\\{tmpName2}");

                    Console.WriteLine("Открываю изображение № 1" + Directory.GetParent("..\\..\\") + "\\in1.jpg");

                    var w = img1.Width;
                    var h = img1.Height;

                    var w2 = img2.Width;
                    var h2 = img2.Height;

                    using (var img_out = new Bitmap(w, h))   
                    {
                        var img_out2 = new Bitmap(w, h);

                        var time1 = DateTime.Now;
                        Stopwatch timer = new Stopwatch();
                        timer.Start();

                        
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                
                                var pix = img1.GetPixel(j, i);
                                var pix2 = img2.GetPixel(j, i);
                                
                                int r = pix.R;
                                int g = pix.G;
                                int b = pix.B;

                                int r2 = pix2.R;
                                int g2 = pix2.G;
                                int b2 = pix2.B;
                              
                                r = (int)Clamp((r + r2) / 2, 0, 255);
                                g = (int)Clamp((g + g2) / 2, 0, 255);
                                b = (int)Clamp((b + b2) / 2, 0, 255);
                                
                                pix = Color.FromArgb(r, g, b);
                                img_out.SetPixel(j, i, pix);
                                
                            }
                        }
                        
                        timer.Stop();

                        Console.WriteLine("Время обработки изображения " + timer.ElapsedMilliseconds + " мс.");


                        Console.WriteLine("Укажите имя итогового файла:");
                        string zxc2 = Convert.ToString(Console.ReadLine());

                        img_out.Save($"..\\..\\{zxc2}");

                        Console.WriteLine("Выходное изображение было сохренено по пути " + Directory.GetParent("..\\..\\") + $"{zxc2}");
                        Console.ReadKey();

                    }

                }
            }

            void NumberThree(string tmpName1, string tmpName2)
            {
                using (var img1 = new Bitmap($"..\\..\\{tmpName1}"))   
                {    

                    var img2 = new Bitmap($"..\\..\\{tmpName2}");

                    Console.WriteLine("Открываю изображение № 1" + Directory.GetParent("..\\..\\") + "\\in1.jpg");

                    var w = img1.Width;
                    var h = img1.Height;

                    var w2 = img2.Width;
                    var h2 = img2.Height;

                    using (var img_out = new Bitmap(w, h))   
                    {
                        var img_out2 = new Bitmap(w, h);

                        var time1 = DateTime.Now;
                        Stopwatch timer = new Stopwatch();
                        timer.Start();

                        
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {                                
                                var pix = img1.GetPixel(j, i);
                                var pix2 = img2.GetPixel(j, i);
                                
                                int r = pix.R;
                                int g = pix.G;
                                int b = pix.B;

                                int r2 = pix2.R;
                                int g2 = pix2.G;
                                int b2 = pix2.B;
                                
                                r = (int)Clamp(max(r, r2), 0, 255);
                                g = (int)Clamp(max(g, g2), 0, 255);
                                b = (int)Clamp(max(b, b2), 0, 255);
                               
                                pix = Color.FromArgb(r, g, b);
                                img_out.SetPixel(j, i, pix);
                                
                            }
                        }

                         
                        timer.Stop();

                        Console.WriteLine("Обработал изображение за " + timer.ElapsedMilliseconds + " мс.");

                        Console.WriteLine("Укажите имя итогового файла:");
                        string zxc3 = Convert.ToString(Console.ReadLine());

                        img_out.Save($"..\\..\\{zxc3}");

                        Console.WriteLine("Выходное изображение было сохренено по пути " + Directory.GetParent("..\\..\\") + $"{zxc3}");
                        Console.ReadKey();

                    }

                }
            }

            Console.WriteLine(" 1 - сумма \n 2 - AVG \n 3 - максимум \n ваш выбор:");

            char key = Convert.ToChar(Console.ReadLine());
            switch (key) { 
            case '1':
                    NumberOne(tmp1,tmp2);
                    break;
            case '2':
                    NumberTwo(tmp1, tmp2);
                    break;
            case '3':
                    NumberThree(tmp1, tmp2);
                    break;
            }
        }

        public static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }
    }
}
