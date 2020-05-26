using System;

/// <summary>
/// Логгер активов. Выводит упорядоченную по дате ддобавления информацию о всех существующих активах
/// </summary>
public static class AssetLogger
{
    /// <summary>
    /// Вывести информацию об активах у конкретного юзера
    /// </summary>
    /// <param name="u"> Юзер, у которого хранится список активов</param>
    public static void LogAssets(User u)
    {
        for (int i = 0; i < u.AssetsCount(); i++)
        {
            LogAssetValue(u.GetAsset(i));
        }
    }

    /// <summary>
    /// Вывести информацию об активе
    /// </summary>
    /// <param name="t">Актив</param>
    private static void LogAssetValue(Asset a)
    {
        Console.WriteLine($"{a.GetName()} value is {a.GetValue()}");
    }
}