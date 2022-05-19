using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace P324_FileStream_Task_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            #region File stream
            //string path = @"C:\Users\Lenovo\Desktop\p324test";
            //string wordText = Path.Combine(path, "wordText");
            ////Console.WriteLine(p324Test);
            //string filePath = Path.Combine(wordText, "text.txt");
            //Directory.CreateDirectory(wordText);
            //Directory.Delete(path, true);

            //if (!File.Exists(filePath))
            //{
            //    File.Create(filePath);
            //}

            //File.Delete(filePath);



            ////streamWriter.Flush();




            //streamWriter.Close();
            //streamWriter.WriteLine("After flush");

            //using (StreamReader streamReader = new StreamReader(filePath))
            //{
            //    string datas = streamReader.ReadToEnd();

            //}


            //Console.WriteLine("Before destructed");
            //if (true)
            //{
            //Human human = new Human();
            //human.Test();
            //for (int i = 0; i < 10000; i++)
            //{
            //    Console.Write(i);
            //}

            //}

            //for (int i = 0; i < 10000; i++)
            //{
            //    Console.Write(i);
            //}




            //streamReader.Close();

            //using StreamWriter streamWriter = new StreamWriter(filePath, true);
            //streamWriter.WriteLine("Bezdirdin meni");

            //for (int i = 1; i <= 10; i++)
            //{
            //    streamWriter.WriteLine("Khalil " + i);
            //}


            //streamWriter.Close();
            //Console.WriteLine(datas);
            #endregion


            //Thread thread = new Thread(Write0);
            //Thread thread1 = new Thread(Write1);
            //thread.Start();
            ////thread.Join();
            //thread1.Start();

            //Task task = Task.Run(() =>
            //{
            //    Console.WriteLine("Hello");
            //});

            //Task task1 = Task.Run(() =>
            //{
            //    Console.WriteLine("second task");
            //});
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write(i);
            //}
            //Console.Read();




            var task = Task.WhenAll(Cleaning(), Boiling(), CookingEgg());
            task.ContinueWith(t =>
            {
                Console.WriteLine("Start to eat");

            });

            Console.WriteLine(task.IsCompleted);
            Console.Read();
        }

        public static Task CookingEgg()
        {
            var task = Task.Run(() =>
            {
                Console.WriteLine("Start cooking (Please wait 5 seconds)");
                Thread.Sleep(5000);
                Console.WriteLine("End of the cooking");

            });
            
            return task;
        }

        public async static Task<string> Boiling()
        {
            var task1 = await Task.Run(() =>
            {
                Console.WriteLine("Start boiling (Please wait 10 seconds)");
                Thread.Sleep(10000);
                Console.WriteLine("End of the boiling");
                return "done";

            });
            var task2 = await Task.Run(() =>
            {
                Console.WriteLine("Start tea (Please wait 4 seconds)");
                Thread.Sleep(4000);
                Console.WriteLine("End of the tea");
                return "done";

            });
            return task1;

        }

   

        public static Task Cleaning()
        {
            var task = Task.Run(() =>
            {
                Console.WriteLine("Start cleaning (Please wait 2 seconds)");
                Thread.Sleep(2000);
                Console.WriteLine("End of the cleaning");

            });
            return task;

        }


        public static void Write0()
        {
            for (int i = 0; i <= 10000; i++)
            {
                Thread.Sleep(1000);
                Console.Write(0);
            }
        }
        public static void Write1()
        {
            for (int i = 0; i <= 10000; i++)
            {
                Thread.Sleep(1000);
                Console.Write(1);
            }
        }
    }

    class Human
    {
        //public void Dispose()
        //{
        //    Console.WriteLine("Hello");
        //}

        public void Test()
        {
            Console.WriteLine("Test");
        }

        ~Human()
        {
            Console.WriteLine("This file destructed");
        }
    }
}
