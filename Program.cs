
// REF KEYWORD WITH A VALUE TYPE
void Method(int argument)
{
    argument = argument + 10;
}

void MethodByRef(ref int argument)
{
    argument = argument + 100;
}


int number = 1;


Method(number);
Console.WriteLine(number);

MethodByRef(ref number);
Console.WriteLine(number);


Console.WriteLine();


// REF KEYWORD WITH A REFERENCE TYPE

var user = new User() { Name = "Harry Potter" };

MethodWithoutRef(user);

Console.WriteLine(user.Name);

MethodWithRef(ref user);

Console.WriteLine(user.Name);

void MethodWithoutRef(User user)
{
    user = new User() { Name = "Harry Potter without Ref" };
}

void MethodWithRef(ref User user)
{
    user = new User() { Name = "Harry Potter with Ref" };
}

public class User
{
    public string Name { get; set; }
}