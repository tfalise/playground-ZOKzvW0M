# Exception Handling - Exercises

**Catching a generic exception**

Modify the code to catch any exception thrown by the method.

@[Catching a generic exception]({"stubs": ["Exercises/ExceptionHandling/Exercise01.cs"], "command": "ExceptionHandling.Exercise01Tests.VerifyExceptionIsCatched"})

**Catching a specific exception type** 

Modify the code to implement the following rules:

* If a `ArgumentNullException` is thrown by the `CreateXlsFile()` method is thrown, it should be catched and handled to continue the execution flow
* If another exception is thrown, it should not be catched

@[Catching a specific exception]({"stubs": ["Exercises/ExceptionHandling/UserXlsReport.cs"], "command": "ExceptionHandling.Exercise02Tests.VerifyItCatchesTheRightExceptionType"})

@[Pass argument by reference]({"stubs": ["Exercises/ExceptionHandling/ValueTypes.cs"], "command": "Tests.ValueTypeTests.VerifyArgumentByReference"})