namespace Homework_5
{
    public interface ISendMsgForPerson
    {
        /// <summary>
        /// Метод отправки сообщения пользователю.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        void SendMsg(string message);
    }
}
