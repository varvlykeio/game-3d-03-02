using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyVars;

namespace QuizVars{
public class Quiz : MonoBehaviour {

	public bool levelcheck;
	public GameObject Content;
	public bool FirstRun;

	public bool CursorLock;


	void Start () {

		Content.SetActive(false) ;
		levelcheck = false;
		FirstRun = true;
		CursorLock = true;
		
	}

	void Update () {


		//Create an instance of MyClass	
		 MyVarsClass myInstance = new MyVarsClass();
		

		// Access the variable from MyClass 
		 levelcheck = myInstance.Quizlevel;
		

	
		while (levelcheck == true) {

			if (FirstRun == true) {

				Content.SetActive(true);
				FirstRun = false;
				
				CursorLock = false;
				
			}

			else {

				
				
			}
		}
	}
}
}