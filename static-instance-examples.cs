using System;

class Program
{
    static void MethodA()
    {
        Console.WriteLine("Static method");
    }

    void MethodB()
    {
        Console.WriteLine("Instance method");
    }

    static char MethodC()
    {
        Console.WriteLine("Static method");
        return 'C';
    }

    char MethodD()
    {
        Console.WriteLine("Instance method");
        return 'D';
    }

    static void Main()
    {
        // ... Call the 2 static methods on the Program type.
        Program.MethodA();
        Console.WriteLine(Program.MethodC());

        // ... Create a new Program instance and call the 2 instance methods.
        Program programInstance = new Program();
        programInstance.MethodB();
        Console.WriteLine(programInstance.MethodD());
    }
}


/// <summary>
/// This type has a static constructor.
/// </summary>
static class HasStaticConstructor
{
    /// <summary>
    /// Public field.
    /// </summary>
    public static int _test;

    /// <summary>
    /// Static constructor initializes public field.
    /// </summary>
    static HasStaticConstructor()
    {
        _test = 1;
    }
}

/// <summary>
/// This type has no static constructor.
/// </summary>
static class NoStaticConstructor
{
    /// <summary>
    /// Public field initialized inline.
    /// </summary>
    public static int _test = 1;
}

class Program
{
    static void Main()
    {
        System.Console.WriteLine(HasStaticConstructor._test);
        System.Console.WriteLine(NoStaticConstructor._test);
    }
    
    
    using System;

class Program
{
    static void Main()
    {
        // Cannot declare a variable of type Perl.
        // This won't blend.
        // Perl perl = new Perl();

        // Program is a regular class so you can create it.
        Program program = new Program();

        // You can call static methods inside a static class.
        Perl._ok = true;
        Perl.Blend();
    }
}

static class Perl
{
    // Cannot declare instance members in a static class!
    // int _test;

    // This is ok.
    public static bool _ok;

    // Can only have static methods in static classes.
    public static void Blend()
    {
        Console.WriteLine("Blended");
    }
}
    
    //static int array
    
    using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Use the public function to test static array
        bool isWagstaff = NumberTest.IsWagstaffPrime(43);
        Console.WriteLine(isWagstaff);

        // Test static array again
        isWagstaff = NumberTest.IsWagstaffPrime(606);
        Console.WriteLine(isWagstaff);
    }
}

/// <summary>
/// Contains static int array example.
/// </summary>
public static class NumberTest
{
    /// <summary>
    /// This static array contains several Wagstaff primes.
    /// </summary>
    static int[] _primes = { 3, 11, 43, 683, 2731 };

    /// <summary>
    /// Public method to test private static array.
    /// </summary>
    public static bool IsWagstaffPrime(int i)
    {
        return _primes.Contains(i);
    }
}
  
    
    
    //static array
    
    using System;

class Program
{
    static void Main()
    {
        foreach (string dog in StringTest.Dogs)
        {
            Console.WriteLine(dog);
        }
    }
}

/// <summary>
/// Contains static string array.
/// </summary>
public static class StringTest
{
    /// <summary>
    /// Array of dog breeds.
    /// </summary>
    static string[] _dogs = new string[]
    {
        "schnauzer",
        "shih tzu",
        "shar pei",
        "russian spaniel"
    };

    /// <summary>
    /// Get array of dog breeds publicly.
    /// </summary>
    public static string[] Dogs
    {
        get
        {
            return _dogs;
        }
    }
}
    
  //static dictionary
    
    using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Write pluralized words from static Dictionary
        Console.WriteLine(PluralStatic.GetPlural("game"));
        Console.WriteLine(PluralStatic.GetPlural("item"));
        Console.WriteLine(PluralStatic.GetPlural("entry"));
    }
}

/// <summary>
/// Contains plural logic in static class [separate file]
/// </summary>
static class PluralStatic
{
    /// <summary>
    /// Static string Dictionary example
    /// </summary>
    static Dictionary<string, string> _dict = new Dictionary<string, string>
    {
        {"entry", "entries"},
        {"image", "images"},
        {"view", "views"},
        {"file", "files"},
        {"result", "results"},
        {"word", "words"},
        {"definition", "definitions"},
        {"item", "items"},
        {"megabyte", "megabytes"},
        {"game", "games"}
    };

    /// <summary>
    /// Access the Dictionary from external sources
    /// </summary>
    public static string GetPlural(string word)
    {
        // Try to get the result in the static Dictionary
        string result;
        if (_dict.TryGetValue(word, out result))
        {
            return result;
        }
        else
        {
            return null;
        }
    }
}
  
    //static regex
    
    using System;
using System.Text.RegularExpressions;

class Program
{
    static Regex _rWord = new Regex(@"R\w*");

    static void Main()
    {
        // Use the input string.
        // ... Then try to match the first word starting with capital R.
        string value = "This is a simple /string/ for Regex.";
        Match match = _rWord.Match(value);
        Console.WriteLine(match.Value);
    }
}

    
    //static string
    
    using System;

class Program
{
    static string _example;

    static void Main()
    {
        //
        // Check initial value of static string.
        //
        if (_example == null)
        {
            Console.WriteLine("String is null");
        }
        //
        // Assign static string to value.
        //
        _example = 1000.ToString();
        //
        // Display value of string.
        //
        Console.WriteLine("--- Value, Main method ---");
        Console.WriteLine(_example);
        //
        // Call this method.
        //
        Read();
    }

    static void Read()
    {
        //
        // Display value of string.
        //
        Console.WriteLine("--- Value, Read method ---");
        Console.WriteLine(_example);
    }
}

    
    
    
    

    
    
    
    