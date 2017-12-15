# Exception Handling in C#

## What are Exceptions ?

In C#, Exceptions are **objects**. They inherit the base ``System.Exception`` class, or any child class inheriting the ``System.Exception`` base class.

You can implement your own Exception class, but the framework provides a set of commonly used exceptions that should be preferred if they match your situation.

The base `Exception` class provides three main properties:

* **Message**: a message that describes the exception
* **StackTrace**: the stack of method calls that was being executed when the exception occured
* **InnerException**: when catching exception, can contain a more detailed exception that was catched

## Managing Exceptions

In your program execution flow, you will eventually use methods that could throw exceptions. Unhandled exceptions will halt your process and crash the application, thus managing the potential thrown exceptions is a key to have a stable application.

Catching thrown exceptions in a block of code in done with the `try ... catch` block code :

```C#
try 
{
    // execute some code that could throw an exception
}
catch (Exception ex)
{
    // handle the thrown exception here
}
```

You can handle multiple exceptions types in the same `try ... catch` block code :

```C#
try 
{
    ...
}
catch (FileNotFoundException)
{
    ...
}
catch (InvalidArgumentException)
{
    ...
}
```

When handling the exception, you have multiple options:

* Silently managing the exception
* Re-throwing the catched exception as it was originally thrown
* Throwing another exception

## The `finally` keyword

When managing exception, there may be some part of the code that you want to execute, even if the main code has thrown an exception.

The `finally` keyword allows you to specify a code block that must be executed in any case, with or without exceptions. This can be useful, typically in scenarios where you are using resources (database, file i/o, ...).

```C#
try 
{
    // execute some code that could throw an exception
}
catch (Exception ex)
{
    // handle the thrown exception here
}
finally
{
    // dispose my resources here
}
```

## Exception filters

With C# 6.0, a new feature targetted at exception handling has been added. This feature is the exception filter.

Exception filters allow you to specify a condition that will need to be matched in order to run the `catch` block code.

**Example**

```C#
try 
{
    // execute some code that could throw an exception
}
catch (Exception ex) when (ex.Message != null)
{
    // handle the thrown exception here
}
```

Please note that if the exception filter is not matched when evaluating the exception, the stack will not be modified, which is preferred to re-throwing the exception from the `catch` block.

## Complete example

```C#
try 
{
    ExecuteMyCode();
}
catch (WhateverException)
{
    DoSomething();
    throw; // re-throw the same exception
}
catch (InvalidOperationException)
{
    DoSomething(); // just handle the exception, return to normal execution flow
}
catch (ArgumentException ex)
{
    throw new InvalidOperationException("Use a more friendly message", ex);
    // throw a new exception with a reference to the original
}
catch (ArgumentNullException ex) when (ex.ParamName == "MyParameter")
{
    DoSomething();
}
finally
{
    AlwaysExecuteMe();
}
```


## When to use Exceptions ?

Exceptions must be used for:

* For an exceptional event in the program flow
* For an unexpected event in the program flow

Exceptions should not be used for:

* Returning an expected result
* As a control flow mechanism

