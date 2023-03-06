using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Actions.IActions
{
    /// <summary>
    /// Коммуникация с пользователем через консоль
    /// </summary>
    public interface IConsoleCommunication
    {
        /// <summary>
        /// Функция получения от пользователя числа в формате double
        /// </summary>
        /// <param name="messageToUser">Сообщение пользователю </param>
        /// <returns></returns>
        double? GetSomeDoubleValueFromUser(string messageToUser);
    }
}
