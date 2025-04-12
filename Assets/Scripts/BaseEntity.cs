using UnityEngine;

public class BaseEntity : MonoBehaviour
{
    private string entityName;
    private int life;
    private float attack;
    private float defense;

    public string EntityName => entityName;
    public int Life => life;
    public float Attack => attack;
    public float Defense => defense;

    public void setAttack(float NewAttack)
    {
        attack = NewAttack;
    }
    public void setLife(int NewLife)
    {
        life = NewLife;
    }
    public void setDefense(float NewDefense)
    {
        defense = NewDefense;
    }


    public BaseEntity(string _name, int _life, float _attack, float _defense)
    {
        entityName = _name;
        life = _life;
        attack = _attack;
        defense = _defense;
    }
}
