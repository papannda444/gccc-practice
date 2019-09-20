using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySideController : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    /// <summary>
    /// 戦闘中の敵を入れる配列
    /// </summary>
    public GameObject[] ExistEnemies;

    /// <summary>
    /// 生成中の敵の番号を保持
    /// </summary>
    int enemyCount = -1;

    /// <summary>
    /// 敵を生成する座標の上限（X座標）
    /// </summary>
    [SerializeField] float posMaxX;
    /// <summary>
    /// 敵を生成する座標の下限（X座標）
    /// </summary>
    [SerializeField] float posMinX;
    /// <summary>
    /// 敵を生成する座標の上限（Y座標）
    /// </summary>
    [SerializeField] float posMaxY;
    /// <summary>
    /// 敵を生成する座標の下限（Y座標）
    /// </summary>
    [SerializeField] float posMinY;


    // Start is called before the first frame update
    void Start()
    {
        CreateEnemies(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 引数の数敵を生成
    /// </summary>
    /// <param name="value">生成する敵数</param>
    public void CreateEnemies(int value)
    {
        float yLength = posMaxY - posMinY;

        for(int i = 0; i < value; i++)
        {
            float x = (i % 2 == 0) ? posMaxX : posMinX;
            float y = posMinY + ((yLength / value) * i);

            Instantiate(SelectEnemy(), new Vector2(x, y), Quaternion.identity);
        }
    }
    /// <summary>
    /// 配列の上から順に敵を返す
    /// </summary>
    GameObject SelectEnemy()
    {
        enemyCount++;

        //配列を超えれば0に戻す
        if (enemyCount >= enemies.Length)
        {
            enemyCount = 0;
        }

        return enemies[enemyCount];
    }

    /// <summary>
    /// 敵を全員倒したかを返す
    /// </summary>
    /// <returns></returns>
    public bool AllDefeat()
    {
        for(int i = 0; i < ExistEnemies.Length; i++)
        {
            //戦闘中の敵のHPが一体でも0より大きいならfalseを返す
            if (ExistEnemies[i].GetComponent<EnemyController>().Hp > 0)
            {
                return false;
            }
        }

        //全員HPが0以下ならtrueを返す
        return true;
    }
}
