using System.ComponentModel.Design;

namespace MathGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string[]> gameList = new List<string[]>
            {
                new string[] { "Name", "Category", "Points" },
                new string[] { "----", "--------", "------" }
            };

            int menu;
            bool continueGame = true;

            do
            {
                menu = Menu.Print();
                if (menu == 2)
                {
                    PreviousGames.List(gameList);
                }
                else
                {
                    gameList = Game.Start(menu, gameList);
                }
            }
            while (continueGame == true);
        }
    }
}