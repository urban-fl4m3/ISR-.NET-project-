using System.Collections.Generic;

public static class AssetTests
{
    // Текущие юнит тесты активов (в соответствии с таблицей)
    public static List<Asset> GetFirstTest()
    {
        List<Asset> result = new List<Asset>();

        Asset.AssetValues values = new Asset.AssetValues(5, 5, 5, 1, 1);
        string name = "Информация, переносимая ЭМ полями";
        result.Add(new Asset(name, values));

        values = new Asset.AssetValues(5, 5, 4, 2, 1);
        name = "Информация о конфигурации системы защиты от утечек по ПЭМИ";
        result.Add(new Asset(name, values));

        values = new Asset.AssetValues(5, 4, 5, 1, 1);
        name = "Аппаратура обработки величины ЭМ полей";
        result.Add(new Asset(name, values));

        values = new Asset.AssetValues(5, 5, 4, 1, 2);
        name = "Программное обеспечение системы защиты от утечек по ПЭМИ";
        result.Add(new Asset(name, values));

        values = new Asset.AssetValues(3, 4, 4, 1, 1);
        name = "Ретрансляторы сигнала";
        result.Add(new Asset(name, values));

        values = new Asset.AssetValues(5, 1, 4, 2, 3);
        name = "Персонал по эксплуатации и сопровождению системы";
        result.Add(new Asset(name, values));

        values = new Asset.AssetValues(3, 4, 2, 1, 1);
        name = "Экранированные короба для проводов";
        result.Add(new Asset(name, values));

        values = new Asset.AssetValues(2, 1, 3, 1, 5);
        name = "Источник бесперебойного электропитания";
        result.Add(new Asset(name, values));

        values = new Asset.AssetValues(2, 3, 2, 2, 5);
        name = "Соединительные провода";
        result.Add(new Asset(name, values));

        return result;
    }
}