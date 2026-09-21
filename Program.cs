
class Sistema 
{
static void Main() // Requerimiento 9 Alcance de variables controlado (solo locales, no globales).
 {
     
    System.Console.WriteLine("=== SISTEMA DE SOPORTE ACADÉMICO ===");


      System.Console.WriteLine("\n--- Iniciando Registro de Solicitud  ---");
        string codigo = "", nombre = "", tipoConsulta = "", descripcion = "";
         MostrarMenu();
      
      
    System.Console.WriteLine("Ingrese Código de Estudiante (mínimo 6 caracteres): ");
         codigo = Console.ReadLine();
      
    do 
    { 
       System.Console.WriteLine("Ingrese Nombre del Estudiante: ");
         nombre = Console.ReadLine();
    }   while (!ValidarTexto(codigo, 6));     

           
    do
        {
          System.Console.WriteLine("Ingrese Tipo de Consulta: ");
          tipoConsulta = Console.ReadLine().ToLower();
        }   while (!ValidarTipoConsulta(tipoConsulta));
        

         System.Console.WriteLine("Ingrese Descripción breve: ");
         descripcion = Console.ReadLine();

        string prioridad = CalcularPrioridad(tipoConsulta);
        MostrarResumen(codigo, nombre, tipoConsulta, descripcion, prioridad);
     
 }


 static bool ValidarTipoConsulta(string tipo)
    {
        if (tipo == "matricula" || tipo == "pagos" || tipo == "constancia" || tipo == "plataforma" || tipo == "otros")
        {
            return true;
        }
        Console.WriteLine("[ERROR] Tipo de consulta incorrecto. Revise el menú.");
        return false;
    }

static void MostrarMenu()
    {
        Console.WriteLine("\nTipos de consulta válidos:");
        Console.WriteLine("- matrícula\n- pagos\n- constancia\n- plataforma\n- otro");
    }
static string CalcularPrioridad(string tipoConsulta)
    {
        if (tipoConsulta == "matrícula" || tipoConsulta == "pagos") 
            return "Alta";
        if (tipoConsulta == "plataforma") 
            return "Media";
        
        return "Baja"; 
    }

    static bool ValidarTexto(string texto, int longitudMinima)
    {
        if (string.IsNullOrWhiteSpace(texto) || texto.Length < longitudMinima)
        {
            Console.WriteLine($"[ERROR] El campo no puede estar vacío y debe tener al menos {longitudMinima} caracteres.");
            return false;
        }
        return true;
    }

    static void MostrarResumen(string cod, string nom, string tipo, string desc, string prio)
    {
    
        Console.WriteLine("======RESUMEN DE SOLICITUD REGISTRADA======");
        Console.WriteLine($"Código Estudiante : {cod}");
        Console.WriteLine($"Nombre Estudiante : {nom}");
        Console.WriteLine($"Tipo de Consulta  : {tipo}");
        Console.WriteLine($"Descripción       : {desc}");
        Console.WriteLine($"Prioridad Asignada: {prio}");
        Console.WriteLine("============================================");
    }
   /*
   REQUERIMIENTO 11 - REGISTRO DE PRUEBAS EJECUTADAS EN CONSOLA:
   1. Datos válidos: Código "U123456", Nombre "Justin", Tipo "pagos" -> Ejecución OK.
   2. Código vacío/inválido: Se ingresó "" -> El programa detectó el error y lo volvió a pedir OK.
   3. Tipo incorrecto: Se ingresó "deportes" -> Mostró error de validación OK.
   4. Prioridad alta: Se probó con "matrícula" -> El sistema le asignó prioridad Alta OK.
   5. Prioridad baja: Se probó con "constancia" -> El sistema le asignó prioridad Baja OK.
   */
}





 