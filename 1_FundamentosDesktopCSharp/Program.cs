using System;

namespace _1_FundamentosDesktopCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentario de una sola linea
            /*
             Comentarios en varias lineas
             */

            //1. Principales Tipos de Datos

            //1.1 Numeros Enteros
            int numeroEntero = 5;
            //1.2 Numeros Decimal
            double numeroDecimal = 2.5;
            //1.3 Cadenas de Textos
            string texto = "Hola a todos";
            //1.4 Tipo Booleanos
            Boolean verdaderoFalso = true;
            //1.5 Tipo Caracter
            char caracter = 'S';


            //1.6 Mostrando los resultados de los principales tipos de datos
            Console.WriteLine("---------1.Principales Tipos de DATOS---------");
            Console.WriteLine("Numero entero: " + numeroEntero);
            Console.WriteLine("Numero Decimal: " + numeroDecimal);
            Console.WriteLine("Valor del Texto: " + texto);
            Console.WriteLine("Valor Booleano: " + verdaderoFalso);
            Console.WriteLine("Valor Caracter: " + caracter);

            //2. Transformacion de Datos

            Console.WriteLine("---------2.Transformación de Datos--------");
            int entero = 10;
            double Decimal = 5.25;
            bool booleano = true;

            //Convertir de entero a Cadena de Texto
            Console.WriteLine(Convert.ToString(entero));
            //Convertir de entero a Double
            Console.WriteLine(Convert.ToDouble(entero));
            //Convertir de Decimal a Entero
            Console.WriteLine(Convert.ToInt32(Decimal));
            //Convertir de Booleano a Cadena de Texto
            Console.WriteLine(Convert.ToString(booleano));

            //3. Operadores

            /*Operadores aritméticos
             +  : Suma
             -  : Resta
             *  : Multiplicacion
             /  : División
             %  : Módulo
             ++ : Incremento
             -- : Decremento             
             */

            /*Operadores de Comparación
             == : Igualdad
             != : Diferente
             >  : Mayor 
             <  : Menor 
             >= : Mayor Igual
             <= : Menor Igual  
             */

            /*Operadores Lógicos
             
             && : AND (Y)
             || : OR (O)
              ! : Negación
             
             */

            //4.Suma de dos números

            int numero1 = 5;
            int numero2 = 8;
            int resultadoSuma;

            resultadoSuma = numero1 + numero2;
            Console.WriteLine("---------4.Suma de dos números--------");
            Console.WriteLine("La suma de los número es: " + resultadoSuma);

            //5. Condicionales


            int numeroCondicional1 = 10;
            int numeroCondiconal2 = 15;


            if (numeroCondicional1 > numeroCondiconal2)
            {
                Console.WriteLine("---------5.Condicionales--------");
                Console.WriteLine("El número: " + numeroCondicional1 + " Es mayor que: " + numeroCondiconal2);
            }
            else {
                Console.WriteLine("---------5.Condicionales--------");
                Console.WriteLine("El número: " + numeroCondicional1 + " NO Es mayor que: " + numeroCondiconal2);
            }

            //5.1. Condicionales Anidadas

            Console.WriteLine("---------5.1. Condicionales ANIDADAS--------");
            int horario = 12;

            if (horario == 8)
            {
                Console.WriteLine("Estoy Desayunando");
            }
            else if (horario == 12)
            {
                Console.WriteLine("Estoy Almorzando");
            }
            else if (horario == 20)
            {
                Console.WriteLine("Estoy Cenando");
            }

            else {
                Console.WriteLine("Estoy Trabajando");
            }


            //6. SwitchCase

            Console.WriteLine("---------6. SwitchCase--------");

            int dia = 6;

            switch (dia) {

                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Dia no válido");
                    break;


            }

            Console.WriteLine("---------7. Bucle While--------");

            /*While*/
            int contadorWhile = 0;

            while (contadorWhile < 5) {

                Console.WriteLine(contadorWhile);
                contadorWhile++;
            }

            /*Do While*/

            int contadorDoWhile = 0;
            Console.WriteLine("---------7.1 Bucle Do While--------");
            do {
                Console.WriteLine(contadorDoWhile);
                contadorDoWhile++;
            }
            while (contadorDoWhile < 5);

            Console.WriteLine("---------8. Bucle For--------");

            for (int contadorFor = 0; contadorFor < 5; contadorFor++) {

                Console.WriteLine(contadorFor);
            }

            Console.WriteLine("---------9.1. Métodos Sin Parámetro--------");
            MetodoHolaAtodos();
            Console.WriteLine("---------9.2. Métodos Con Parámetros--------");
            MetodoSaludoParametro("Ricardo");

            Console.WriteLine("---------9.3. Función Sin Parámetros--------");
            Console.WriteLine(funcion());
            Console.WriteLine("---------9.4. Función Con Parámetros--------");
            Console.WriteLine(funcionParametrosSuma(15,20));
            Console.WriteLine("---------10. Ingreso de valores por teclado--------");
            ingresoPorTeclado();

            Console.WriteLine("---------11. PROYECTO FINAL--------");
            proyectoFinalConsola();

        }





        //9. METODOS
        static public void MetodoHolaAtodos() {

            Console.WriteLine("---------9.Métodos--------");
            Console.WriteLine("Hola a todos, esto es un método");
        }

        //9.1. Metodo con parámetros
        static public void MetodoSaludoParametro (String nombres){

            
            Console.WriteLine("Hola: "+ nombres + " Bienvenido");

        }

        //Funcion sin parámetros
        static public string funcion() {
            string nombre = "Pedro";
            return nombre;
        }
        //Funcion con parámetros
        static public int funcionParametrosSuma(int numero1, int numero2) {

            return numero1 + numero2;
        }

        static public void ingresoPorTeclado() {
            int edad;

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su edad es: " + edad);

        }

        static public void proyectoFinalConsola() {

            String nombre;
            int nota1;
            int nota2;
            int nota3;
            int promedio;

            //Inserción de Datos
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su primera Nota");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su segunda Nota");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su tercera Nota");
            nota3 = Convert.ToInt32(Console.ReadLine());

            //Cálculo del Promedio
            promedio = (nota1 + nota2 + nota3) / 3;

            //Comparacion de Promedio

            if (promedio <= 10)
            {

                Console.WriteLine("Su nota primera fue: " + nota1);
                Console.WriteLine("Su nota segunda fue: " + nota2);
                Console.WriteLine("Su nota tercera fue: " + nota3);
                Console.WriteLine("Su promedio es: " + promedio);
                Console.WriteLine("*****************************");
                Console.WriteLine("Usted desaprobó :(");

            }
            else if (promedio >= 11 && promedio <= 15)
            {

                Console.WriteLine("Su nota primera fue: " + nota1);
                Console.WriteLine("Su nota segunda fue: " + nota2);
                Console.WriteLine("Su nota tercera fue: " + nota3);
                Console.WriteLine("Su promedio es: " + promedio);
                Console.WriteLine("*****************************");
                Console.WriteLine("Usted sacó una nota decente :| ");

            }
            else if (promedio >= 16 && promedio <= 20)
            {

                Console.WriteLine("Su nota primera fue: " + nota1);
                Console.WriteLine("Su nota segunda fue: " + nota2);
                Console.WriteLine("Su nota tercera fue: " + nota3);
                Console.WriteLine("Su promedio es: " + promedio);
                Console.WriteLine("*****************************");
                Console.WriteLine("Usted sacó una nota EXCELENTE, FELICITACIONES :) ");

            }
            else {

                Console.WriteLine("Las notas ingresadas no son válidas");
            }




        }
    }
}
