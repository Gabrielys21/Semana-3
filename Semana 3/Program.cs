// Solicitar al usuario que digite tres numeros y de ellos calcular el mayor e imprimirlo en pantalla
try
{
    Console.WriteLine("Digite el Primer valor: ");
    int Num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite el Segundo valor: ");
    int Num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite el Tercer valor: ");
    int Num3 = int.Parse(Console.ReadLine());

    if (Num1 > Num3)
    {
        Console.WriteLine($"El número mayor es {Num1}");
    }
    else if (Num3 > Num2)
    {
        Console.WriteLine($"El número mayor es {Num3}");
    }
    else if (Num2 > Num1)
    {
        Console.WriteLine($"El número mayor es {Num2}");
    }
    else
    {
        Console.WriteLine($"Todos los números son iguales.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: El valor digitado no es un número válido.");
}
catch (OverflowException)
{
    Console.WriteLine("Error: El número ingresado es demasiado grande o demasiado pequeño.");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}
// Validar edad para entrar al club
try
{
    Console.WriteLine("Digite su edad");
    int edad = int.Parse(Console.ReadLine());
    if (edad >= 18 && edad <= 35)
    {
        Console.WriteLine("Bienvenido al Club Campeon");
    }
    else if (edad >= 36)
    {
        Console.WriteLine("Bienvenido al club VIP Señor");
    }
    else
    {
        Console.WriteLine("No tienes la edad necesaria para entrar al Club");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: El valor digitado, no es un numero valido...");
}
catch (OverflowException)
{
    Console.WriteLine("Error: El numero es demasiado grande o demasiado pequeño...");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}
// Calcular el precio fianl del producto
try
{
    Console.WriteLine("Digite el Precio del Producto por favor: ");
    double precio = double.Parse(Console.ReadLine());
    if (precio > 100)
    {
        double descuento = precio * 0.10;
        double total = precio - descuento;
        Console.WriteLine($"El precio es de: {total}");
    }
    else
    {
        Console.WriteLine($"El precio es {precio}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: El valor digitado no es un numero valido");
}
catch (OverflowException)
{
    Console.WriteLine("Error: El numero digitado es demasiado grande o demasiado pequeño");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}
// Validar usuario y contraseña
try
{
    Console.WriteLine("Digite su usuario por favor: ");
    string usuario = Console.ReadLine();
    string angel = "Angel";

    Console.WriteLine("Digite su contraseña por favor: ");
    int password = int.Parse(Console.ReadLine());
    int contra = 4094;

    if (usuario != null && usuario.Equals(angel) && password == contra)
    {
        Console.WriteLine("Bienvenido a Vortech Angel Chavarria");
    }
    else
    {
        throw new Exception("Credenciales incorrectas.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: La contraseña digitada no es un número válido.");
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
// Determinar si un numero es par o impar
try
{
    Console.WriteLine("Digite un numero a verificar por favor: ");
    int Numero = int.Parse(Console.ReadLine());
    if (Numero % 2 == 0)
    {
        Console.WriteLine("El numero es par.");
    }
    else
    {
        Console.WriteLine("El numero es impar.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: El valor digitado no es un numero valido.");
}
catch (OverflowException)
{
    Console.WriteLine("El valor digitado es demasiado grande o demasiado pequeño.");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}
// Mostrar un mensaje de Aprovacion o Rechazo de Prestamo
try
{
    Console.WriteLine("Digite el monto del prestamo a adquirir por favor: ");
    double vprestamo = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite su edad por favor: ");
    int edadc = int.Parse(Console.ReadLine());

    if (vprestamo < 5000 || edadc > 60)
    {
        Console.WriteLine("Su prestamo ha sido aprovado con exito.");
    }
    else
    {
        Console.WriteLine("Lo sentimos, su prestamo no ha sido aprovado.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: El valor digitado no es un numero valido...");
}
catch (OverflowException)
{
    Console.WriteLine("Error: El valor digitado es demasiado grande o demasiado pequeño.");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}
// Calcular Area de una figura geometrica
Console.WriteLine("Digite la figura geometrica de la cual calcular su area (Triangulo,Cuadrado o Circulo)");
string figura = Console.ReadLine().ToLower();

double area = 0;
try
{
    if (figura == "triangulo")
    {
        Console.WriteLine("Digite la base del triangulo por favor: ");
        double bastriangulo = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite la altura del tringulo por favor: ");
        double altriangulo = double.Parse(Console.ReadLine());
        area = bastriangulo * altriangulo;
    }
    else if (figura == "cuadrado")
    {
        Console.WriteLine("Digite el lado del cuadrado por favor: ");
        double ladocuadrado = double.Parse(Console.ReadLine());
        area = ladocuadrado * ladocuadrado;
    }
    else if (figura == "circulo")
    {
        Console.WriteLine("Digite el radio del circulo por favor: ");
        double radio = double.Parse(Console.ReadLine());
        area = Math.PI * radio * radio;
    }
    else
    {
        Console.WriteLine("Figura no valida, por favor intente de nuevo.");
    }
    Console.WriteLine($"El area del figura {figura} es: {area} ");
}
catch (FormatException)
{
    Console.WriteLine("Error: El valor digitado no es un numero valido.");
}
catch (OverflowException)
{
    Console.WriteLine("Error: El valor digitado es muy grande o muy pequeño");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}

// Convertir a minúsculas para hacer la comparación más flexible
try
{
    Console.WriteLine("Escriba un número del 1 al 5 en letra:");
    string numletra = Console.ReadLine().ToLower(); // Convertir a minúsculas para hacer la comparación más flexible

    int numdigito;

    switch (numletra)
    {
        case "uno":
            numdigito = 1;
            break;
        case "dos":
            numdigito = 2;
            break;
        case "tres":
            numdigito = 3;
            break;
        case "cuatro":
            numdigito = 4;
            break;
        case "cinco":
            numdigito = 5;
            break;
        default:
            Console.WriteLine("Número no válido.");
            return;
    }

    Console.WriteLine($"El número en dígito es: {numdigito}");
}
catch (FormatException)
{
    Console.WriteLine("Error: Debe ingresar un número válido.");
}
catch (OverflowException)
{
    Console.WriteLine("Error: El número digitado está fuera del rango válido.");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error: {ex.Message}");
}    // 
try
{
    Console.WriteLine("Digite un número del 1 al 7:");
    int numdia = Convert.ToInt32(Console.ReadLine());

    string diaSemana;

    switch (numdia)
    {
        case 1:
            diaSemana = "Lunes";
            break;
        case 2:
            diaSemana = "Martes";
            break;
        case 3:
            diaSemana = "Miércoles";
            break;
        case 4:
            diaSemana = "Jueves";
            break;
        case 5:
            diaSemana = "Viernes";
            break;
        case 6:
            diaSemana = "Sábado";
            break;
        case 7:
            diaSemana = "Domingo";
            break;
        default:
            Console.WriteLine("Número no válido. Debe estar entre 1 y 7.");
            return;
    }

    Console.WriteLine($"El día de la semana correspondiente al número {numdia} es: {diaSemana}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}
// 
try
{
    Console.WriteLine("Escriba el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
    string tiposervicio = Console.ReadLine().ToLower();

    double importepago;

    switch (tiposervicio)
    {
        case "lavado de auto":
            importepago = 20.00; // Precio del lavado de auto
            break;
        case "cambio de aceite":
            importepago = 50.00; // Precio del cambio de aceite
            break;
        case "revisión mecánica":
            importepago = 80.00; // Precio de la revisión mecánica
            break;
        default:
            Console.WriteLine("Tipo de servicio no válido.");
            return;
    }

    Console.WriteLine($"El importe a pagar por el servicio de {tiposervicio} es: ${importepago}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}
//
try
{
    Console.WriteLine("Escriba su idioma preferido (español, inglés, francés):");
    string idioma = Console.ReadLine().ToLower();

    string mensajebienvenida;

    switch (idioma)
    {
        case "español":
            mensajebienvenida = "¡Bienvenido!";
            break;
        case "inglés":
            mensajebienvenida = "Welcome!";
            break;
        case "francés":
            mensajebienvenida = "Bienvenue!";
            break;
        default:
            Console.WriteLine("Idioma no válido.");
            return;
    }

    Console.WriteLine($"Mensaje de bienvenida en {idioma}: {mensajebienvenida}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}
// Solicitar al usuario la calificación de un examen y mostrar su desempeño, modifica el programa:
try
{
    Console.WriteLine("Escriba su calificación del examen:");
    double calificacion = Convert.ToDouble(Console.ReadLine());

    string mensaje;

    if (calificacion < 0 || calificacion > 100)
    {
        Console.WriteLine("Calificación no válida. Debe estar entre 0 y 100.");
        return;
    }

    switch ((int)calificacion)
    {
        case int n when (n >= 90 && n <= 100):
            mensaje = "Sobresaliente";
            break;
        case int n when (n >= 80 && n <= 89):
            mensaje = "Notable";
            break;
        case int n when (n >= 70 && n <= 79):
            mensaje = "Aprobatoria";
            break;
        case int n when (n >= 60 && n <= 69):
            mensaje = "No aprobatoria";
            break;
        default:
            mensaje = "Desempeño no definido";
            break;
    }

    Console.WriteLine($"Desempeño del estudiante: {mensaje}");
}
catch (FormatException)
{
    Console.WriteLine("Error: Formato de calificación incorrecto. Debe ser un número.");
}
catch (OverflowException)
{
    Console.WriteLine("Error: La calificación ingresada está fuera del rango permitido.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: inesperadoz: {ex.Message}");
}
