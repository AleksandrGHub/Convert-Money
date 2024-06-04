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
                        ExchangeMoneyRubUsd();
                        break;

                    case ComandExchangeRubEur:
                        ExchangeMoneyRubEur();
                        break;

                    case ComandExchangeUsdRub:
                        ExchangeMoneyUsdRub();
                        break;

                    case ComandExchangeUsdEur:
                        ExchangeMoneyUsdEur();
                        break;

                    case ComandExchangeEurRub:
                        ExchangeMoneyEurRub();
                        break;

                    case ComandExchangeEurUsd:
                        ExchangeMoneyEurUsd();
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

            void ExchangeMoneyRubUsd()
            {
                Console.Write("Количество валюты для конвертации: ");
                float quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

                if (quantityRub > quantityExchangeMoney)
                {
                    quantityRub -= quantityExchangeMoney;
                    quantityUsd += quantityExchangeMoney * exchangeRateRubUsd;
                }
                else
                {
                    Console.WriteLine("Недостаточно денег  для обмена.");
                    Console.ReadKey();
                }
            }

            void ExchangeMoneyRubEur()
            {
                Console.Write("Количество валюты для конвертации: ");
                float quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

                if (quantityRub > quantityExchangeMoney)
                {
                    quantityRub -= quantityExchangeMoney;
                    quantityEur += quantityExchangeMoney * exchangeRateRubEur;
                }
                else
                {
                    Console.WriteLine("Недостаточно денег  для обмена.");
                    Console.ReadKey();
                }
            }

            void ExchangeMoneyUsdRub()
            {
                Console.Write("Количество валюты для конвертации: ");
                float quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

                if (quantityUsd > quantityExchangeMoney)
                {
                    quantityUsd -= quantityExchangeMoney;
                    quantityRub += quantityExchangeMoney * exchangeRateUsdRub;
                }
                else
                {
                    Console.WriteLine("Недостаточно денег  для обмена.");
                    Console.ReadKey();
                }
            }

            void ExchangeMoneyUsdEur()
            {
                Console.Write("Количество валюты для конвертации: ");
                float quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

                if (quantityUsd > quantityExchangeMoney)
                {
                    quantityUsd -= quantityExchangeMoney;
                    quantityEur += quantityExchangeMoney * exchangeRateUsdEur;
                }
                else
                {
                    Console.WriteLine("Недостаточно денег  для обмена.");
                    Console.ReadKey();
                }
            }

            void ExchangeMoneyEurRub()
            {
                Console.Write("Количество валюты для конвертации: ");
                float quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

                if (quantityEur > quantityExchangeMoney)
                {
                    quantityEur -= quantityExchangeMoney;
                    quantityRub += quantityExchangeMoney * exchangeRateEurRub;
                }
                else
                {
                    Console.WriteLine("Недостаточно денег  для обмена.");
                    Console.ReadKey();
                }
            }

            void ExchangeMoneyEurUsd()
            {
                Console.Write("Количество валюты для конвертации: ");
                float quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

                if (quantityEur > quantityExchangeMoney)
                {
                    quantityEur -= quantityExchangeMoney;
                    quantityUsd += quantityExchangeMoney * exchangeRateEurUsd;
                }
                else
                {
                    Console.WriteLine("Недостаточно денег  для обмена.");
                    Console.ReadKey();
                }
            }
        }
    }
}