using Shake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;

namespace Shake
{
    class Program
    {
        static void Main( string[] args ) 
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream = assembly.GetManifestResourceStream(@"Shake.Arkadijj_Dukhin_wav_-_Tel_Aviv_(musmore.com)--online-audio-convert.com.wav");
            SoundPlayer player = new SoundPlayer(resourceStream);
            player.Play();
            Console.SetWindowSize(80, 25);

            Walls walls = new Walls( 80, 25 );
            walls.Draw();
            //VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            //Draw(vl);

            //Point p = new Point( 4, 5, '*' );
            //Figure fSnake = new Snake( p, 4, Direction.RIGHT );
            //Draw( fSnake );
            //Snake snake = (Snake) fSnake;

            //HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            //List<Figure> figures = new List<Figure>();
            //figures.Add(fSnake);
            //figures.Add(vl);
            //figures.Add(hl);

            //foreach (var f in figures)
            //{
            //    f.Draw();
            //}
            /*Console.SetBufferSize(); *///setting the size of window without scroll

            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';

            //point p1 = new point(1, 3, '*'); //creating point
            //p1.x= 1;
            //p1.y= 3;
            //p1.sym = '*';

            //Draw( p1.x, p1.y, p1.sym );
            //p1.Draw(); // output 

            //point p2 = new point(4, 5, '#');
            //p2.x= 4;
            //p2.y = 5;
            //p2.sym = '#';

            //Draw(p2.x, p2.y, p2.sym);
            //p2.Draw();

            //Console.SetCursorPosition(x1, y1);
            //Console.Write(sym1);

            //Draw(x1,y1,sym1);

            //int x2 = 4;
            //int y2 = 5;
            //char sym2 = '#';

            //Console.SetCursorPosition(x2, y2);
            //Console.Write(sym2);
            //Draw(x2, y2, sym2);

            //List<int> numlist= new List<int>(); //holding list of integer element
            //numlist.Add(0);
            //numlist.Add(1);
            //numlist.Add(2);

            //int x = numlist[0];
            //int y = numlist[1];
            //int z = numlist[2];

            //foreach(int i in numlist)
            //{
            //    Console.WriteLine(i);
            //}

            //numlist.RemoveAt(0);

            //List<point> plist = new List<point>();
            //plist.Add(p1);
            //plist.Add(p2);
            
            //Frame drawing
            //HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            //HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            //VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            //VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            //upline.Draw();
            //downline.Draw();
            //leftline.Draw();
            //rightline.Draw();

            //Point drawing
            Point p = new Point(4, 5, '*');
            //p.Draw();
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true) 
            {
                if ( walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                //while (true)
                //{
                //    if (Console.KeyAvailable)
                //    {
                //        ConsoleKeyInfo key = Console.ReadKey();
                //        if (key.Key == ConsoleKey.LeftArrow)
                //            snake.direction = Direction.LEFT;
                //        else if (key.Key == ConsoleKey.RightArrow)
                //            snake.direction = Direction.RIGHT;
                //        else if (key.Key == ConsoleKey.DownArrow)
                //            snake.direction = Direction.DOWN;
                //        else if ( key.Key == ConsoleKey.UpArrow)
                //            snake.direction = Direction.UP;
                //    }
                //    Thread.Sleep(100);
                //    snake.Move();
                //}
            }
            player.Stop();
            WriteGameOver();
            Console.ReadLine();

        }

        //static void Draw(int x, int y, char sym)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(sym);
        //}
        //static void Draw ( Figure figure)
        //{
        //    figure.Draw();
        //}
        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("LOL", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("Автор: Vladimir Dudakov", xOffset + 2, yOffset++);
            WriteText("The only one day was the easy it is yesterday", xOffset + 1, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText ( String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}