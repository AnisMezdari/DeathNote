using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetWorkUI : NetworkManager {

   

    public void StartupHost()
    {
        Debug.Log("tessstt");
        SetPort();   
        NetworkManager.singleton.StartHost();
    }

    public void JoinGame()
    {
        SetIPAddress();
        SetPort();
        NetworkManager.singleton.StartClient();
   
    }
    public void SetIPAddress()
    {
        string ipAddress = GameObject.Find("fieldText").transform.GetComponent<Text>().text;
        NetworkManager.singleton.networkAddress = ipAddress;
    }
   void SetPort()
    {
        NetworkManager.singleton.networkPort = 24580;
    }
}
