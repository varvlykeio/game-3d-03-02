using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyVars;
using UnityEditor.Build.Content;
using System.Data.Common;

namespace QuizCol {

public class QuizCols : MonoBehaviour{

public bool activate;
public bool pusher;
public void Start(){
Debug.Log("Started");


}
public void OnTriggerEnter(){

activate = true;
Debug.Log("Activated" + activate);

}

public void Update(){

    pusher = activate;
}
    
}

}
