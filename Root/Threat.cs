using System.Collections.Generic;
using Rating = ThreatMath.Rating;

/// <summary>
/// Класс угрозы. Определяется уровнем и простотой
/// </summary>
public class Threat
{
    // Имя угрозы
    private readonly string name;
    // Список общей информации об активах, соотнесенных с угрозами
    private readonly List<ThreatInfo> info = new List<ThreatInfo>();
    // Уровень угрозы и простоты использования
    private readonly Rating level, ease;

    // Регион геттеров
    public ThreatInfo GetInfo(int index) => info[index];
    public int AssetCount() => info.Count;
    public string GetName() => name;

    // Конструктор класса
    public Threat(string _name, Rating _level, Rating _ease, IEnumerable<Asset> _assets)
    {
        name = _name;
        level = _level;
        ease = _ease;

        foreach (var asset in _assets)
        {
            int pRating = ThreatMath.ProbabilityRating(asset.GetValue(), _level, ease);
            Rating vRating = ThreatMath.VulnerabilityLevel(pRating, asset.GetValue(), level);
            info.Add(new ThreatInfo(asset, pRating, vRating, level));
        }
    }
}