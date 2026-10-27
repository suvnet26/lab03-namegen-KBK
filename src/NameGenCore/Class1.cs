namespace NameGenCore;

public class Class1
{

}

public interface INameGen
{
    string ToString();
}

public class OneNameGenerator : INameGen
{
    string ToString()
    {
        return "hej";
    }

}


