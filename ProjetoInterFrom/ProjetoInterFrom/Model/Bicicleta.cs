using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class Bicicleta
    {
        public string id = "11";
        Marca marca = new Marca();
        Cor cor = new Cor();
        Modelo modelo = new Modelo();
        

        public string returnId()
        {
            return id;
        }
    }
}
