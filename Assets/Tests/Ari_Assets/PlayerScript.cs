using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int Health = 100;
    public int Attack = 5, Comand = 10, SpecialAttack = 20;
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
}
