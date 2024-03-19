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

    public class QuizCols2 : MonoBehaviour{

        private bool activate;
        public bool pusher2;
       


        public void Start(){

        }
         public void OnTriggerEnter(){
            
            activate = true;
     
        }

         public void Update(){

            if (activate == true){
                if(Input.GetKeyDown("i")){

                    pusher2 = true;
                    Invoke("deletos", 2f);

                }
            }
        }

        public void deletos(){
            Destroy(gameObject);
        }

        public void OnTriggerExit(){
            
            activate = false;
            Invoke("Destroy(gameObject)", 2f);
        }
        
    }

}
