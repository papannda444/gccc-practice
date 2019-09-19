using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int HP = 0;
    [SerializeField] string name = "";
    [SerializeField] string[] skill_name = new string[4];
    [SerializeField] int[] skill_damage = new int[4];
    Skill[] skill = new Skill[4];

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
}
