# Introduction to C# Linq

## What is Linq

Linq is a compiled query language inside C# language. It allows developers to create complex queries on enumerable collections with dynamic criterias.

Linq is based on other C# features:
* Query expressions
* Implicitly typed variables
* Object and collection initializers
* Anonymous types
* Extension methods
* Lambda expressions

Linq also provides several implementations available to use in your code:
* Linq to objects
* Linq to Entities
* Linq to XML

## Query expressions

Query expressions is a C# language feature that allows the developer to write queries on enumerable objects.
It uses a syntax close to SQL language, using keywords like `select`, `from`, `where`, `orderby`, ...

**Important**

Queries written using the query expression syntax have a **deferred execution**, which means they will be executed when the collection will be iterated, not when the query is created.

```c# runnable
// { autofold 
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
// }
        var listOfIntegers = new List<int> { 1, 2, 3 };

        var enumerable = from integer in listOfIntegers
                            select integer.ToString();

        listOfIntegers.Add(4);

        foreach (var integer in enumerable)
        {
            Console.WriteLine(integer);
        }
// { autofold 
    }
}
// }
```