namespace method_obj_return.farm;

public class Chicken
{
    private string _name;
    private int _eggber;
    
    public Chicken(string name, int eggber)
    {
        this._name = name;
        this._eggber = eggber;
    }

    public Egg CreateEgg()
    {
        return new Egg(_name,_eggber);
    }
}