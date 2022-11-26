using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26._11._2022
{
    /// <summary>
    /// Базовый класс пирога.
    /// </summary>
    public abstract class PieBase
    {
        /// <summary>
        /// Приготовить пирог.
        /// </summary>
        public void Cook()
        {
            CreateDough();
            CreateFilling();
            Fry();
        }

        /// <summary>
        /// Замешать тесто.
        /// </summary>
        protected abstract void CreateDough();

        /// <summary>
        /// Приготовить начинку.
        /// </summary>
        protected abstract void CreateFilling();

        /// <summary>
        /// Запечь пирог в духовке.
        /// </summary>
        protected abstract void Fry();
    }
}
