using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyVars;
using UnityEditor.Build.Content;
using System.Data.Common;
using JetBrains.Annotations;
using System;
using PlasticPipe.PlasticProtocol.Messages;

namespace QuizCol {

    public class QuizCols : MonoBehaviour{

        public bool activate;
        public bool pusher;
        public GameObject Text;


        public void Start(){
            // δεν χρειαζονται τα σχολια
            //Debug.Log("Started");
            //Text = GameObject.Find("Quiz - I");
            //Text.SetActive(false);



        }
         public void OnTriggerEnter(){
            
            activate = true;
            // δεν χρειαζονται τα σχολια
            //Debug.Log("Activated" + activate);
            //Τext.SetActive(true); 

               

        }

        public void Update(){

            if (activate == true){
                if(Input.GetKeyDown("i")){
                //Text.SetActive(false);
                pusher = true;

                }
            }

      

        }

        public void OnTriggerExit(){
            
            activate = false;
            // δεν χρειαζονται τα σχολια
            //Text.SetActive(false);
            //Debug.Log("DeActivated" + activate);
            
            

        }
        
    }

}
