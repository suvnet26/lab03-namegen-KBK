using Microsoft.VisualBasic;

namespace NameGenCore;


public class Class1
{

}

public interface INameGen
{
    string NameToString();
}

public class OneNameGenerator : INameGen
{
    public string NameToString()
    {
        return "hej";
    }

}
public class JNamesGenerator : INameGen
{
    private static readonly string[] jnames = {"Johannes", "Johan","Jurgurt","Jeter","Jax","Jistroffer"};

    Random random = new Random();

    string jname = jnames[Random.Shared.Next(0, jnames.Length)];

    public string NameToString()
    {
        foreach (string jname in jnames)
        {
            Console.WriteLine(jname);
        }

        return $"{jnames}";
    }
}




