using System;

namespace EP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Bienvenido al Menu de novedades de C#8 digite el numero de opcion del cual quiere ver su funcion");
            Console.WriteLine("[1] Nullable reference types");
            Console.WriteLine("[2] Async streams");
            Console.WriteLine("[3] Range and Index");
            Console.WriteLine("[4] Recursive Patterns");
            Console.WriteLine("[5] Switch expressions");
            Console.WriteLine("[6] Implicit constructors");
            Console.WriteLine("[7] Using declaration");
            Console.WriteLine("[8] Default interfaces\n");
            
            op=int.Parse(args[0]);

            switch(op)
            {
                case 1: N1(); break;
                case 2: N2(); break;
                case 3: N3(); break;
                case 4: N4(); break;
                case 5: N5(); break;
                case 6: N6(); break;
                case 7: N7(); break;
                case 8: N8(); break;

            }
            

            static void N1()
            {
                Console.WriteLine("\nUno de los grandes problemas de las aplicaciones de hoy en día es el control de cuando algo es null");
                Console.WriteLine("o puede ser null por lo que C#8 nos va a dar la posibilidad de no permitir tener valores null en nuestro código,");
                Console.WriteLine("para ello tenemos que activar debajo de los using la expresión #nulllable enable");
                Console.WriteLine("Ejemplo del codigo:");

                Console.WriteLine("\nint? entero = null;\n");
                Console.WriteLine("Si añadimos un símbolo de interrogación después de declarar el tipo, este será nullable.");

                
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

            }
            
            static void N2()
            {
                Console.WriteLine("Todo el mundo conoce los streams tenemos un método que nos devuelve un IEnumerable<T> a partir de ahora podemos devolver un IAsyncEnumerable<T>,");
                Console.WriteLine(" por supuesto este nuevo tipo tiene todas las características de Async por lo que para operar con el tenemos que indicar todas las keywords necesarias, como await o Task.\n");
                Console.WriteLine("Ejemplo del codigo:");
                Console.WriteLine("\nasync IAsyncEnumerable<int> GetManyResultsAsync(){");
                Console.WriteLine("     int result = -1;");
                Console.WriteLine("     do {    result = await GetOneAsync();");
                Console.WriteLine("             yield return result;");
                Console.WriteLine("         } while (result > 0);");
                Console.WriteLine("}");

                Console.WriteLine("\nLa propuesta de añadir un tipo IEnumerable que sea asíncrono al iterar es algo que viene fenomenal al lenguaje.");
                Console.WriteLine("La idea es que se pueda parar de materializar resultados en cualquier momento, incluidas las llamadas asíncronas.\n");
            }

            static void N3()
            {
                Console.WriteLine("La idea detrás de los rangos y los índices es copiar ciertas funcionalidades de otros lenguajes de programación. ");
                Console.WriteLine("Se centran en interactuar con listas o arrays de una forma más sencilla.\n");
                Console.WriteLine("Ejemplo de codigo:");
                Console.WriteLine("\nstring[] nombres = { "+"nombre1"+", " +"nombre2"+","+ "nombre3"+"," +"nombre4"+","+ "nombre5"+"}"+";");
                Console.WriteLine("foreach(string nombre in nombres[1..3]){");
                Console.WriteLine("}\n");
                Console.WriteLine("En este caso iterara del primer elemento al tercero.");
                Console.WriteLine("Otro ejemplo es el caracter ^ que indicara por el final por lo que si indicamos nombres[3...^1] iterara desde el tercero hasta el penúltimo.\n");
            }

            static void N4()
            {
                Console.WriteLine("\nDicho de otro modo, patrones dentro de patrones, y aqui introducimos tambien a la nueva sentencia swich, donde podemos pasar mas de un parámetro como podemos ver a continuacion.");
                Console.WriteLine("\nAntes\nswitch (p.firstname, p.middlename, p.lastname){");
                Console.WriteLine("     case(string f, string m, string l):");
                Console.WriteLine("     return $”{f}, {m[0]} {l}”;\n");
                Console.WriteLine("Ahora\nreturn (p.firstname, p.middlename, p.lastname) switch{");
                Console.WriteLine("     (string f, string m, string l) => $”{f}, {m[0]} {l}”;\n");
              
            }

            static void N5()
            {
                Console.WriteLine("\nEl nuevo bloque switch nos va a permitir prescindir de las palabras clave case y default, de tal forma que resumiremos cada opción como una condición y el cuerpo de una función inline:");
                Console.WriteLine("\nreturn o switch{");
                Console.WriteLine("Point p when p.X == 0 && p.Y == 0  => "+"origin"+",");
                Console.WriteLine("_                                  => "+"unknown");
                Console.WriteLine("el _ sustituye al default");
                Console.WriteLine("");
                Console.WriteLine("");
            }

            static void N6()
            {
                Console.WriteLine("\nLa idea es inferir el tipo del constructor y así ahorrarnos tener que escribirlo veintisiete veces cuando estemos programando:\n");
                Console.WriteLine("Person[] people =");
                Console.WriteLine("{");
                Console.WriteLine("new ("+"Elena"+","+"Nito"+","+"del Bosque"+")");
                Console.WriteLine("};\n");
                Console.WriteLine("después de cada new pondríamos Person");
                Console.WriteLine("");
            }

            static void N7()
            {
                Console.WriteLine("\nEn C# 8.0, ya no tendrán que hacer bloques. Al poner un using, cuando se acabe el ámbito (al finalizar una función o cualquier bloque de código) de “disposeará”:");
                Console.WriteLine("\npublic void Patata()");
                Console.WriteLine("{");
                Console.WriteLine("using var disposable = CreateDisposable(args);");
                Console.WriteLine("}");
                Console.WriteLine("");
                Console.WriteLine("");
            }

            static void N8()
            {
                Console.WriteLine("Microsoft, porfavor ya implememnta multiherencia, a nadie le gustan las interfaces :p");
                
            }

        }
    }
}
