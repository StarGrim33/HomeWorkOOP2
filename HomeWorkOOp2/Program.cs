using System.Numerics;

namespace HomeWorkOOp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInputPositionX = 0;
            int userInputPositionY = 0;
            char charPlayerInput = '@';
            Renderer renderer = new Renderer();
            Player player = new Player(userInputPositionX, userInputPositionY, charPlayerInput);

            player.DefinitionPlayerPositions(ref userInputPositionX, ref userInputPositionY, ref charPlayerInput);

            player = new Player(userInputPositionX, userInputPositionY, charPlayerInput);

            Console.Clear();
            renderer.DrawPlayer(player.LocationX, player.LocationY, player.Sign);
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

        public void DefinitionPlayerPositions(ref int userInputPositionX, ref int userInputPositionY, ref char charPlayerInput)
        {
            Console.WriteLine("Введите позицию по X");
            bool isUserInputX = int.TryParse(Console.ReadLine(), out userInputPositionX);

            if (isUserInputX)
            {
                Console.WriteLine("Позиция по Х: " + userInputPositionX);
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте заново, введя число");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию по Y");
            bool isUserInputY = int.TryParse(Console.ReadLine(), out userInputPositionY);

            Console.WriteLine("Введите символ отображения игрока: ");
            bool isUserInputCh = char.TryParse(Console.ReadLine(), out charPlayerInput);

            if (isUserInputCh)
            {
                Console.WriteLine("Введен символ:" + charPlayerInput);
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте заново");
                Console.ReadKey();
                return;
            }
        }
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