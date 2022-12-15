using System.Numerics;

namespace HomeWorkOOp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startPositionX = 2;
            int startPositionY = 2;
            char defaultSymbol = '$';

            Renderer renderer = new();
            Player player = new(startPositionX, startPositionY, defaultSymbol);

            renderer.DrawPlayer(player);
        }
    }

    class Player
    {
        public Player(int positionX, int positionY, char symbol)
        {
            LocationX = positionX;
            LocationY = positionY;
            Sign = symbol;
        }

        public int LocationX { get; private set; }
        public int LocationY { get; private set; }
        public char Sign { get; private set; }
    }

    class Renderer
    {
        public void DrawPlayer(Player player)
        {
            Console.Clear();
            Console.SetCursorPosition(player.LocationX, player.LocationY);
            Console.Write(player.Sign);
        }
    }
}