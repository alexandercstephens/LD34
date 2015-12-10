using UnityEngine;
using System.Collections;

public class TestMovement : MonoBehaviour {
    public float speed = 3.0f;
    public float rotSpeed = 3.0f;

    CharacterController controller;
    
	void Awake () {
        controller = GetComponent<CharacterController>();
	}
	
	void Update () {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed, 0);
        controller.SimpleMove(transform.forward * Input.GetAxis("Vertical") * speed);
	}
}
