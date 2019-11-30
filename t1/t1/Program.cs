using System;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadLine();

            int añoActual = Convert.ToInt32("2019");
            double numeroPI = 3.141592;
            Console.WriteLine("Valores:{0} -- {1}", añoActual, numeroPI);
            decimal montoFactura = 94593.34m + 0.07m;
            float impuestoVenta = 9239.04f;
            Console.WriteLine("Valores:{0} -- {1}", montoFactura, impuestoVenta);

            char letraInicial = 'P';
            string nombreCurso = letraInicial + "rogramación II";
            Console.WriteLine("Este es el curso {0}", nombreCurso);
            bool boolVerdadero = true;
            bool boolFalso = false;
            Console.WriteLine("Variables boleanas:{0} y {1}", boolVerdadero, boolFalso);

            double resultadoSuma = 540 + -18.5;
            float resultadoResta = 3458.35f - 334.34f;
            decimal resultadoMultiplicacion = 23.423m * 3423m;
            decimal resultadoDivision = 239.42m / 0.3m;
            decimal resultadoResiduo = 2321.423m % 23m;
            double resultadoPotencia = Math.Pow(78, 2);
            double resultadoRaiz = Math.Sqrt(144);
            //Console.ReadLine();

            int primerNumero = 48;
            int segundoNumero = 12;
            primerNumero += segundoNumero;
            primerNumero -= segundoNumero;
            primerNumero *= segundoNumero;
            primerNumero /= segundoNumero;
            primerNumero %= segundoNumero;
            primerNumero++;
            primerNumero--;

            bool comparacionY = true && true;
            var comparacionO = true || false;
            bool comparacionIgual = comparacionY == comparacionO;
            bool valorNegado = !comparacionIgual;

            if (DateTime.Now.Minute % 2 == 0)
            {
                Console.WriteLine("Este minuto es par");
            }
            else if (DateTime.Now.Minute == 5)
            {
                Console.WriteLine("Este es el minuto 5");
            }
            else
            {
                Console.WriteLine("Este minuto es impar");
            }

            int rondasFaltantes = 3;
            while (rondasFaltantes > 0)
            {
                rondasFaltantes--;
            }
            rondasFaltantes = 3;
            do
            {
                rondasFaltantes--;
            } while (rondasFaltantes > 0);
            string[] diasSemanales = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            for (int dia = 0; dia < 7; dia++)
            {
                Console.WriteLine("{0} es el número {1} de la semana", diasSemanales[dia], dia + 1);
            }

            string frase = "La programación me permite crear";
            Console.WriteLine("{0}", frase.ToUpper());
            Console.WriteLine("{0}", frase.ToLower());
            Console.WriteLine("{0}{1}", frase.Substring(0,1).ToUpper(), frase.Substring(1, frase.Length - 1).ToLower());
            int unMillon = 1000000;
            string numeroComoCaracter = unMillon.ToString();
            Console.ReadLine();

        }
        double resultado = 0;
        void LimpiarResultado()
        {
            resultado = 0;

        }
        double Multiplicar(int a, int b)
        {
            resultado = a + b;
            return resultado;
        }
    }
}
