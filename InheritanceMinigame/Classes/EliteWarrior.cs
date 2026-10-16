using InheritanceMinigame.Classes;

public class EliteWarrior : Warrior
{
    public EliteWarrior(string name) : base(name)
    {
        ShieldBlock *= 2;
        AttackPower *= 2; //AttackPower = AttackPower *2
    }
}