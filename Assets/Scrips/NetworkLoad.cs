using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetworkLoad : MonoBehaviour {

    //public Button b;
    public InputField ip;
    public InputField port;
    public NetworkManager manager;

    void Awake()
    {
        Debug.Log("Loading Network Manager");
        //manager = GetComponent<NetworkManager>();
        Debug.Log(manager.networkAddress);
    }

    public void startClient()
    {
        int intPort = 0;
        if (Int32.TryParse(port.text.ToString(), out intPort))
        {
            Debug.Log("Starting on Client Port:");
            Debug.Log(intPort);
        }
        else
            Debug.Log("Could not parse Port");

        /*Network.Connect("localhost", 7777);
        Debug.Log("Connecting to server");
        Debug.Log(ip.text);*/

        manager.networkPort = intPort;
        manager.networkAddress = ip.text.ToString();

        manager.StartClient();

    }

    public void startServer()
    {
        int intPort = 0;
        if (Int32.TryParse(port.text.ToString(), out intPort))
        {
            Debug.Log("Starting on Server Port:");
            Debug.Log(intPort);
        }
        else
            Debug.Log("Could not parse Port");

        bool useNat = !Network.HavePublicAddress();
        /*Network.InitializeServer(32, 7777, false);
        Debug.Log("Server started");*/

        manager.networkPort = intPort;
        manager.networkAddress = ip.text.ToString();


        manager.StartServer();
    }

    public void startLan()
    {
        int intPort = 0;
        if (Int32.TryParse(port.text.ToString(), out intPort))
        {
            Debug.Log("Starting on Server Port:");
            Debug.Log(intPort);
        }
        else
            Debug.Log("Could not parse Port");

        //manager.networkPort = intPort;
        //manager.networkAddress = ip.text.ToString();

        //manager.StartServer();
        //manager.StartClient();
        manager.StartHost();

    }

}
