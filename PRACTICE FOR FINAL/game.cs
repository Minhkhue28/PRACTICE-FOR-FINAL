using System;
using System.Threading;

class FlappyBird
{
    static int width = 40;
    static int height = 20;

    static int birdX = 10;
    static int birdY = 10;
    static int gravity = 1;

    static int pipeX = 35;
    static int gapY = 8;
    static int gapSize = 5;

    static bool gameOver = false;

    static void Main()
    {
        Console.CursorVisible = false;

        while (!gameOver)
        {
            Input();
            Update();
            Draw();
            Thread.Sleep(100);
        }

        Console.SetCursorPosition(10, height / 2);
        Console.Write("GAME OVER!");
        Console.ReadKey();
    }

    static void Input()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Spacebar)
            {
                birdY -= 2; // bay lên
            }
        }
    }

    static void Update()
    {
        birdY += gravity;     // rơi xuống
        pipeX--;

        if (pipeX < 0)
        {
            pipeX = width - 1;
            gapY = new Random().Next(3, height - gapSize - 3);
        }

        // Va chạm
        if (birdY <= 0 || birdY >= height - 1)
            gameOver = true;

        if (pipeX == birdX)
        {
            if (birdY < gapY || birdY > gapY + gapSize)
                gameOver = true;
        }
    }

    static void Draw()
    {
        Console.Clear();

        // Chim
        Console.SetCursorPosition(birdX, birdY);
        Console.Write("@");

        // Cột
        for (int y = 0; y < height; y++)
        {
            if (y < gapY || y > gapY + gapSize)
            {
                if (pipeX > 0 && pipeX < width)
                {
                    Console.SetCursorPosition(pipeX, y);
                    Console.Write("|");
                }
            }
        }
    }
}
