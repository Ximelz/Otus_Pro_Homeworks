using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    public interface IGetVarFromPerson
    {
        /// <summary>
        /// Получение числа из диалога с пользователем.
        /// </summary>
        /// <returns>Введенное пользователем число.</returns>
        int GetNumb(string message);

        /// <summary>
        /// Получение типа ввода числа.
        /// </summary>
        /// <returns>Тип ввода числа от пользователя.</returns>
        UIDialogType GetType();
    }
}
