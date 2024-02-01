namespace StudyDesignPattern.Src.strategy.example;

/// <summary>
/// 村莊名稱做排序(ConcretStrategy)
/// </summary>
public class SortVillageByName : IComparer<Village>
{
    public int Compare(Village? x, Village? y)
    {
        if (x == null && y == null) return 0; // 兩者相等
        if (x == null) return -1; // x小於y
        if (y == null) return 1; // x大於y

        // 比較字串的長度
        int result = x.Name.Length.CompareTo(y.Name.Length);

        // 如果長度相等，則比較字典順序
        if (result == 0)
        {
            result = string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }

        return result;
    }
}