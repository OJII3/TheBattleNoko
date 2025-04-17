using System;
using NokoWars_test.Core.Interface;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using TMPro;

public class SetupUIManager : MonoBehaviour
{
    [Inject] IScene setupSceneManager;
    [Inject] INetworkManager networkManager;
    [SerializeField] private TMP_InputField Input_PeerIP;
    [SerializeField] private TMP_InputField Input_PeerPort;
    
    private string ip = "127.0.0.1";
    private int port = 8080;

    public void Register()
    {
        ip = Input_PeerIP.text;
        port = int.Parse(Input_PeerPort.text.Length==0?"8080":Input_PeerPort.text);
        Debug.Log(Input_PeerIP.text);
        Debug.Log(Input_PeerPort.text);
        networkManager.setPeerAddress(new Tuple<string, int>(ip, port));
    }
}
