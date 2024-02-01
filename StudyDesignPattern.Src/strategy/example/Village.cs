namespace StudyDesignPattern.Src.strategy.example;

/// <summary>
/// 村莊類別，等等拿來做排序用
/// </summary>
public class Village
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Population { get; set; }

    public double Area { get; set; }

    public Village(int id, string name, int population, double area)
    {
        this.Id = id;
        this.Name = name;
        this.Population = population;
        this.Area = area;
    }

    public override string ToString()
    {
        return $"{Id}.{Name}(人口：{Population}) 面積：{Area}";
    }
}

