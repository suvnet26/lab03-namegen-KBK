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
