using Azure.Messaging.EventGrid;
namespace ConsoleEventgridPublisher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventGridPublisherClient client = new EventGridPublisherClient(
                new Uri(""),
                new Azure.AzureKeyCredential(""));
        
           EventGridEvent firstEvent = new EventGridEvent(
               subject: "Nuevo Empleado Manuel Mendez",
               eventType: "Nuevo Empleado",
               dataVersion: "1.0",
               data: new
               {
                  Apellido = "Mendez",
                  Nombre = "Manuel"

               }
               );

            EventGridEvent SecondEvent = new EventGridEvent(
               subject: "Nuevo Empleado Maria Lopez",
               eventType: "Nuevo Empleado",
               dataVersion: "1.0",
               data: new
               {
                   Apellido = "Lopez",
                   Nombre = "Maria"

               }
               );

            client.SendEvent( firstEvent );
            client.SendEvent( SecondEvent );
            Console.WriteLine("Eventos enviados");
        }


    }
}
