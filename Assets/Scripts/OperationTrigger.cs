using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationTrigger : MonoBehaviour
{
    bool inArea;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") inArea = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") inArea = false;
    }
    private void Update()
    {
        bool interact = TempleStates.gameInputActions.Player.Interact.IsPressed();
        if(inArea && interact){
            TempleEvents.rotate?.Invoke();
        }
            
    }
}
