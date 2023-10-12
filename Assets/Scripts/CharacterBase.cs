using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Character", menuName = "Character/Create new Character")]
public class CharacterBase : ScriptableObject
{
    [SerializeField] string nameChar;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] charType type1;
    [SerializeField] charType type2;

    // Base Stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int deffense;
    [SerializeField] int spAttack;
    [SerializeField] int spDeffense;
    [SerializeField] int speed;
    [SerializeField] Animation idleAnim;
    [SerializeField] Animator animator;

    public string Name
    {
        get { return nameChar; }
    }

    public string Description
    {
        get { return description; }
    }


    public charType Type1
    {
        get { return type1; }
    }

    public charType Type2
    {
        get { return type2; }
    }

    public int MaxHP
    {
        get { return maxHp; }
    }

    public int Attack
    {
        get { return attack; }
    }

    public int Deffense
    {
        get { return deffense; }
    }

    public int SPAttack
    {
        get { return spAttack; }
    }

    public int SPDeffense
    {
        get { return spDeffense; }
    }

    public int Speed
    {
        get { return speed; }
    }

}

public enum charType
{
    None,
    Fire,
    Water,
    Wind,
    Ice, 
    Yin,
    Yang
}
