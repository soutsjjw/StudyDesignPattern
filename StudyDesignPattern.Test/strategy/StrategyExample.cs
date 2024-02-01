using StudyDesignPattern.Src.strategy.example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.Test.strategy;

/// <summary>
/// 策略模式排序-測試
/// </summary>
public class StrategyExample
{
    [Test]
    [Category("策略模式")]
    public void Test()
    {
        Console.WriteLine("==========策略模式排序測試==========");

        // 準備三個村莊的資料
        Village appleFarm = new Village(3, "apple farm", 32, 5.1);
        Village barnField = new Village(1, "barn field", 22, 1.7);
        Village capeValley = new Village(2, "cape valley", 10, 10.2);

        List<Village> vilages = new List<Village>();
        vilages.Add(appleFarm);
        vilages.Add(barnField);
        vilages.Add(capeValley);

        Console.WriteLine("沒排序過的資料");
        showList(vilages);

        Console.WriteLine("根據ID排序");
        vilages.Sort(new SortVillageById());
        showList(vilages);
        Console.WriteLine("根據名字排序");
        vilages.Sort(new SortVillageByName());
        showList(vilages);

        Console.WriteLine("根據人口排序");
        vilages.Sort(new SortVillageByPopulation());
        showList(vilages);

        Console.WriteLine("根據面積排序");
        vilages.Sort(new SortVillageByArea());
        showList(vilages);

        Assert.Pass();
    }

    // 為了把資料印出來看
    private static void showList(List<Village> list)
    {
        foreach(var v in list)
        {
            Console.WriteLine(v);
        }
    }
}
