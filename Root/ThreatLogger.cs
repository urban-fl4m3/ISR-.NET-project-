using System;

/// <summary>
/// Логгер угроз. Выводит упорядоченную по дате ддобавления информацию о всех существующих угрозах
/// </summary>
public static class ThreatLogger
{
    /// <summary>
    /// Вывести информацию об угрозах у конкретного юзера
    /// </summary>
    /// <param name="u"> Юзер, у которого хранится список угроз</param>
    public static void LogThreats(User u)
    {
        for (int i = 0; i < u.ThreatsCount(); i++)
        {
            LogThreatValue(u.GetThreat(i));
        }
    }

    /// <summary>
    /// Вывести информацию об угрозе
    /// </summary>
    /// <param name="t">Угроза</param>
    private static void LogThreatValue(Threat t)
    {
        string threatName = t.GetName();

        for (int i = 0; i < t.AssetCount(); i++)
        {
            var info = t.GetInfo(i);
            var asset = info.asset;
            Console.WriteLine($"{threatName} с активом {asset.GetName()} ({asset.GetValue()}) имеет оценку вероятности реализации: {info.value} //" +
                              $"{info.vulnerability} - уровень угрозы // {info.riskValue} - параметр риска // {info.riskId} - номер риска //" +
                              $"{info.vulnerability} - уровень уязвимости");
        }
    }
}