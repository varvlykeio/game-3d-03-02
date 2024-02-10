using System.Collections;
using System.Collections.Generic;
using PlasticGui.WorkspaceWindow;
using UnityEngine;
using QuizCol;



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

        public void Update(){

            QuizCols NewInstance = new();
            Quizlevel = NewInstance.activate;
        
            
            //Debug.Log(Quizlevel);

        }
    }
}

#endregion