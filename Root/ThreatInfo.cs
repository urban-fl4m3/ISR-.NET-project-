public class ThreatInfo
{
    public readonly Asset asset;
    public readonly int value;
    public readonly int riskValue;
    public readonly int riskId;
    public readonly ThreatMath.Rating vulnerability;

    public ThreatInfo(Asset a, int _value, ThreatMath.Rating _vulnerability, ThreatMath.Rating tLevel)
    {
        asset = a;
        value = _value;
        riskId = ++_riskId;
        vulnerability = _vulnerability;
        riskValue = ThreatMath.CalculateRiskRating(a.GetValue(), tLevel, vulnerability);
    }

    private static int _riskId;
}