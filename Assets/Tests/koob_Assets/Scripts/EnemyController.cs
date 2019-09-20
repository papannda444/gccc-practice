using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int hp = 0;
    [SerializeField] string enemyName = "";
    [SerializeField] string[] skillName;
    [SerializeField] int[] skillDamage;
    Skill[] skills;


    public int Hp
    {
        get { return hp; }
    }

    public string Name
    {
        get { return enemyName; }
    }


    // Start is called before the first frame update
    void Start()
    {
        //エラーを防ぐためスキル名配列、ダメージ配列の短いほうをもとにスキル配列を作る
        int a = Mathf.Min(skillName.Length, skillDamage.Length);
        skills = new Skill[a];

        for(int i = 0; i < skills.Length; i++)
        {
            skills[i] = new Skill(skillDamage[i], skillName[i]);
        }

        SkillLog();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Skill GetSkill(int i)
    {
        return skills[i];
    }

    /// <summary>
    /// デバッグ用
    /// </summary>
    void SkillLog()
    {
        for(int i = 0; i < skills.Length; i++)
        {
            Debug.Log(skills[i].Name + ":" + skills[i].Damage);
        }
    }

    /// <summary>
    /// ダメージ処理用
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(int damage)
    {
        hp -= damage;

        if (hp < 0)
        {
            hp = 0;
        }
    }
}
