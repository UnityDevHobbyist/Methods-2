using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int score;
        static void Main(string[] args)
        {
            Console.WriteLine("Methods");

            AddScore(0);
            AddScore(300);
            AddScore(400);

            Console.ReadKey(true);
        }
        static void AddScore(int enemyPoints)
        {
            score = score + enemyPoints;
            ShowHUD();
        }
        static void ShowHUD()
        {
            Console.WriteLine("Score: " + score);
        }
    }
}