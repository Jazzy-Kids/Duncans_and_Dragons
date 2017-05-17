using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Escape : MonoBehaviour {

    public GameObject canvas;
    private bool paused = false;


	// Use this for initialization
	void Start () {
        
        //if (!isLocalPlayer)
            //return;

        canvas.gameObject.SetActive(false);
        Debug.Log("Escape Start()");

	}
	
	// Update is called once per frame
	void Update () {

       // if (!isLocalPlayer)
          //  return;

        if (Input.GetKeyDown("escape"))
        {

            Debug.Log("Pause Pressed");
            if (paused)
            {
                canvas.gameObject.SetActive(false);
                paused = false;

            }
            else
            {
                canvas.gameObject.SetActive(true);
                paused = true;
            }
        }
	}

    public void resume()
    {
        //if (!isLocalPlayer)
            //return;
        canvas.gameObject.SetActive(false);
        paused = false;
    }

}
