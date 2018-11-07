//instances

//singleton

Class Program
{
    static void Main()
    {
        SiteStructure s = SiteStructure.Instance;
    }
}

public sealed class SiteStructure
{
    static readonly SiteStructure _instance = new SiteStructure();
    public static SiteStructure Instance
    {
        get
        {
            return _instance;
        }
    }
    SiteStructure()
    {
        // Initialize.
    }
}

//read only
using System;

class Program
{
    static void Main()
    {
        Manager manager = new Manager();
        Console.WriteLine(manager.GetStartup());
    }
}

class Manager
{
    readonly DateTime _startup; // <-- the readonly field

    public Manager()
    {
        // Initialize startup time.
        this._startup = DateTime.Now;
    }

    public DateTime GetStartup()
    {
        // We cannot modify the DateTime here.
        return this._startup;
    }
}

using System;

class Program
{
    static void Main()
    {
        // This DateTime is constructed with an instance constructor.
        // ... We write it to the console.
        // ... If this is today, the second line will be True.
        DateTime value = new DateTime(2017, 1, 18);
        Console.WriteLine(value);
        Console.WriteLine(value == DateTime.Today);
    }
}

using System;

class Program
{
    class Employee
    {
        public DateTime HiringDate { get; set; }
    }

    static void Main()
    {
        //
        // Write the current date and time.
        //
        DateTime now = DateTime.Now;
        Console.WriteLine(now);

        //
        // Store a DateTime in a class.
        //
        Employee employee = new Employee() { HiringDate = now };
        Console.WriteLine(employee.HiringDate);
    }
}

using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now; // <-- Value is copied into local
        Console.WriteLine(now);
        System.Threading.Thread.Sleep(10000);

        //
        // This variable has the same value as before.
        //
        Console.WriteLine(now);
    }
}

using System;

/// <summary>
/// Utility class to return new DateTimes every few requests.
/// </summary>
public static class DateTimeNowCache
{
    /// <summary>
    /// Refresh time after this many requests.
    /// </summary>
    const int _count = 20;

    /// <summary>
    /// The most recent time collected.
    /// </summary>
    static DateTime _recentTime = DateTime.Now;

    /// <summary>
    /// Number of skipped time collections
    /// </summary>
    static int _skipped;

    /// <summary>
    /// Get the DateTime within the last N calls.
    /// </summary>
    /// <returns>Recent DateTime collected.</returns>
    public static DateTime GetDateTime()
    {
        _skipped++;
        if (_skipped > _count)
        {
            _recentTime = DateTime.Now;
            _skipped = 0;
        }
        return _recentTime;
    }
}

//sealed

using System;

/// <summary>
/// Example interface.
/// </summary>
interface ITest
{
    /// <summary>
    /// Method required by the interface.
    /// </summary>
    int GetNumber();
}

/// <summary>
/// Non-sealed class that implements an interface.
/// </summary>
class TestA : ITest
{
    /// <summary>
    /// Interface implementation.
    /// </summary>
    public int GetNumber()
    {
        return 1;
    }
}

/// <summary>
/// Sealed class that implements an interface.
/// </summary>
sealed class TestB : ITest
{
    /// <summary>
    /// Interface implementation.
    /// </summary>
    public int GetNumber()
    {
        return 2;
    }
}

class Program
{
    static void Main()
    {
        ITest test1 = new TestA(); // Regular class
        ITest test2 = new TestB(); // Sealed instantiation
        Console.WriteLine(test1.GetNumber()); // TestA.GetNumber
        Console.WriteLine(test2.GetNumber()); // TestB.GetNumber
    }
}

//private constructor

class Widget
{
    int _size;
    public Widget(int size)
    {
        this._size = size;
    }
}

class Program
{
    static void Main()
    {
        Widget widget1 = new Widget(10);
        Widget widget2 = new Widget(20);
    }
}

//base constructor

using System;

public class Bird
{
    public Bird(int value)
    {
        Console.WriteLine($"Bird() called with {value}");
    }
}

public class Parrot : Bird
{
    public Parrot(int value) : base(value)
    {
        Console.WriteLine($"Parrot called with {value}");
    }
}

class Program
{
    static void Main()
    {
        Parrot parrot = new Parrot(450);
        Console.WriteLine(":::DONE:::");
    }
}


//this

using System;

class Mouse
{
    public Mouse() : this(-1, "")
    {
        // Uses constructor initializer.
    }

    public Mouse(int weight, string name)
    {
        // Constructor implementation.
        Console.WriteLine("Constructor weight = {0}, name = {1}",
            weight,
            name);
    }
}

class Program
{
    static void Main()
    {
        // Test the 2 constructors for Mouse type.
        Mouse mouse1 = new Mouse();
        Mouse mouse2 = new Mouse(10, "Sam");
    }
}

using System;

class Test // Has default parameterless constructor
{
    public int Value { get; set; }
}

class Program
{
    static void Main()
    {
        // Call the default constructor.
        Test test = new Test();
        test.Value = 1;
        Console.WriteLine(test != null);
    }
}

using System;

class Test
{
    public Test(int a)
    {
        if (a == 0)
        {
            throw new ArgumentException("Error", "a");
        }
    }
}

class Program
{
    static void Main()
    {
        Test test = new Test(5);
    }
}








