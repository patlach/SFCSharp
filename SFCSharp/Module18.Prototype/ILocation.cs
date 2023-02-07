using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Prototype
{
    interface ILocation
    {
        /// Метод для клонирования
        ILocation Clone();

        // Метод для получения информации об объекте
        void GetInfo();
    }
}
