using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraControlTD : NetworkBehaviour {

    public float speed = 0.1f;
    public float sprintMultipier = 1.0f;    //A value of 1 means sprint speed is double normal speed

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!isLocalPlayer)
            return;

        float sprint = sprintMultipier * Input.GetAxis("Sprint") + 1;
        
        /*float horizontal = Input.GetAxis("Horizontal") * speed * sprint;
        float vertical = Input.GetAxis("Vertical") * speed * sprint;

        horizontal *= Time.deltaTime;
        vertical *= Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);*/

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f * speed * sprint;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f * speed * sprint;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
