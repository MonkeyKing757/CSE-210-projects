public class Cake
{
    private string _flavor;

    public Cake(string flavor)
    {
        _flavor = flavor;
    }

    public void Taste()
    {
        Console.WriteLine($"mmmm, mmmm, goooooood. {_flavor} is the best!");
    }
}