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
	public bool QuizStart = true;


	void Start () {

		//Content.SetActive(false) ;
		levelcheck = true; //True will be changed to a bool that determines whether the level will run or not
		FirstRun = true;
		CursorLock = true;

		if (levelcheck == true) {

			if (FirstRun == true) {
				

				QuizStart = true;
				
			}
		}
		
	}

	void Update () {


		//Create an instance of MyClass	
		 MyVarsClass myInstance = new MyVarsClass();
		
		

		// Access the variable from MyClass 
		 levelcheck = myInstance.Quizlevel;
		

	
		if (levelcheck == true) {

			if (FirstRun == true) {

				//Content.SetActive(true);
				FirstRun = false;
				
				CursorLock = false;

				QuizStart = true;
				
			}

			else {



				
				
			}
		}
	}
}
}