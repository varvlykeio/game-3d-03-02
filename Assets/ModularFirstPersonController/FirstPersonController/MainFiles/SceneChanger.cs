using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using MyVars;
using UnityEngine.Timeline;


//  Build Index
//       |
//       v
// Scene 0: SampleScene / Starting Scene 
// Scene 1: Math Level
// Scene 5: Coding Level
// Scene 4: History Level
// Scene 3: Language Level
// Scene 2: Geometry Level




public class SceneChanger : MonoBehaviour {
    public Scene Coding;
    public GameObject StartingUI= null;

    public void Button1(){
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(1);
    }
    public void Button2(){
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(5);
    }
    public void Button3(){
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(4);
    }
    public void Button4(){
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(3);
    }
    public void Button5(){
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(2);
    }
}
