using System;

namespace Interfaces
{
    // Definimos una interfaz para un servicio de impresión
    public interface IPrintService
    {
        void Print(string message);

        
    }

    public interface InterfazProcesadora<T>
    {
        void ProcesarModelo(T model);
    }

    // Creamos una clase que implementa la interfaz
    public class ConsolePrintService : IPrintService
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        public void Imprimir()
        {

        }
    }
    public interface IModelProcessor<T>
    {
        void ProcessModel(T model);
    }

    public class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
    }

    public class CarProcessor : IModelProcessor<Car>
    {
        public void ProcessModel(Car car)
        {
            
            Console.WriteLine($"Procesando un carro: {car.Manufacturer} {car.Model}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de la clase ConsolePrintService
            IPrintService printService = new ConsolePrintService();

            // Usamos la interfaz para imprimir un mensaje
            printService.Print("Hola, Mundo!");

            IModelProcessor<Car> carProcessor = new CarProcessor();

            Car myCar = new Car
            {
                Model = "Sedan",
                Manufacturer = "Toyota"
            };

            carProcessor.ProcessModel(myCar);

        }
    }
}
