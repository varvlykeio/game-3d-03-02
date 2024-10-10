using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using MyVars;
using UnityEngine.Timeline;
using GameEv;
using UnityEditor.PackageManager;



//  Build Index                           Level
//       |                                  |
//       v                                  v
// Scene 0   SampleScene / Starting Scene   0
// Scene 5    Math    Level                 1
// Scene 4   Coding   Level                 2
// Scene 3  History   Level                 3
// Scene 2  Language  Level                 4
// Scene 1  Geometry  Level                 5


namespace Scenes{
    public class SceneChanger : MonoBehaviour {
        public Scene Coding;
        public GameObject StartingUI= null;
        public int level;
        [SerializeField]    GameEvents          events                  = null;

        public void Start(){
           events.currentlevel = 0;
        }
        
        public void Button1(){ //Math
            SceneManager.UnloadSceneAsync(0);
            SceneManager.LoadScene(5);
            events.currentlevel = 1; 
            events.CursorLock = true;  
            Debug.Log("IN");    
        }
        public void Button2(){
            SceneManager.UnloadSceneAsync(0);
            SceneManager.LoadScene(4);
            events.currentlevel = 2;
            events.CursorLock = true;  
        }
        public void Button3(){//History
            SceneManager.UnloadSceneAsync(0);
            SceneManager.LoadScene(3);
            events.currentlevel = 3;
            events.CursorLock = true;  
        }
        public void Button4(){ //Language
            SceneManager.UnloadSceneAsync(0);
            SceneManager.LoadScene(2);
            events.currentlevel = 4;
            events.CursorLock = true;  
        }
        public void Button5(){ //Geometry
            SceneManager.UnloadSceneAsync(0);
            SceneManager.LoadScene(1);
            events.currentlevel = 5;
            events.CursorLock = true;  
        }
    }
}
