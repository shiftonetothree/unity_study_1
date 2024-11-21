using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player, rotateCube;
    public GameObject[] lights;
    public GameObject fence;
    void Start()
    {
        Debug.Log("start");
        TempleEvents.transmit += pos =>
        {
            Debug.Log("recive event");
            player.position = pos.position;
            player.rotation = pos.rotation;
        };
        Debug.Log(TempleEvents.transmit);
        TempleEvents.figure += index =>
        {
            TempleStates.SetMachineState(index);
            lights[index].SetActive(false);
        };
        TempleEvents.rotate += () => rotateCube.Rotate(Vector3.up * 45, Space.Self);
        TempleEvents.pass += () => fence.SetActive(false);
    }
}
