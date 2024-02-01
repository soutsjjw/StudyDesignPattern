namespace StudyDesignPattern.Src.strategy.example;

/// <summary>
/// 使用ID排序(ConcretStrategy)
/// </summary>
public class SortVillageById : IComparer<Village>
{
    public int Compare(Village? x, Village? y)
    {
        if (x == null && y == null) return 0; // 兩者相等
        if (x == null) return -1; // x小於y
        if (y == null) return 1; // x大於y

        if (x.Id > y.Id)
            return 1;

        if (x.Id < y.Id)
            return -1;

        return 0;
    }
}

