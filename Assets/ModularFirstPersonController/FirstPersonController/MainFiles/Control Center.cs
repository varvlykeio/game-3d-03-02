using System.Collections;
using System.Collections.Generic;
using PlasticGui.WorkspaceWindow;
using UnityEngine;
using QuizCol;
using Doors;
using Codice.CM.Common;
using log4net.Core;
using System.Diagnostics;



#region MyVars

namespace MyVars{
    public class MyVarsClass : MonoBehaviour
    {
        
        public bool Maze1 = false;
        public bool Maze2 = false;
        public bool Maze3 = false;
        public bool Maze4 = true;
        public bool diadromos = true;
        public float[] CoinR =  { 0 , 0, 0 , 0 , 0 , 0 };
        public GameObject coin;
    
       
        public void Start(){

           CoinR[5] = 5;
  
        }

      
        public void Update(){

        }
    }
}

#endregion