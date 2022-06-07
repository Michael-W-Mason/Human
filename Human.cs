public class Human
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string name){
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    // Add a constructor to assign custom values to all fields
    public void SetStats(string name, int str, int intel, int dex, int health){
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = health;
    }
    // Build Attack method
    public int Attack(Human target)
    {
        target.Health = target.Health - this.Strength;
        return target.Health;
    }
}

