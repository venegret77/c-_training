namespace RPG;

public class Hero
{
    public string Role { get; init; }
    public string Name { get; init; }
    public double Hp { get; set; }
    public double Damage { get; set; }
    
    
    public Hero(string role, string name, double hp, double damage)
    {
        Role = role;
        Name = name;
        Hp = hp;
        Damage = damage;
    }
}