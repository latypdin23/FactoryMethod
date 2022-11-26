using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26._11._2022
{
    /// <summary>
    /// Фабрика для создания банковских карт, содержит фабричный метод
    /// </summary>
    public abstract class CreditCardFactory
    {
        /// <summary>
        /// фабричныый метод, реализация в конкретной фабрике
        /// </summary>
        /// <returns></returns>
        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }

}
