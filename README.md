<div align=center>

# [Exercism: C# Track](https://exercism.io/tracks/csharp/exercises)

![GitHub last commit (branch)](https://img.shields.io/github/last-commit/ayohana/exercism-cs/master?color=%23DE98B2&style=for-the-badge) ![GitHub language count](https://img.shields.io/github/languages/count/ayohana/exercism-cs?color=%23DE98B2&style=for-the-badge) ![GitHub top language](https://img.shields.io/github/languages/top/ayohana/exercism-cs?color=%23DE98B2&style=for-the-badge)

</div>

<!--
Reminder: Must change netcoreapp in `.csproj` file to version 2.2 as listed below!
````` 
  <PropertyGroup>
    <TargetFramework>netcoreapp2.2</TargetFramework>
  </PropertyGroup>
`````
Otherwise, the tests won't work.
-->

## Learning Resources

### Arrays

* [In C#, arrays are actually objects](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/arrays-as-objects)
* [Initializing Single-Dimensional Array](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays#array-initialization)
* [Initializing Multi-Dimensional Array](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays)

### Strings

* [Structure of interpolated `String`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated#structure-of)
  * Example: `$"Here's some string {withVariable}"`
* [Split `String` into `Array` on multiple characters](https://www.dotnetperls.com/split)

### Dates

* [Adding a `TimeSpan` (interval) to `DateTime` object](https://docs.microsoft.com/en-us/dotnet/api/system.datetime?view=netcore-3.1#methods)

### Implicit Types

* [`new[]` vs `new string[]`](https://stackoverflow.com/questions/14341097/what-is-the-difference-between-new-and-new-string)
* [Implicitly typed arrays by using `new[]`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays)
  * You can create an implicitly-typed array in which the type of the array instance is inferred from the elements specified in the array initializer. The rules for any implicitly-typed variable also apply to implicitly-typed arrays.
* [Implicitly typed variables by using `var`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables)
  * **Local** variables can be declared without giving an explicit type. The `var` keyword instructs the compiler to infer the type of the variable from the expression on the right side of the initialization statement. The inferred type may be a built-in type, an anonymous type, a user-defined type, or a type defined in the .NET class library.
  * It is important to understand that the var keyword does **not** mean "variant" and does not indicate that the variable is loosely typed, or late-bound. It just means that **the compiler determines and assigns the most appropriate type.**
  * The `var` keyword may be used in the following contexts:
    * On local variables (variables declared at method scope).
        `````
        // i is compiled as an int
        var i = 5;

        // s is compiled as a string
        var s = "Hello";

        // a is compiled as int[]
        var a = new[] { 0, 1, 2 };

        // expr is compiled as IEnumerable<Customer>
        // or perhaps IQueryable<Customer>
        var expr =
            from c in customers
            where c.City == "London"
            select c;

        // anon is compiled as an anonymous type
        var anon = new { Name = "Terry", Age = 34 };

        // list is compiled as List<int>
        var list = new List<int>();
        `````
    * In a `for` initialization statement.
        `````
        for (var x = 1; x < 10; x++)
        `````
    * In a `foreach` initialization statement.
        `````
        foreach (var item in list) {...}
        `````
    * In a `using` statement.
        `````
        using (var file = new StreamReader("C:\\myfile.txt")) {...}
        `````

### Floating-Point Types

* [Characteristics of the Floating-Types:](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#characteristics-of-the-floating-point-types)

    | C# type/keyword | Approximate range | Precision | Size     | .NET type |
    | :-------------- | :---------------- | :-------- | :------- | :-------- | 
    | `float` | ±1.5 x 10−45 to ±3.4 x 1038 | ~6-9 digits | 4 bytes | `System.Single` | 
    | `double` | ±5.0 × 10−324 to ±1.7 × 10308 | ~15-17 digits | 8 bytes | `System.Double` | 
    | `decimal` | ±1.0 x 10-28 to ±7.9228 x 1028 | 28-29 digits | 16 bytes | `System.Decimal` | 

* [The type of a real literal is determined by its **suffix**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#real-literals)
  * Examples:
    `````
    // The literal without suffix or with the d or D suffix is of type double
    double d = 3D;
    d = 4d;
    d = 3.934_001;

    // The literal with the f or F suffix is of type float
    float f = 3_000.5F;
    f = 5.4f;

    // The literal with the m or M suffix is of type decimal
    decimal myMoney = 3_000.5m;
    myMoney = 400.75M;
    `````
  * The preceding example also shows the use of **`_` (underscore) as a digit separator**, which is supported starting with C# 7.0.
  * You can also use scientific notation, that is, specify an **exponent** part of a real literal. Example:
    `````
    double d = 0.42e2;
    Console.WriteLine(d);  // output 42

    float f = 134.45E-2f;
    Console.WriteLine(f);  // output: 1.3445

    decimal m = 1.5E6m;
    Console.WriteLine(m);  // output: 1500000
    `````

### Constants vs ReadOnly's

* [Constants are **immutable** values which are known at compile time and **do not change for the life of the program**.](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants)
  * Constants are declared with the `const` modifier. 
  * Use the `readonly` modifier to create a class, struct, or array that is **initialized one time** at runtime (for example in a constructor) and **thereafter cannot be changed.**
    * Example: `public readonly int y = 5;`
    * BAD Example: `public const readonly int y = 5; // ERROR`
* [`const` vs `readonly`](https://stackoverflow.com/questions/55984/what-is-the-difference-between-const-and-readonly-in-c)
  * There is subtle difference:
    | `const` | `readonly` |
    | :--------------------- | :--------------------- |
    | `const`s are implicitly `static`. You use a `ClassName.ConstantName` notation to access them. | `readonly` can be either `instance`-level or `static`. |
    | If you are confident that the value of the constant won't change use a `const`. | If you have a constant that may change (e.g. with respect to precision) or when in doubt, use a `readonly`.|
    | `const` must be initialized at declaration time (therefore can't be changed anywhere). | `readonly` can be initialized on the constructor (and thus have a different value depending on the constructor used). |

