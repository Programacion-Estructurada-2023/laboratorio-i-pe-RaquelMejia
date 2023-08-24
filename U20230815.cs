using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {   
            //Declaracion de variable de texto desde consola
            string? departamento;
            string? municipio;
            string? ciudad;

            //Declaracion de variable de texto desde codigo
            string?  coloniaDondevive = " Mercedes Umaña ";
            string? colorcasa = "Rosa";

            //Declaracion variable entera desde consola
            int tiempoRecidencia;
            int edadActual;

            //Declaracion de variable de DateTime
            DateTime fechaActual = DateTime.Now;
            DateTime fechaNacimiento = new DateTime(1998,5,8);


            //Obtener los datos de la terminal
            Console.WriteLine("Ingrese el departamento donde vive: ");
            departamento = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese el municipio donde vive: ");
            municipio= Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese la ciudad donde vive: ");
            ciudad= Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese cuantos años tiene  de vivir en su residencia : ");
            tiempoRecidencia= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad actual: ");
            edadActual= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Asignar Funciones
            //Funcion para comparar cadena
            bool cadenaComparativa = departamento == municipio;

            //Funcion de concatenar texto
            string? cadenaConcatenada = departamento + "," + municipio + "," + coloniaDondevive;

            //Funcion Mayuscula
            string? FuncionMayuscula = ciudad.ToUpper();
            
            //Funcion de limpiado de cadena
            string? FuncionLimpiado = coloniaDondevive.Trim();

            //Funcion de longitud de cadena
            int llongitudCadena1 = coloniaDondevive.Length;
            int llongitudCadena2 = colorcasa.Length;

            //Funcion de fecha formateada
            string? fechaFormateada = fechaActual.ToString("dd/MM/yyyy");

            //Funcion adicionar 2 semanas
            DateTime fecha_2semanas = fechaNacimiento.AddDays(14);

            //Funcion Comparar fechas
            bool fechasiguales = fechaActual == fechaNacimiento;
            bool fechaActua1 = fechaActual < fechaNacimiento;
            bool fechaNacimiento1 = fechaActual  > fechaNacimiento;

            //Impresion  de valores ingresados de las variables de texto
            Console.WriteLine("***********************************************");
            Console.WriteLine("Información Capturada y Asignada");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Departamento: " + departamento);
            Console.WriteLine("Municipio: " + municipio);
            Console.WriteLine("Ciudad: " + ciudad);
            Console.WriteLine("Años de vivir en recidencia actual: " + tiempoRecidencia);
            Console.WriteLine("Edad actual: " + edadActual);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Lugar donde vive: " + coloniaDondevive);
            Console.WriteLine("Color de casa: " + colorcasa);
            Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento);
            Console.WriteLine("Fecha actual: " + fechaActual);
            Console.WriteLine("");

            //Impresion de valores de las variables de texto
            Console.WriteLine("******************************************************");
            Console.WriteLine("Impresion de valores de las variales de texto: ");
            Console.WriteLine("Departamento: " + departamento);
            Console.WriteLine("Municipio: " + municipio);
            Console.WriteLine("Ciudad: " + ciudad);
            Console.WriteLine("Colonia: " + coloniaDondevive);
            Console.WriteLine("Color de casa: " + colorcasa);
            Console.WriteLine("");

            //Impresion de valores de las variables enteras
            Console.WriteLine("********************************************************");
            Console.WriteLine("Impresion de valores de las variales enteras: ");
            Console.WriteLine("Años de vivir en recidencia actual: " + tiempoRecidencia);
            Console.WriteLine("Edad actual: " + edadActual);
            Console.WriteLine("");

            //Impresion de valores ingresados en la comparacion de cadena
            Console.WriteLine("***************************************************");
            Console.WriteLine("Comparación de cadena entre Departamento y municipio: " + cadenaComparativa);
            Console.WriteLine("");

            //Impresion de funciones mayuscula
            Console.WriteLine("********************************************************");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Funcion Mayúscula: " + FuncionMayuscula);
            Console.WriteLine("Concatenar Cadena : "+ cadenaConcatenada);
            Console.WriteLine("Longitud de cadena: " +" (" + coloniaDondevive + ") "+ llongitudCadena1);
            Console.WriteLine("Longitud de cadena: " + "("+ colorcasa + ")" + llongitudCadena2);


            //Impresion de valores en la funciones de fecha
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Fecha formateada: " + fechaFormateada);
            Console.WriteLine("Fechas iguales: " + fechasiguales);
            Console.WriteLine("Fecha actual mayor a fecha de nacimiento: " + fechaNacimiento1);
            Console.WriteLine("Fecha actual menor a fecha de nacimiento: " + fechaActua1);
            Console.WriteLine("Fecha de nacimiento con 2 semanas sumadas: " + fecha_2semanas);
            Console.WriteLine("");
            Console.WriteLine("*************************************************************");


            //AUTOEVALUACION 8.5
        }
    }
}
