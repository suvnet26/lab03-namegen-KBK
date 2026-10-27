using Microsoft.VisualBasic;

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


public class PetersNameGenerator : INameGen
{
    public string NameToString()
    {
        return $"You are borg designation: {Random.Shared.Next(1, 10)} of {Random.Shared.Next(1, 10)}";
    }
}

public class VIldaDjur : INameGen
{
    private readonly List<string> vildaDjur = new()
    {
        "Älg","Rådjur","Dovhjort","Kronhjort","Vildsvin","Hare","Lodjur"
    };

    public string NameToString()
    {
        return vildaDjur[Random.Shared.Next(vildaDjur.Count)];
    }
}
