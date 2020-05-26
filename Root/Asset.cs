using System.Linq;

/// <summary>
/// Класс актива
/// </summary>
public class Asset
{
    // Регион геттеров
    public int GetValue() => sumValues;
    public string GetName() => name;

    // Числовые параметры актива
    private readonly int[] values;
    // Итоговая ценность актива
    private int sumValues;

    // Имя актива
    private readonly string name;

    // Конструктор актива
    public Asset(string _name, AssetValues _values)
    {
        name = _name;
        values = _values.ToArray();
        sumValues = values.Sum();
    }

    // Нормализация значения актива 
    public void Normalize(int min) => sumValues -= min - 1;

    /// <summary>
    ///  Структура числовых данных актива
    /// </summary>
    public struct AssetValues
    {
        // Возможность оперативной замены
        private readonly int qro;
        // Своевременное выявление факта выхода из строя
        private readonly int tdf;
        // Конфеденциальность
        private readonly int c;
        // Целостность
        private readonly int i;
        // Доступность
        private readonly int a;

        public AssetValues(int _qro, int _tdf, int _c, int _i, int _a)
        {
            qro = _qro;
            tdf = _tdf;
            c = _c;
            i = _i;
            a = _a;
        }

        // Перевод значений в массив
        public int[] ToArray() => new[] { qro, tdf, c, i, a };

    }
}