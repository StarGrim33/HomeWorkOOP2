using System.Numerics;

namespace HomeWorkOOp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInputPositionX = 0;
            int userInputPositionY = 0;
            Renderer renderer = new Renderer();

            renderer.DefinitionPlayerPositions(ref userInputPositionX, ref userInputPositionY);

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
        public void DefinitionPlayerPositions(ref int userInputPositionX, ref int userInputPositionY)
        {
            Console.WriteLine("Введите позицию по X");
            userInputPositionX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позицию по Y");
            userInputPositionY = Convert.ToInt32(Console.ReadLine());
        }

        public void DrawPlayer(int playerPositionX, int playerPositionY, char playerSymbol = '$')
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(playerSymbol);
        }
    }
}