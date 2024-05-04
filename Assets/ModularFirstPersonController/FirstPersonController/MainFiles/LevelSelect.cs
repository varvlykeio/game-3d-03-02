using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using MyVars;

namespace LvlSelect {
    public class LevelSelect : MonoBehaviour
    {
        public int level;
        public GameObject StartingUI;

        public void Button1(){
            level = 1;
            StartingUI.SetActive(false);
        }
        public void Button2(){
            level = 2;
            StartingUI.SetActive(false);

        }
        public void Button3(){
            level = 3;
            StartingUI.SetActive(false);

        }
        public void Button4(){
            level = 4;
            StartingUI.SetActive(false);

        }
        public void Button5(){
            level = 5;
            StartingUI.SetActive(false);

        }





        public void Update(){
            Debug.Log(level);
        }


    }
}