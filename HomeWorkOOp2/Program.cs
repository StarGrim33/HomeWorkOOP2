using System.Numerics;

namespace HomeWorkOOp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? userInputPositionX = null;
            string? userInputPositionY = null;
            string? userInputChar = null;
            int integerUserInputX = 0;
            int integerUserInputY = 0;
            char charPlayerInput = '@';
            Renderer renderer = new Renderer();

            DefinitionPlayerPositions(userInputPositionX, userInputPositionY, userInputChar, ref integerUserInputX, ref integerUserInputY, ref charPlayerInput);

            Player player = new Player(integerUserInputX, integerUserInputY, charPlayerInput);

            Console.Clear();
            renderer.DrawPlayer(player.PlayerLocationX, player.PlayerLocationY, player.PlayerSign);
        }

        static void DefinitionPlayerPositions(string userInputPositionX, string userInputPositionY, string userInputChar, ref int integerUserInputX, ref int integerUserInputY, ref char charPlayerInput)
        {
            Console.WriteLine("Введите позицию по X");
            userInputPositionX = Console.ReadLine();

            if (int.TryParse(userInputPositionX, out integerUserInputX))
            {
                Console.WriteLine("Позиция Х: " + integerUserInputX);
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте заново, введя число");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию по Y");
            userInputPositionY = Console.ReadLine();

            if (int.TryParse(userInputPositionY, out integerUserInputY))
            {
                Console.WriteLine("Позиция Х: " + integerUserInputY);
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте заново, введя число");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите символ отображения игрока: ");
            userInputChar = Console.ReadLine();

            if(char.TryParse(userInputChar, out charPlayerInput))
            {
                Console.WriteLine("Введен символ:" + userInputChar);
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте заново");
                Console.ReadKey();
                return;
            }
        }
    }

    class Player
    {
        public Player(int playerPositionX, int playerPositionY, char playerSymbol)
        {
            PlayerLocationX = playerPositionX;
            PlayerLocationY = playerPositionY;
            PlayerSign = playerSymbol;
        }

        public int PlayerLocationX { get; private set; }
        public int PlayerLocationY { get; private set; }
        public char PlayerSign { get; private set; }
    }

    class Renderer
    {
        public void DrawPlayer(int playerPositionX, int playerPositionY, char playerSymbol)
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(playerSymbol);
        }
    }
}