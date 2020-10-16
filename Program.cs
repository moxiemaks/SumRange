using System;
using System.Collections.Generic;

namespace SumRange
{
    class Program
    {
        static void Main()
        {
            Range[] ranges = {
                Range.Create(1,4), 
                Range.Create(7,10), 
                Range.Create(3,5), 
            };

            Console.WriteLine(Range.Sum(ranges));
        }
    }

    /// <summary>
    /// Интервал
    /// </summary>
    class Range
    {
        #region Свойства

        /// <summary>
        /// Начало
        /// </summary>
        private int Start { get; set; }

        /// <summary>
        /// Конец
        /// </summary>
        private int End { get; set; }

        #endregion Свойства

        #region Методы

        /// <summary>
        /// Создать интервал
        /// </summary>
        /// <param name="start">Начало</param>
        /// <param name="end">Конец</param>
        /// <returns></returns>
        public static Range Create(int start, int end)
        {
            if (end <= start)
            {
                throw new ArgumentException("Конец интервала должен быть больше начала");
            }

            return new Range()
                {
                    Start = start, 
                    End = end
                };
        }

        /// <summary>
        /// Вернуть сумму всех длин интервалов
        /// </summary>
        /// <param name="ranges">список интервалов</param>
        /// <returns></returns>
        public static int Sum(Range[] ranges)
        {
            HashSet<int> resultRange = new HashSet<int>();

            // Соберем интервалы в один список без повторений
            //
            foreach (Range range in ranges)
            {
                for (int i = range.Start; i < range.End; i++)
                {
                    resultRange.Add(i);
                }
            }

            // Вернем количество элементов в собранном списке
            return resultRange.Count;
        }

        #endregion Методы
    }
}
