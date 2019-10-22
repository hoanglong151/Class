using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Balls
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;
        public Controller()
        {
            this.Game = new Board(3, 4, 6);
            this.P1 = new Player("Long NumberOne");
            this.P2 = new Player("Thanh Ngu");
        }
        public void PlayGame()
        {
            Game.PrintGame();
            while(true)
            {
                Console.WriteLine(P1.GetName() + " Player 1 : ");
                P1.PickBall(Game);
                Game.PrintGame();
                if(Game.IsGameOver())
                {
                    Console.WriteLine("Player 1 : You Lose");
                    break;
                }
                Console.WriteLine(P2.GetName() + " Player 2 : ");
                P2.PickBall(Game);
                    Game.PrintGame();
                if(Game.IsGameOver())
                {
                    Console.WriteLine("Player 2 : You Lose");
                    break;
                }               
            }
        }
    }   
}
