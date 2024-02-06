using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19Task3
{
    internal class PizzaPlace
    {
        private SemaphoreSlim semaphore;

        public PizzaPlace(int numberOfCooks)
        {
            semaphore = new SemaphoreSlim(numberOfCooks, numberOfCooks);
        }

        public async Task CookPizzaAsync(string pizzaName)
        {
            // Ожидаем, пока освободится слот для приготовления пиццы
            await semaphore.WaitAsync();

            try
            {
                Console.WriteLine($"Cooking {pizzaName} started by worker {Thread.CurrentThread.ManagedThreadId}");

                // Имитация приготовления пиццы с задержкой
                await Task.Delay(2000);

                Console.WriteLine($"Cooking {pizzaName} completed by worker {Thread.CurrentThread.ManagedThreadId}");
            }
            finally
            {
                // Освобождаем слот после приготовления
                semaphore.Release();
            }
        }
    }
}
