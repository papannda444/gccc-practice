using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int _HP = 0;
    [SerializeField] string _name = "";
    [SerializeField] string[] skill_name = new string[4];
    [SerializeField] int[] skill_damage = new int[4];
    Skill[] skill = new Skill[4];


    public int HP
    {
        get { return _HP; }
    }

    public string NAME
    {
        get { return _name; }
    }


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 4; i++)
        {
            skill[i] = new Skill(skill_damage[i], skill_name[i]);
        }

        SkillLog();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Skill GetSkill(int i)
    {
        return skill[i];
    }

    /// <summary>
    /// デバッグ用
    /// </summary>
    void SkillLog()
    {
        for(int i = 0; i < 4; i++)
        {
            Debug.Log(skill[i].NAME + ":" + skill[i].DAMAGE);
        }
    }

    /// <summary>
    /// ダメージ処理用
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(int damage)
    {
        _HP -= damage;

        if (_HP < 0)
        {
            _HP = 0;
        }
    }
}
