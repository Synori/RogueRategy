using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ReverseControll : BuffCore
{
    public float speedRatio;
    public override void Process(StatusBase statusBase)
    {
        ((PlayerStatus)statusBase).isControllReverse = true;
    }
}
