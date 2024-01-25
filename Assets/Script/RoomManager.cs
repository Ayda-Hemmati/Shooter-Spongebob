using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;

public class RoomManager : MonoBehaviourPunCallbacks
{
   public static RoomManager instance;
   public GameObject Player;
   public Image loadingObject;
   public TextMeshProUGUI textLoading;
   public float persent;
   
   public float speed;
   public float minint;
   public float maxint;
  

   public int loadingOver = 100;
   // [Space]
   // public Transform spawnPoint;

     [Space]
     public GameObject roomcam;

    void Awake(){
        instance = this;
    }

    void Start()
    {
        Debug.Log("Connecting...");

         PhotonNetwork.ConnectUsingSettings();
         speed = Random.Range(minint,maxint);
    }

    public override void OnConnectedToMaster(){

        base.OnConnectedToMaster();

        Debug.Log("Connected to Server!");

        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby(){

        base.OnJoinedLobby();

        PhotonNetwork.JoinOrCreateRoom("test",null,null);

        Debug.Log("We're Connected and in a room now!");
        Invoke("PhotonInit",3);
            roomcam.SetActive(false);

    }
   
   void Update(){

    loadingObject.fillAmount += 0.0003f;
    EditTextpercent();
    print(persent);
   }

   void EditTextpercent(){
    
    persent = loadingObject.fillAmount * loadingOver;
    textLoading.text = (int)persent + "%" ;
   }
}
   //void PhotonInit(){
  // GameObject _player = PhotonNetwork.Instantiate (Player.name, spawnPoint.position,Quaternion.identity);
  // _player.GetComponent<PlayerSetup>().IsLocalPlayer();
  // }

   // private void RespawnPlayer(){
   //GameObject _enemy = PhotonNetwork.Instantiate (enemy.name, spawnPoint.position,Quaternion.identity);
  // _player.GetComponent<PlayerSetup>().IsLocalPlayer();

   //}

