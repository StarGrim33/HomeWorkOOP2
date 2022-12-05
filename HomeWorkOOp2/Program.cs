using System.Numerics;

namespace HomeWorkOOp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();

            Console.WriteLine("Введите позицию по X");
            int userInputPositionX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позицию по Y");
            int userInputPositionY = Convert.ToInt32(Console.ReadLine());

            Player player = new Player(userInputPositionX, userInputPositionY);

            Console.Clear();
            renderer.DrawPlayer(player.PlayerPositionX, player.PlayerPositionY);
        }
    }

    class Player
    {
        public Player(int playerPositionX, int playerPositionY)
        {
            PlayerPositionX = playerPositionX;
            PlayerPositionY = playerPositionY;
        }

        public int PlayerPositionX { get; private set; }
        public int PlayerPositionY { get; private set; }
    }

    class Renderer
    {
        public void DrawPlayer(int x, int y, char playerSymbol = '$')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(playerSymbol);
        }
    }
}