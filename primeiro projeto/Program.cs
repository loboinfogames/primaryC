using System;

namespace primeiro_projeto {
    class Program {
        static void other(string[] args) {
            Console.WriteLine("Somando duas variaveis");
            SByte x = 100; //equilavelnte .net precisa da biblioteca system
            sbyte y = 50; //versão c#
            var soma = x + y;
            Console.WriteLine(soma);

            byte n1 = 126;//byte maximo 255
            n1++;
            Console.WriteLine(n1);

            int n2 = 1024;
            long n3 = 1024000000L;
            Console.WriteLine(n2);
            Console.WriteLine( n3);

            bool completo = false;
            char genero = 'F';
            Console.WriteLine(completo);
            Console.WriteLine(genero);

            float velocidade = 4.2f;
            double pulo = 2.0;
            Console.WriteLine("sua velocidade é: "+ velocidade);
            Console.WriteLine("força pulo: " + pulo);

            string nome = "Maria Green";
            Console.WriteLine(nome);

            object obj1 = "Item desnecessario";
            object obj2 = 4.5f;
            Console.WriteLine(obj1+"  .  "+obj2);


        }
    }
}
