using System;

namespace AirplanePilotSimulator
{
    class Dispatcher
    {
        private readonly string name;
        private readonly decimal kpu;
        private decimal recHeight;
        private decimal countPenalty;

        public decimal CountPenalty
        {
            get { return countPenalty; }
        }

        public Dispatcher(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("Неверное имя!");
            this.name = name;
            kpu = Randomer.Next(-200, 200);
        }
        /// <summary>
        /// Метод для вычисления рекомендуемой высоты
        /// </summary>
        /// <param name="sender">Объект самолета</param>
        /// <param name="e">Пустой</param>
        public void CalculHeight(object sender, EventArgs e)
        {
            Airplane plane = (Airplane)sender;
            recHeight = 7 * plane.Speed - kpu;
            Console.ForegroundColor = ConsoleColor.Green;
            if (plane.Speed > 1000)
            {
                countPenalty += 100;
                Console.WriteLine("Срочно снизьте скорость!!!");
            }
            if (plane.Height == 0 || plane.Speed == 0)
                throw new AirplaneException("Самолет разбился!");
            plane.TotalRecHeight += recHeight;
            if (Math.Abs(recHeight - plane.Height) >= 1000)
                throw new AirplaneException("Самолет разбился из за нарушения высоты!");
            if (countPenalty >= 1000)
                throw new AirplaneException("Непригоден к полетам!");
            Console.WriteLine($"Диспетчер {name} рекомендует высоту в {recHeight}!");
        }
        /// <summary>
        /// Метод для проверки соблюдения рек. высоты
        /// </summary>
        /// <param name="sender">Объект самолета</param>
        /// <param name="e">Пустой</param>
        public void CalculRenalty(object sender, EventArgs e)
        {
            Airplane plane = (Airplane)sender;
            if(recHeight == 0)
                recHeight = 7 * plane.Speed - kpu; // При добавлении диспетчера, рек. высота равна 0 что сразу вызывает исключение
            if (plane.Speed > 1000)
            {
                countPenalty += 100;
                Console.WriteLine("Срочно снизьте скорость!!!");
            }
            if (plane.Height == 0 || plane.Speed == 0)
                throw new AirplaneException("Самолет разбился!");
            decimal sub = Math.Abs(recHeight - plane.Height);
            if (sub >= 300 && sub < 600)
                countPenalty += 25;
            else if (sub >= 600 && sub < 1000)
                countPenalty += 50;
            else if (sub >= 1000)
                throw new AirplaneException("Самолет разбился из за нарушения высоты!");

            if(countPenalty >= 1000)
                throw new AirplaneException("Непригоден к полетам!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Диспетчер {name} насчитал штрафных баллов: {countPenalty}!");
        }
    }
}
