using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyVars;
using UnityEditor.Build.Content;

namespace QuizVars{
public class Quiz : MonoBehaviour {

	public bool levelcheck;
	public GameObject Content;
	public bool FirstRun;
	public bool CursorLock;
	public bool QuizStart;

	

	void Start () {

		
		Content.SetActive(false) ;
		
		FirstRun = true;

		if (levelcheck == true) {

				QuizStart = true;
				CursorLock = true;				
		}
		
	}

	void Update () {

		//Create an instance of MyClass	
		 MyVarsClass myInstance = new MyVarsClass();
		
		

		// Access the variable from MyClass 
		 levelcheck = myInstance.Quizlevel;
		//Debug.Log("levelcheck: " + levelcheck);

	
		if (levelcheck == true) {
			
			if (FirstRun == true) {

				//Content.SetActive(true);
				FirstRun = true;
				
				CursorLock = false;

				QuizStart = true;
				
			}

			else {



				
				
			}
		}
	}
}
}