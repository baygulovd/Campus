using System;
using System.Collections.Generic;

namespace Campus
{
    /// <summary>
    /// Студент
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Фотография
        /// </summary>
        public byte[] Photo { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Институт
        /// </summary>
        public Institute Institute { get; set; }
        /// <summary>
        /// История проживания
        /// </summary>
        public List<HistoryOfResidence> HistoryOfResidence { get; set; }
        /// <summary>
        /// Оплата проживания
        /// </summary>
        public List<Payment> Payment { get; set; }
    }

    /// <summary>
    /// История проживания
    /// </summary>
    public class HistoryOfResidence
    {
        /// <summary>
        /// Дата поселения
        /// </summary>
        public DateTime DateOfArrival { get; set; }
        /// <summary>
        /// Дата выселения
        /// </summary>
        public DateTime DateOfDeparture { get; set; }
        /// <summary>
        /// Причина выселения
        /// </summary>
        public string CauseOfDeparture { get; set; }
        /// <summary>
        /// Комната
        /// </summary>
        public int Room { get; set; }

        public override string ToString()
        {
            return $"Дата поселения: {DateOfArrival}, Дата выселения: {DateOfDeparture}, Причина выселения: {CauseOfDeparture}, Комната: {Room}";
        }
    }

    /// <summary>
    /// Институт
    /// </summary>
    public enum Institute
    {
        /// <summary>
        /// ИРИТ-РтФ
        /// </summary>
        RTF,
        /// <summary>
        /// ФТИ
        /// </summary>
        PhTI,
        /// <summary>
        /// ИНМиТ
        /// </summary>
        INMT,
    }

    /// <summary>
    /// Оплата проживания
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Дата платежа
        /// </summary>
        public DateTime DateOfPayment { get; set; }
        /// <summary>
        /// Сумма платежа
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// Дата следующего платежа
        /// </summary>
        public DateTime? DateOfNextPayment { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string Notice { get; set; }

        public override string ToString()
        {
            return $"{nameof(DateOfPayment)}: {DateOfPayment}, {nameof(Amount)}: {Amount}, {nameof(DateOfNextPayment)}: {DateOfNextPayment}, {nameof(Notice)}: {Notice}";
        }
    }
}
