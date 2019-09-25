using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// スキル用クラス
/// </summary>
[System.Serializable]
public class Skill
{
    public int Damage;
    public string Name;

    public Skill(int damage ,string name)
    {
        Damage = damage;
        Name = name;
    }
}
