using System.Globalization;

namespace Convert_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ComandExchangeRubUsd = "1";
            const string ComandExchangeRubEur = "2";
            const string ComandExchangeUsdRub = "3";
            const string ComandExchangeUsdEur = "4";
            const string ComandExchangeEurRub = "5";
            const string ComandExchangeEurUsd = "6";
            const string ComandExit = "7";

            CultureInfo culture = new CultureInfo("ru-RU");
            bool isEnabled = true;
            float quantityRub = 1000;
            float quantityUsd = 1000;
            float quantityEur = 1000;
            float exchangeRateRubUsd = 1f / 30f;
            float exchangeRateRubEur = 1f / 45f;
            float exchangeRateUsdRub = 30f;
            float exchangeRateUsdEur = 2f / 3f;
            float exchangeRateEurRub = 45f;
            float exchangeRateEurUsd = 3f / 2f;
            string? userInput;

            while (isEnabled)
            {
                Console.Clear();

                ShowInfo();
                ShowMenu();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case ComandExchangeRubUsd:
                        ExchangeMoney(ref quantityRub, ref quantityUsd, exchangeRateRubUsd);
                        break;

                    case ComandExchangeRubEur:
                        ExchangeMoney(ref quantityRub, ref quantityEur, exchangeRateRubEur);
                        break;

                    case ComandExchangeUsdRub:
                        ExchangeMoney(ref quantityUsd, ref quantityRub, exchangeRateUsdRub);
                        break;

                    case ComandExchangeUsdEur:
                        ExchangeMoney(ref quantityUsd, ref quantityEur, exchangeRateUsdEur);
                        break;

                    case ComandExchangeEurRub:
                        ExchangeMoney(ref quantityEur, ref quantityRub, exchangeRateEurRub);
                        break;

                    case ComandExchangeEurUsd:
                        ExchangeMoney(ref quantityEur, ref quantityUsd, exchangeRateEurUsd);
                        break;

                    case ComandExit:
                        isEnabled = false;
                        Console.WriteLine("Программа остановлена!");
                        break;
                }
            }

            void ShowMenu()
            {
                Console.WriteLine("-----Команды меню-----");
                Console.WriteLine($"{ComandExchangeRubUsd} Обмен Rub на Usd");
                Console.WriteLine($"{ComandExchangeRubEur} Обмен Rub на Eur");
                Console.WriteLine($"{ComandExchangeUsdRub} Обмен Usd на Rub");
                Console.WriteLine($"{ComandExchangeUsdEur} Обмен Usd на Eur");
                Console.WriteLine($"{ComandExchangeEurRub} Обмен Eur на Rub");
                Console.WriteLine($"{ComandExchangeEurUsd} Обмен Eur на Usd");
                Console.WriteLine($"{ComandExit} Выход");
            }

            void ShowInfo()
            {
                Console.WriteLine($"Количество RUB {quantityRub}");
                Console.WriteLine($"Количество USD {quantityUsd}");
                Console.WriteLine($"Количество EUR {quantityEur}");
            }

            void ExchangeMoney(ref float moneys, ref float exchangeMoneys, float exchangeRate)
            {
                Console.Write("Количество валюты для конвертации: ");
                float quantityExchangeMoneys = Convert.ToSingle(Console.ReadLine(), culture);
                moneys -= quantityExchangeMoneys;
                exchangeMoneys += quantityExchangeMoneys * exchangeRate;
            }
        }
    }
}