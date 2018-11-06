using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class eventMenu : MonoBehaviour {

    public NetWorkUI nwu;
    public Button host;
    public Button client;

    // Use this for initialization
    void Start()
    {
        host.onClick.AddListener(delegate { nwu.StartupHost(); });
        client.onClick.AddListener(delegate{nwu.JoinGame(); });
    }
	
	// Update is called once per frame
	void Update () {
    }
}
