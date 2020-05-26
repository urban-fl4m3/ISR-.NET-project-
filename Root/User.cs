using System.Collections.Generic;
using System.Linq;

public class User
{
    // Список активов юзера
    private List<Asset> assets = new List<Asset>();
    // Список угроз юзера
    private List<Threat> threats = new List<Threat>();

    // Регион геттеров
    public Asset GetAsset(int index) => assets[index];
    public Threat GetThreat(int index) => threats[index];
    public int AssetsCount() => assets.Count;
    public int ThreatsCount() => threats.Count;
    public void AddAsset(Asset a) => assets.Add(a);
    public void CopyAssets(List<Asset> a) => assets = a;
    public void CopyThreats(List<Threat> t) => threats = t;

    public void NormalizeAssets()
    {
        int minValue = assets.Min(x => x.GetValue());

        foreach (var a in assets)
        {
            a.Normalize(minValue);
        }
    }
}