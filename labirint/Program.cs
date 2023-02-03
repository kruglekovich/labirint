using System;

namespace labirint
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeFactory factory = new MazeFactory();
            MazeFactory mazeGame = new MazeGame();
            mazeGame.start(factory);
        }
    }
}
