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