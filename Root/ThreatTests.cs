using System.Collections.Generic;
using Rating = ThreatMath.Rating;

public static class ThreatTests
{
    public static List<Threat> GetFirstThreats(User u)
    {
        List<Threat> result = new List<Threat>();

        string name = "Угроза деструктивного изменения конфигурации среды ПО";
        Threat threat = new Threat(name, Rating.Low, Rating.Low, new List<Asset>{ u.GetAsset(3)});
        result.Add(threat);

        name = "Угроза перехвата управления информационной системы";
        threat = new Threat(name, Rating.Low, Rating.Low, new List<Asset> { u.GetAsset(3)});
        result.Add(threat);

        name = "Угроза хищения средств, хранения, обработки и (или) ввода/вывода/передачи информации";
        threat = new Threat(name, Rating.Low, Rating.High, new List<Asset> { u.GetAsset(2), u.GetAsset(4) });
        result.Add(threat);

        name = "Угроза физического выведения из стро средств хранения обработки и(или) ввода/вывода/передачи информации";
        threat = new Threat(name, Rating.Medium, Rating.High, new List<Asset> { u.GetAsset(2), u.GetAsset(4), u.GetAsset(7), u.GetAsset(8) });
        result.Add(threat);

        name = "Угроза изменения компонентов системы";
        threat = new Threat(name, Rating.Low, Rating.Low, new List<Asset> { u.GetAsset(2), u.GetAsset(4), u.GetAsset(7), u.GetAsset(8) });
        result.Add(threat);

        name = "Угроза нарушение энергоснабжения";
        threat = new Threat(name, Rating.Medium, Rating.High, new List<Asset> { u.GetAsset(2), u.GetAsset(4), u.GetAsset(8)});
        result.Add(threat);

        name = "Угроза перехвата компрометирующих помех";
        threat = new Threat(name, Rating.Medium, Rating.Low, new List<Asset> { u.GetAsset(0), u.GetAsset(1)});
        result.Add(threat);

        name = "Угроза нарушения функционирования программного обеспечения";
        threat = new Threat(name, Rating.Medium, Rating.Medium, new List<Asset> { u.GetAsset(3)});
        result.Add(threat);
        
        name = "Угроза физического повреждения";
        threat = new Threat(name, Rating.Medium, Rating.Medium, new List<Asset> { u.GetAsset(6) });
        result.Add(threat);

        name = "Угроза нарушения работоспособности персонала";
        threat = new Threat(name, Rating.Medium, Rating.High, new List<Asset> { u.GetAsset(5) });
        result.Add(threat);

        return result;
    }
}