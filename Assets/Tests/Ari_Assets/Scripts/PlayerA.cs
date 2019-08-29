using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : Player
{
    PlayerA()
    {
        HealthPoint = 100;
        MagicPoint = 100;
        AttackPower = 5;
        SpecialAttackPower = 20;
        AddCommands(CommandType.FireBall,
                    CommandType.Cure);
    }

    public void PrintVal()
    {
        Debug.Log(HealthPoint);
        Debug.Log(MagicPoint);
        Debug.Log(AttackPower);
        Debug.Log(SpecialAttackPower);
        foreach(var command in Commands)
        {
            Debug.Log(command);
        }
    }
}
