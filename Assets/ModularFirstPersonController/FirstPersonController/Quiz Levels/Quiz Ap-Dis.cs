using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyVars;
using UnityEditor.Build.Content;
using QuizCol;
using Codice.CM.Common;

namespace QuizVars{
public class Quiz : MonoBehaviour {

	//public bool levelcheck;
	public GameObject Content;
	public bool FirstRun;
	public bool CursorLock;
	public bool QuizStart;
	public              bool                levelcheck1             = false;
    public              bool                levelcheck2             = false;
    public              bool                levelcheck3             = false;

	
   
	void Start () {

		Content.SetActive(false);
		
		FirstRun = true;
		CursorLock = true;
		
	}
 	QuizCols1 scriptInstance1 = null;
    QuizCols2 scriptInstance2 = null;
    QuizCols3 scriptInstance3 = null;	
	void Update () {
			GameObject tempObj1 = GameObject.Find("ATM1");
			scriptInstance1 = tempObj1.GetComponent<QuizCols1>();
			GameObject tempObj2 = GameObject.Find("ATM2");
			scriptInstance2 = tempObj2.GetComponent<QuizCols2>();
			GameObject tempObj3 = GameObject.Find("ATM3");
			scriptInstance3 = tempObj3.GetComponent<QuizCols3>();
			

		levelcheck1 = scriptInstance1.pusher1;
        levelcheck2 = scriptInstance2.pusher2;
        levelcheck3 = scriptInstance3.pusher3;
		//Create an instance of MyClass	
		//MyVarsClass myInstance = new MyVarsClass();
		
		//GameObject tempObj = GameObject.FindGameObjectWithTag("ATM - Tag");
        //scriptInstance = tempObj.GetComponent<QuizCols1>();
		//levelcheck = scriptInstance.pusher;
		

		// Access the variable from MyClass 
		//levelcheck = myInstance.Quizlevel;
		//Debug.Log("levelcheck: " + levelcheck);
		Debug.Log("1" + levelcheck1 + "2" + levelcheck2 + "3" + levelcheck3);
	
		if (levelcheck1 == true || levelcheck2 == true || levelcheck3 == true) {

			// δεν χρειαζονται τα σχολια			
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