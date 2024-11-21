using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TempleStates : MonoBehaviour
{

    public static GameInputActions gameInputActions = new GameInputActions();
        
    static bool[] figured = new bool[2];
    public static void SetMachineState(int index)
    {
        if (index < 0 || index>= figured.Length) return;
        figured[index] = true;
        foreach(bool f in figured)
            if(!f)return;
        if (TempleEvents.pass != null)
            TempleEvents.pass();
    }

}
