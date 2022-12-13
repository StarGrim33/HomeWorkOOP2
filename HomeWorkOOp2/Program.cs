using System.Numerics;

namespace HomeWorkOOp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new();

            Console.WriteLine("Введите позицию по X");
            bool isUserInputX = int.TryParse(Console.ReadLine(), out int userInputPositionX);

            Console.WriteLine("Введите позицию по Y");
            bool isUserInputY = int.TryParse(Console.ReadLine(), out int userInputPositionY);

            if (isUserInputX && isUserInputY)
            {
                Console.WriteLine($"Позиция по Х: {userInputPositionX}, позиция по Y: {userInputPositionY}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод позиций, попробуйте заново, введя числа");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите символ отображения игрока: ");
            bool isUserInputCh = char.TryParse(Console.ReadLine(), out char charPlayerInput);

            if (isUserInputCh)
            {
                Console.WriteLine("Введен символ:" + charPlayerInput);
            }
            else
            {
                Console.WriteLine("Некорректный ввод символа, попробуйте заново");
                Console.ReadKey();
                return;
            }

            renderer.DrawPlayer(userInputPositionX, userInputPositionY, charPlayerInput);
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
        public void DrawPlayer(int playerPositionX, int playerPositionY, char playerSymbol)
        {
            Console.Clear();
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(playerSymbol);
        }
    }
}