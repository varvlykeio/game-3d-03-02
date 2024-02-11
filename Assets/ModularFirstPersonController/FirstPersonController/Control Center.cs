using System.Collections;
using System.Collections.Generic;
using PlasticGui.WorkspaceWindow;
using UnityEngine;
using QuizCol;
using Doors;



#region MyVars

namespace MyVars{
    public class MyVarsClass : MonoBehaviour
    {

        
        
        public bool Maze1 = false;
        public bool Maze2 = false;
        public bool Maze3 = false;
        public bool Maze4 = true;
        public bool Quizlevel;
        public GameObject fpc;
        public GameObject TextE;
        //public bool dooropen;
        
        QuizCols scriptInstance = null;
        Door NewInstance = null;

        
        public void Update(){

            
            

            GameObject tempObj = GameObject.Find("Fan_01 (1)");
            scriptInstance = tempObj.GetComponent<QuizCols>();
            Quizlevel = scriptInstance.activate;
           /* GameObject tempObjs = GameObject.FindGameObjectWithTag("Door");
            NewInstance = tempObjs.GetComponent<Door>();
            dooropen = NewInstance.activate;



            if (dooropen == true){

                TextE.SetActive(true);


            }
            else{ 
                TextE.SetActive(false);
            }*/
        
            
            //Debug.Log(Quizlevel);

        }
    }
}

#endregion