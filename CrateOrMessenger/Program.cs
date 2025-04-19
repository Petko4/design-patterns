static void add(int h, int m, int d, string txt, DailyPlan dailyPlan)
{
    bool success;
    Console.WriteLine($"Adding {d} minutes from {h:00}:{m:00} for {txt}");
    success = dailyPlan.Add(h, m, d, txt);
    Console.WriteLine("          " + (success ? "YES" : "NO"));
    dailyPlan.display();
}


static void test()
{
    DailyPlan dailyPlan = new DailyPlan();
    add(8, 0, 30, "Wake up", dailyPlan);
    add(10, 30, 90, "Relax", dailyPlan);
    add(8, 30, 30, "Breakfast", dailyPlan);
    add(9, 30, 90, "Work", dailyPlan);
}


test();
