using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// スキル用クラス
/// </summary>
public class Skill
{
    int damage;
    string name;

    public Skill(int _damage ,string _name)
    {
        damage = _damage;
        name = _name;
    }

    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
