using System;

namespace AirplanePilotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Airplane Boing777 = new Airplane();
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Введите имя {i + 1} диспетчера:");
                    string name = Console.ReadLine();
                    Dispatcher disp = new Dispatcher(name);
                    Boing777.ListDisp = disp;
                }
                Console.WriteLine("Взлет разрешен!");
                Boing777.Takeoff();
                while (true)
                {
                    if (Boing777.CountDisp < 2)
                        throw new AirplaneException("Недостаточно диспетчеров для взлета!");

                    Boing777.Fly();
                    if(DateTime.Now.Second % 25 == 0) // Рандомное добавление диспетчеров в полет
                    {
                        Console.WriteLine("В полете появился дополнительный диспетчер! Введите имя");
                        string name = Console.ReadLine();
                        Dispatcher disp = new Dispatcher(name);
                        Boing777.ListDisp = disp;
                    }
                    if (DateTime.Now.Second % 20 == 0 && Boing777.CountDisp > 2) // Рандомное удаление диспетчеров
                    {
                        Console.WriteLine("Один из диспетчеров завершил управление полетом!");
                        Boing777.deleteDispatcher();
                    }
                }
            }
            catch (AirplaneException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
