using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
    public Transform targetPose;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player"){
            TempleEvents.transmit?.Invoke(targetPose);
            Debug.Log(TempleEvents.transmit);
        }
            
    }
}
