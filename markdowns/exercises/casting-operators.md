# Using casting operators

With C#, you can define custom casting implementation between two types. This implementation will be used when casting from one type to the other in your code.

```C# runnable
// { autofold
using System;
// }

// User definition
// { autofold
public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public static implicit operator String(User user)
    {
        return $"{user.FirstName} {user.LastName}";
    }

    public static explicit operator User(string text)
    {
        int spaceIndex = text.IndexOf(" ");
        if(spaceIndex >= 1)
        {
            return new User 
            {
                FirstName = text.SubString(0, spaceIndex),
                LastName = text.SubString(spaceIndex + 1)
            };
        }
        return new User { LastName = text };
    }
}
// }

public class Program 
{
    public static void Main(string[] args)
    {
        var user = new User {
            FirstName = "John",
            LastName = "Doe"
        };

        // implict casting
        string userAsString = user;
        Console.WriteLine($"userAsString: {userAsString}");

        // explicit casting
        var otherUser = (User)userAsString;
        Console.WriteLine("User:");
        Console.WriteLine($"  First name: {otherUser.FirstName}");
        Console.WriteLine($"  Last name: {otherUser.LastName}");
    }
}
```