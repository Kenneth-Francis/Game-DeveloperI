
class Enemy
{ 
    public string Name;
    private int   _Health;
    public int    Health
    {
        get {return _Health;}
    }
    public List<Attack> AttackList;

    public Enemy(string name, int health = 100)
    {
        Name       = name;
        _Health    = health;
        AttackList = new();
    }

    public void AddAttack(Attack newAttack)
    {
        AttackList.Add(newAttack);
    }

    public void RandomAttack()
    {
        Random randNum = new();
        Attack randAttack = AttackList[ randNum.Next(AttackList.Count) ];
        Console.WriteLine($"{this.Name} uses {randAttack.Name}, it deals {randAttack.DamageAmount} damage!");
    }
}
