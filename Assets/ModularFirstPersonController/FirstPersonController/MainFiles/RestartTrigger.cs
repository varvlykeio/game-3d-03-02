using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using PlasticGui;

//τηλεμεταφορα στον ανεμιστηρα απο το κουιζ
//περιεργη τηλεμεταφορά του παίκτη: -279 , -8.11 , 17.24 ...

//For it to work properly (send the player to the position he was when he entered the quiz), we need to fix 
//the problem with the Play Again button reseting the Scene, uncomment lines 18-25 and 38-42 of this script
//and comment the other OnTriggerEnter
public class RestartTrigger : MonoBehaviour 
{
    public Transform Tel_Target, Tel_Target2;
    public GameObject the_player;
    public Vector3 player_location;

    /*public void Update(){

        if (Input.GetKeyDown("i")){

        player_location = the_player.transform.position; 
        
        }
    }*/

    void OnTriggerEnter (Collider other)
    {

        if(other.CompareTag("Player"))
        {
            the_player.SetActive(false);
            Tel_Target2.transform.position = Tel_Target.transform.position;
            the_player.SetActive(false);
        }
    }

    /*public void OnTriggerEnter(){

        the_player.transform.position = player_location;

    }*/

}