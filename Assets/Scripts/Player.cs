using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update

    void OnEnable(){
        TempleStates.gameInputActions.Enable();
    }

    void OnDisable(){
        TempleStates.gameInputActions.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 move = TempleStates.gameInputActions.Player.Move.ReadValue<Vector2>();
        Vector2 head = TempleStates.gameInputActions.Player.Head.ReadValue<Vector2>();
        // Debug.Log(move);
        if (move.y > 0) transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed);
        if (move.y < 0) transform.Translate(Vector3.back * Time.fixedDeltaTime * speed);
        if (move.x < 0) transform.Translate(Vector3.left * Time.fixedDeltaTime * speed);
        if (move.x > 0) transform.Translate(Vector3.right * Time.fixedDeltaTime * speed);
        if (head.x < 0) transform.Rotate(Vector3.down);
        if (head.x > 0) transform.Rotate(Vector3.up);

        // if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed);
        // if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * Time.fixedDeltaTime * speed);
        // if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * Time.fixedDeltaTime * speed);
        // if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * Time.fixedDeltaTime * speed);
        // if (Input.GetKey(KeyCode.Q)) transform.Rotate(Vector3.down);
        // if (Input.GetKey(KeyCode.E)) transform.Rotate(Vector3.up);
    }
}
