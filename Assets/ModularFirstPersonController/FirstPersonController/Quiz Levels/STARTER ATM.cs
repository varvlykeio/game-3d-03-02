using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyVars;
using UnityEditor.Build.Content;
using System.Data.Common;
using JetBrains.Annotations;
using System;


namespace StarterATM {

    public class StrtATM : MonoBehaviour{

        private bool activate;
        public bool pusher1;

        public GameObject StarterCanvas;

        public void Start(){

            StarterCanvas.SetActive(false);
        }
       
        public void OnTriggerExit(){
            
            activate = false;
            
        }
         public void OnTriggerEnter(){
            
            activate = true;

        }

        public void Update(){

            if (activate == true){
                if(Input.GetKeyDown("i")){

                    StarterCanvas.SetActive(true);
                   

                }
            }
        }

        
        
    }

}