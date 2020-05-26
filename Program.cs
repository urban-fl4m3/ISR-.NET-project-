using System;
using System.Collections.Generic;

static class Program
{
    static void Main()
    {
        // Создаем нового юзера, в котором будет храниться информация о всевозможных угроз и активах
        User u = new User();

        // Берем уже созданные заранее  активы
        List<Asset> assets = AssetTests.GetFirstTest();

        // Копируем их в новый список для юзера
        u.CopyAssets(assets);
        // Нормализуем их по значению
        u.NormalizeAssets();

        // Берем уже созданные заранее угрозы
        var threats = ThreatTests.GetFirstThreats(u);
        // Копируем их в новый список для юзера
        u.CopyThreats(threats);

        // Выводим информацию о всех активах
        AssetLogger.LogAssets(u);
        LogString();
        // Выводим информацию о всех угрозах
        ThreatLogger.LogThreats(u);
        


        Console.ReadKey();
    }

    private static void LogString()
    {
        Console.WriteLine("------------------------------------------------");
    }
}