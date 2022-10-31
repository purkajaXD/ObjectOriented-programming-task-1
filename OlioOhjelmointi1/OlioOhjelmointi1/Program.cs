using System;

namespace OlioOhjelmointi1
{
    class Program
    {
        static void Main(string[] args)
        {

            Bird b = new Bird();
            b.name = "Tweety";

            Bird b2 = new Bird();
            b2.name = "Woody";


            Bird[] birds = new Bird[100];

            for (int i = 0; i < birds.Length; i++)
            {
                birds[i] = new Bird();
                birds[i].name = "Bird" + i;
            }

            for (int i = 0; i < birds.Length; i++)
            {
                birds[i].Chirp();
            }

     
        }

        public class Bird
        {
            public string name;


            public void Chirp()
            {
                System.Console.WriteLine(name + " says chrip!");
            }

        }
    }
}
