using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleEvents : MonoBehaviour
{
    public static Action<Transform> transmit;
    public static Action<int> figure;
    public static Action rotate, pass;
}
