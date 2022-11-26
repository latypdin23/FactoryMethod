using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26._11._2022
{
    /// <summary>
    /// Продукт банковской карты - интерфейс с набором методов
    /// </summary>
    public interface CreditCard
    {
        /// <summary>
        /// Получает тип карты
        /// </summary>
        /// <returns></returns>
        string GetCardType();
        /// <summary>
        /// Получает лимит карты
        /// </summary>
        /// <returns></returns>
        int GetCreditLimit();
        /// <summary>
        /// Получает обслуживание карты
        /// </summary>
        /// <returns></returns>
        int GetAnnualCharge();
    }
}
