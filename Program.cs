Console.WriteLine("**********  Game Developer I  **********");

// ENEMY INSTANCES
Enemy Marowak = new("Marowak");

// ATTACK INSTANCES
Attack BodySlam = new("Body Slam", 15);
Attack Bonemerang = new("Bonemerang", 10);
Attack DoubleEdge = new("Double-Edge", 25);

// ATTACK ASSIGNMENT
Marowak.AddAttack(BodySlam);
Marowak.AddAttack(Bonemerang);
Marowak.AddAttack(DoubleEdge);


// TESTING
Console.WriteLine("--- Pokemon ---");
Console.WriteLine($"Name: {Marowak.Name}\nHealth: {Marowak.Health}");
Console.WriteLine("--- Attacks ---");
foreach (Attack entry in Marowak.AttackList)
{
    Console.WriteLine($"{entry.Name}, {entry.DamageAmount}");
}
Console.WriteLine("--- Marowak Attacks! ---");
Marowak.RandomAttack();