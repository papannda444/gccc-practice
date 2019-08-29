using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected int HealthPoint, MagicPoint;
    protected int AttackPower, SpecialAttackPower;
    protected List<CommandType> Commands = new List<CommandType>();

    //private Animator anim;

    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*コマンド指定された際の操作
        アニメーショントリガーの"Attack"がTrue→anim.Play ("Attak_Move");
        アニメーショントリガーの"Comand"がTrue→anim.Play ("Comand_Move");
        アニメーショントリガーの"SpecialAttack"がTrue→anim.Play ("SpecialAttack_Move");
        */
    }

    protected void AddCommands(params CommandType[] commands)
    {
        foreach (var command in commands)
        {
            Commands.Add(command);
        }
    }
}

public enum CommandType
{
    FireBall, IcicleLance, StoneBullet, Cure
}