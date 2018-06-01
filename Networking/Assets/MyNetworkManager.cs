using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


    public void MyHostStart()
    {
        Debug.Log(Time.timeSinceLevelLoad + " starting host");
        StartHost();
    }

    public override void OnStartHost ()
    {
        Debug.Log(Time.timeSinceLevelLoad + " host started");
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        Debug.Log(Time.timeSinceLevelLoad + " client has requested");
    }
}
