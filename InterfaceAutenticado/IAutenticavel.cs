using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticado
{
    public interface IAutenticavel

    {   //assinatura de metodo
        bool Autenticar(int senha);
    }
}