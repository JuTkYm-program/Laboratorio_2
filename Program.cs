class Sistema 
{
static void Main()
 {
     
    System.Console.WriteLine("=== SISTEMA DE SOPORTE ACADÉMICO ===");

     
     
      
      System.Console.WriteLine("\n--- Iniciando Registro de Solicitud  ---");
        string codigo = "", nombre = "", tipoConsulta = "", descripcion = "";

      
      
         System.Console.WriteLine("Ingrese Código de Estudiante (mínimo 6 caracteres): ");
         codigo = Console.ReadLine();
      

         System.Console.WriteLine("Ingrese Nombre del Estudiante: ");
         nombre = Console.ReadLine();

           
    do
        {
            
        
         System.Console.WriteLine("Ingrese Tipo de Consulta: ");
         tipoConsulta = Console.ReadLine().ToLower();
        }while (!ValidarTipoConsulta(tipoConsulta));

         System.Console.WriteLine("Ingrese Descripción breve: ");
         descripcion = Console.ReadLine();
     
 }
 static bool ValidarTipoConsulta(string tipo)
    {
        if (tipo == "matrícula" || tipo == "pagos" || tipo == "constancia" || tipo == "plataforma" || tipo == "otro")
        {
            return true;
        }
        Console.WriteLine("[ERROR] Tipo de consulta incorrecto. Revise el menú.");
        return false;
    }

}
 