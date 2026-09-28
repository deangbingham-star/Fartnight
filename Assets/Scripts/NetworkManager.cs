using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Unity.VisualScripting;


public class NetworkManager : MonoBehaviourPunCallbacks
{
    public static NetworkManager instance;
    public int maxPlayers = 10;

    void Awake()
    {
        //instance = This;
        //DontDestroyOnLoad(gameObject);
        if (instance != null && instance != this)
            gameObject.SetActive(false);
        else
        {
            // set the instance
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
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

}



