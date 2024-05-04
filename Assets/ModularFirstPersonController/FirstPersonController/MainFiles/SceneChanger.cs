using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using MyVars;
using UnityEngine.Timeline;







public class SceneChanger : MonoBehaviour {
    public Scene Coding;
    public GameObject StartingUI= null;

    public void Button1(){
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(2).buildIndex);
    }
    public void Button2(){
        //SceneManager.UnloadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(0).buildIndex);
        
        
    }
    public void Button3(){
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(5).buildIndex);
        

    }
    public void Button4(){
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(-1).buildIndex);
        
    }
    public void Button5(){
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(3).buildIndex);
        

    }
}
