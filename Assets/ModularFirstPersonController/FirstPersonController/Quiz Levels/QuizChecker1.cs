using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyVars;
using UnityEditor.Build.Content;
using System.Data.Common;
using JetBrains.Annotations;
using System;


namespace QuizCol {

    public class QuizCols1 : MonoBehaviour{

       private bool activate;
        public bool pusher1;
       
        public void Start(){


        }
         public void OnTriggerEnter(){
            
            activate = true;

        }

        public void Update(){

            if (activate == true){
                if(Input.GetKeyDown("i")){

                    pusher1 = true;
                   

                }
            }
        }

        public void deletos(){
            Destroy(gameObject);
        }

        public void OnTriggerExit(){
            
            activate = false;
            
        }
        
    }

}
