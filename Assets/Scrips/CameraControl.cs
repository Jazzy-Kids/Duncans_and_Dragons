using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraControl : NetworkBehaviour {

    public float speed = 10.0f;
    public float sprintMultipier = 2.0f;    //A value of 1 means sprint speed is double normal speed
    public Camera cam;


	// Use this for initialization
	void Start () {
        Debug.Log(isLocalPlayer);

        if (!isLocalPlayer)
            cam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (!isLocalPlayer)
            return;


        float sprint = sprintMultipier * Input.GetAxis("Sprint") + 1;
        
        float horizontal = Input.GetAxis("Horizontal") * speed * sprint;
        float vertical = Input.GetAxis("Vertical") * speed * sprint;

        horizontal *= Time.deltaTime;
        vertical *= Time.deltaTime;

        transform.Translate(horizontal, vertical, 0);
	}
}
