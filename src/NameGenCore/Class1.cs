namespace NameGenCore;


public class Class1
{

}

public interface INameGen
{
    public string NameToString();
}

public class OneNameGenerator : INameGen
{
    public string NameToString()
    {
        return "hej";
    }

}

public class PetersNameGenerator : INameGen
{
    public string NameToString()
    {
        return $"You are borg designation: {Random.Shared.Next(1, 10)} of {Random.Shared.Next(1, 10)}";
    }
}