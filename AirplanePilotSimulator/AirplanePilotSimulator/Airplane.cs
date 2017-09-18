using System;
using System.Collections.Generic;

namespace AirplanePilotSimulator
{
    class Airplane
    {
        #region FIELD
        public event EventHandler ChangeSpeed;
        public event EventHandler ChangeHeight;
        private List<Dispatcher> listDisp;
        private decimal speed;
        private decimal height;
        private decimal totalRecHeight;
        private decimal totalPenalty;
        private bool needHeight;
        #endregion
        #region PROP
        public decimal TotalRecHeight
        {
            get { return totalRecHeight; }
            set { totalRecHeight = value; }
        }
        public decimal Speed
        {
            get{return speed;}
        }
        public decimal Height
        {
            get{return height;}
        }
        public Dispatcher ListDisp
        {
            set
            {
                listDisp.Add(value);
                ChangeSpeed += new EventHandler(value.CalculHeight);
                ChangeHeight += new EventHandler(value.CalculRenalty);
            }
        }
        public int CountDisp
        {
            get { return listDisp.Count; }
        }
        public Airplane()
        {
            listDisp = new List<Dispatcher>();
        }
        #endregion

        /// <summary>
        /// Метод выполняющий взлет
        /// </summary>
        public void Takeoff()
        {
            while (true)
            {
                speed = 0; height = 0;
                Console.WriteLine("Увеличте плавно скорость!");
                ConsoleKeyInfo keyInfo = Control();
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    Console.WriteLine($"Скорость самолета: {Speed}  Высота самолета: {Height}");
                else
                    continue;

                Console.WriteLine("Наберите плавно высоту!");
                keyInfo = Control();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    Console.WriteLine($"Скорость самолета: {Speed}  Высота самолета: {Height}");
                else
                    continue;
       
                Console.WriteLine("Взлет выполнен!");
                break;
            }
        }
        /// <summary>
        /// Основной полет
        /// </summary>
        public void Fly()
        {
            ConsoleKeyInfo keyInfo =  Control();
            Console.WriteLine($"Скорость самолета: {Speed}  Высота самолета: {Height}");
            if ((keyInfo.Key == ConsoleKey.UpArrow || keyInfo.Key == ConsoleKey.DownArrow) && ChangeHeight != null)
                ChangeHeight(this, EventArgs.Empty);
            if ((keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.LeftArrow) && ChangeSpeed != null)
            {
                totalRecHeight = 0;
                ChangeSpeed(this, EventArgs.Empty);
                totalRecHeight /= listDisp.Count;
            }
            Console.WriteLine($"Оптимальная высота с учетом требований диспетчеров равна {totalRecHeight}");
            Console.WriteLine(new string('-', 70));
            Console.ResetColor();
            if (speed >= 1000)
            {
                needHeight = true;
                Console.WriteLine("Максимальная скорость достигнута! Начинайте снижение!");
            }
            if (needHeight && speed == 50 && height == 250)
                Landing();
        }
        /// <summary>
        /// Метод посадки
        /// </summary>
        public void Landing()
        {
            Console.WriteLine("Самолет начинает посадку!");
            while (true)
            {
                Console.WriteLine("Соверните посадку, уменьшив высоту до 0!");
                ConsoleKeyInfo keyInfo = Control();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    Console.WriteLine($"Скорость самолета: {Speed}  Высота самолета: {Height}");
                else
                    continue;
                Console.WriteLine("Уменьшите скорость до 0!");
                keyInfo = Control();
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    Console.WriteLine($"Скорость самолета: {Speed}  Высота самолета: {Height}");
                else
                    continue;
                Console.WriteLine("Посадка выполнена!");
                foreach (var i in listDisp)
                    totalPenalty += i.CountPenalty;
                Console.WriteLine($"Штрафных баллов суммарно набрано: {totalPenalty}");

                throw new AirplaneException("Тренировочный полет завершен!");
            }
        }
        /// <summary>
        /// Метод управления через кнопки
        /// </summary>
        /// <returns>Возвращает имя нажатой кнопки</returns>
        private ConsoleKeyInfo Control()
        {
            Console.Write("Двигайте рычаг управления: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Modifiers.ToString() != "0" && keyInfo.Modifiers == ConsoleModifiers.Shift)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (height >= 0) height += 500; break;
                    case ConsoleKey.DownArrow: height -= (height - 500 > 0) ? 500 : height - 250; break;
                    case ConsoleKey.RightArrow: if (speed >= 0) speed += 150; break;
                    case ConsoleKey.LeftArrow: speed -= (speed - 150 > 0) ? 150 : speed - 50; break;
                    default:
                        break;
                }
            }
            else
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (height >= 0) height += 250; break;
                    case ConsoleKey.DownArrow: if (height >= 250) height -= 250; break;
                    case ConsoleKey.RightArrow: if (speed >= 0) speed += 50; break;
                    case ConsoleKey.LeftArrow: if (speed >= 50) speed -= 50; break;
                    default:
                        break;
                }
            }

            return keyInfo;
        }
        /// <summary>
        /// Удаление диспетчера и считывание его штрафа
        /// </summary>
        public void deleteDispatcher()
        {
            int random = Randomer.Next(0, listDisp.Count - 1);
            ChangeSpeed -= new EventHandler(listDisp[random].CalculHeight);
            ChangeHeight -= new EventHandler(listDisp[random].CalculRenalty);
            totalPenalty += listDisp[random].CountPenalty;
            listDisp.RemoveAt(random);
        }
    }
}
