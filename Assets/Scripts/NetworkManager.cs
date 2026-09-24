using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Unity.VisualScripting;




public interface maxPlayers = 10;


public class NetworkManager : MonoBehaviourPunCallbacks


public class NetworkManager instance;
{

}


void Awake()
{
    instance = This;
    DontDestroyOnLoad(gameObject);
}

void Start()
{
    PhotonNetwork.ConnectUsingSettings();

}

public void CreateRoom (string roomName)
{
    RoomOptions options = new RoomOptions();
    options.MaxPlayers = (byte)maxPlayers;

    PhotonNetwork.CreateRoom(roomName, options);
}

public void ChangeScene (string sceneName)
{
    PhotonNetwork.LoadLevel(sceneName);
}