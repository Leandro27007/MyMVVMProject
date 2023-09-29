using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVMProject.Model
{
    public class HelloWorldModel
    {

        private List<string> _repositoryData;

        public string ImportantInfo
        {
            get
            {
                return ConcatenateData(_repositoryData);
            }
            set
            {

            }
        }

        private string ConcatenateData(List<string> dataList)
        {
            string cadena = dataList.ElementAt(0) + ", " + dataList.ElementAt(1) + "!";

            return cadena;
        }


        private List<string> GetInfo()
        {

            _repositoryData = new List<string>() 
            {
                "Hello",
                "World \t Leandro Batista"
            };

            return _repositoryData;

        }


        public HelloWorldModel()
        {
           _repositoryData = GetInfo();
        }

    }
}
