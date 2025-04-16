static void test()
{
    for (int i = 1; i <= 3; i++)
    {
        APerson p = APerson.GetPerson();
        Console.WriteLine("\n=== New person: " + p.GetType().Name);
        p.WakeUp();
        p.Work();
        p.FreeTime();
        p.Sleep();
    }
}


test();