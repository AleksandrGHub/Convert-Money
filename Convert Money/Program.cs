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
            float quantityExchangeMoney;
            float quantityRub = 1000;
            float quantityUsd = 1000;
            float quantityEur = 1000;
            float exchangeRateRubUsd = 0.04f;
            float exchangeRateRubEur = 0.025f;
            float exchangeRateUsdRub = 25f;
            float exchangeRateUsdEur = 0.625f;
            float exchangeRateEurRub = 40f;
            float exchangeRateEurUsd = 1.6f;
            string? userInput;

            while (isEnabled)
            {
                Console.Clear();

                Console.WriteLine($"Количество RUB {quantityRub}");
                Console.WriteLine($"Количество USD {quantityUsd}");
                Console.WriteLine($"Количество EUR {quantityEur}");

                Console.WriteLine("-----Команды меню-----");
                Console.WriteLine($"{ComandExchangeRubUsd} Обмен Rub на Usd");
                Console.WriteLine($"{ComandExchangeRubEur} Обмен Rub на Eur");
                Console.WriteLine($"{ComandExchangeUsdRub} Обмен Usd на Rub");
                Console.WriteLine($"{ComandExchangeUsdEur} Обмен Usd на Eur");
                Console.WriteLine($"{ComandExchangeEurRub} Обмен Eur на Rub");
                Console.WriteLine($"{ComandExchangeEurUsd} Обмен Eur на Usd");
                Console.WriteLine($"{ComandExit} Выход");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case ComandExchangeRubUsd:
                        Console.Write("Количество валюты для конвертации: ");
                        quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

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
                        break;

                    case ComandExchangeRubEur:
                        Console.Write("Количество валюты для конвертации: ");
                        quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

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
                        break;

                    case ComandExchangeUsdRub:
                        Console.Write("Количество валюты для конвертации: ");
                        quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

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
                        break;

                    case ComandExchangeUsdEur:
                        Console.Write("Количество валюты для конвертации: ");
                        quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

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
                        break;

                    case ComandExchangeEurRub:
                        Console.Write("Количество валюты для конвертации: ");
                        quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

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
                        break;

                    case ComandExchangeEurUsd:
                        Console.Write("Количество валюты для конвертации: ");
                        quantityExchangeMoney = Convert.ToSingle(Console.ReadLine(), culture);

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
                        break;

                    case ComandExit:
                        isEnabled = false;
                        Console.WriteLine("Программа остановлена!");
                        break;
                }
            }
        }
    }
}