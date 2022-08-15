using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
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
            Console.WriteLine("Data is being saved in the folder!\n" + path + "\n");
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
            Console.WriteLine("Data is being saved in the repository!\n" + path + "\n");
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
            Console.WriteLine("Data is being saved in the file!\n" + path + "\n");
        }
    }
}
