using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int hp = 0;
    [SerializeField] string enemyName = "";
    [SerializeField] Skill[] skills;


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
        SkillLog();
    }

    // Update is called once per frame
    void Update()
    {
        
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

    /// <summary>
    /// 攻撃対象の配列での順番を返す
    /// </summary>
    /// <param name="value">攻撃対象の配列の長さ</param>
    /// <returns></returns>
    public int SelectTarget(int value)
    {
        return Random.Range(0, value);
    }

    /// <summary>
    /// 使用スキルをランダムで返す
    /// </summary>
    /// <returns></returns>
    public Skill SelectSkill()
    {
        return skills[Random.Range(0, skills.Length)];
    }

}
