using System;

//                             Dependency Inversion
//                                      |
//                                      |
//                             Inversion of Control
//                              /                \
//                             /                  \
//                            /                    \
//                  Dependency Injection     Service Locator           



//namespace App
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            IVehicle vehicle = new Car();
//            //IVehicle vehicle = new Truck();

//            VehicleController vehicleController = new VehicleController(vehicle);
//            vehicle.Accelerate();
//            vehicle.Brake();

//            Console.Read();
//        }
//    }

//    public class Car : IVehicle
//    {

//        #region IVehicle Members

//        public void Accelerate()
//        {
//            Console.WriteLine("Car accelerates...");
//        }

//        public void Brake()
//        {
//            Console.WriteLine("Car stopped.");
//        }

//        #endregion
//    }

//    public class Truck : IVehicle
//    {
//        #region IVehicle Members

//        public void Accelerate()
//        {
//            Console.WriteLine("Truck accelerates...");
//        }

//        public void Brake()
//        {
//            Console.WriteLine("Truck stopped.");
//        }

//        #endregion
//    }

//    public interface IVehicle
//    {
//        void Accelerate();
//        void Brake();
//    }

//    public class VehicleController
//    {
//        IVehicle m_Vehicle;

//        public VehicleController(IVehicle vehicle)
//        {
//            this.m_Vehicle = vehicle;
//        }

//        public void Accelerate()
//        {
//            m_Vehicle.Accelerate();
//        }

//        public void Brake()
//        {
//            m_Vehicle.Brake();
//        }
//    }
//}



namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            ISavePlace place1 = new DataSaver(new Folder(@"C:\Users\dmitrii.romanenco\Downloads\Hometask 20"));
            ISavePlace place2 = new DataSaver(new TxtFile(@"~\file.txt"));
            ISavePlace place3 = new DataSaver(new Repository(@"https:\\github.com\Dimitris-Kidis\Hometask 20"));

            place1.GetPlace();
            Console.WriteLine("------------------------------");
            place2.GetPlace();
            Console.WriteLine("------------------------------");
            place3.GetPlace();


            CustomerBusinessLogic customerBusinessLogic = new CustomerBusinessLogic();

        }
    }

    public interface ISavePlace
    {
        void GetPlace();
    }

    public class DataSaver : ISavePlace
    {
        ISavePlace path;

        public DataSaver(ISavePlace path)
        {
            this.path = path;
        }

        public void GetPlace()
        {
            path.GetPlace();
        }
    }



    public class Folder : ISavePlace
    {

        private String path;
        public Folder(String path)
        {
            this.path = path;
        }

        
        public void GetPlace()
        {
            Console.WriteLine("Data is being saved in the folder!\n" + path);
        }
    }



    public class Repository : ISavePlace
    {

        private String path;
        public Repository(String path)
        {
            this.path = path;
        }

        public void GetPlace()
        {
            Console.WriteLine("Data is being saved in the repository!\n" + path);
        }
    }


    public class TxtFile : ISavePlace
    {
        private String path;
        public TxtFile(String path)
        {
            this.path = path;
        }


        public void GetPlace()
        {
            Console.WriteLine("Data is being saved in the file!\n" + path);
        }
    }
}