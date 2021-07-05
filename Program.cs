using System;

namespace Caballo_Ajedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa te inicia y te ayuda a ver movimiento de un caballo\n");
            Console.WriteLine("Ingresa las cordenadas del caballo");
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());
            Pawn pawn = new Pawn("Caballo","Negro",x,y);
            if (!pawn.AssignOnBoard(x, y))
            {
                Console.WriteLine("Error en las cordenadas"); 
                return;
            }
            Console.WriteLine(pawn.PossibleToMove());

        }
    }
}
