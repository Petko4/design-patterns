public abstract class APerson
{
    private static int index = 0;

    public static APerson GetPerson()
    {
        return (index++ % 3) switch
        {
            0 => new LazyPerson(),
            1 => new BriskPerson(),
            2 => new HardWorkingPerson(),
            _ => throw new Exception(),
        };
    }

    public abstract void WakeUp();
    public abstract void Work();
    public abstract void FreeTime();
    public abstract void Sleep();

    private class LazyPerson : APerson
    {
        public override void WakeUp()
        {
            Console.WriteLine("Slowly wake up.");
        }
        public override void Work()
        {
            Console.WriteLine("Lazy work.");
        }
        public override void FreeTime()
        {
            Console.WriteLine("Going to sleep.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Still sleeping");
        }
    }

    private class BriskPerson : APerson
    {
        public override void WakeUp()
        {
            Console.WriteLine("Fast wake up.");
        }
        public override void Work()
        {
            Console.WriteLine("Brisk work.");
        }
        public override void FreeTime()
        {
            Console.WriteLine("Active rest.");
        }
        public override void Sleep()
        {
            Console.WriteLine("Pass out and sleep.");
        }
    }

    private class HardWorkingPerson : APerson
    {
        public override void WakeUp()
        {
            Console.WriteLine("Waking up early.");
        }
        public override void Work()
        {
            Console.WriteLine("Hard working.");
        }
        public override void FreeTime()
        {
            Console.WriteLine("Still working.");
        }
        public override void Sleep()
        {
            Console.WriteLine("Falling asleep at work.");
        }
    }



}