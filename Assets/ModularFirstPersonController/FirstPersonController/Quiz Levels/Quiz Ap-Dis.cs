using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyVars;
using UnityEditor.Build.Content;
using QuizCol;
using Codice.CM.Common;

namespace QuizVars{
public class Quiz : MonoBehaviour {

	public bool levelcheck;
	public GameObject Content;
	public bool FirstRun;
	public bool CursorLock;
	public bool QuizStart;

	
    QuizCols scriptInstance = null;
	void Start () {

		GameObject tempObj = GameObject.Find("Fan_01 (1)");
        scriptInstance = tempObj.GetComponent<QuizCols>();
		levelcheck = scriptInstance.activate;
		
		Content.SetActive(false) ;
		
		FirstRun = true;
		CursorLock = true;
		
	}

	void Update () {

		//Create an instance of MyClass	
		//MyVarsClass myInstance = new MyVarsClass();
		
		GameObject tempObj = GameObject.Find("Fan_01 (1)");
        scriptInstance = tempObj.GetComponent<QuizCols>();
		levelcheck = scriptInstance.pusher;
		

		// Access the variable from MyClass 
		//levelcheck = myInstance.Quizlevel;
		//Debug.Log("levelcheck: " + levelcheck);

	
		if (levelcheck == true) {
			
			//if (FirstRun == true) {	

				Content.SetActive(true);
				FirstRun = true;
				
				CursorLock = false;

				QuizStart = true;
			
				
			//}

			//else {}
		}
	}
}
}