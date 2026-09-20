class Sisteam
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

         System.Console.WriteLine("Ingrese Tipo de Consulta: ");
         tipoConsulta = Console.ReadLine().ToLower();

         System.Console.WriteLine("Ingrese Descripción breve: ");
         descripcion = Console.ReadLine();
      
    
     
 }

}
 