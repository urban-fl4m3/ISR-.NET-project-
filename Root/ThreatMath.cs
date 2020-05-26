/// <summary>
/// Класс, который позволяет нам посчитать необходимые значения рейтинга угроз.
/// По стандарту используется таблица по ГОСТ'у
/// Для установления уровня угроз используются заранее установленные значения, представленные в таблице по ГОСТ'у:
///- Н – Низкая – принятых мер по обеспечению защиты ИБ достаточно
///- С – Средняя – принятых мер по обеспечению защиты ИБ недостаточно
///- В – Высокая – меры по обеспечению защиты ИБ не приняты
///- Н – Низкая – нарушителю необходимо иметь специальные аппаратные и программные средства, также нарушитель должен обладать глубокими знаниями в области ИБ
///- С – Средняя – нарушителю необходимо иметь специальные аппаратные и программные средства, а также базовые знания в области ИБ
///- В – Высокая – нарушителю достаточно иметь специальные аппаратные и программные средств
/// </summary>
public static class ThreatMath
{
    // Объявление и определение рейтинг системы.
    public enum  Rating { Low = 0, Medium = 1, High = 2}

    // Оценка вероятности угрозы (по ГОСТу)
    public static int ProbabilityRating(int assetValue, Rating threatLevel, Rating threatEase)
        => assetValue - 1 + (int)threatLevel + (int)threatEase;

    // Оценка уровня уязвимости (по ГОСТу)
    public static Rating VulnerabilityLevel(int threatValue, int assetValue, Rating threatLevel) 
        => (Rating)(threatValue - assetValue - (int)threatLevel + 1);

    // Оценка значения риска (по ГОСТу)
    public static int CalculateRiskRating(int assetValue, Rating threatLevel, Rating vulnerabilityLevel) 
        => assetValue + (int)threatLevel + (int)vulnerabilityLevel;
}