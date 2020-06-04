using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DateTime horario=DateTime.Now;
            Console.WriteLine($"Olá usuário, são agora {horario.TimeOfDay} do sistema de seu computador");
        }
    }
}
