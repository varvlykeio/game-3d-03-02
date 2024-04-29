using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyVars;
using UnityEditor.Build.Content;
using QuizCol;


namespace QuizVars{
	public class Quiz : MonoBehaviour {
		public GameObject Content;
		public GameObject Resolution;
		public bool FirstRun;
		public bool CursorLock;
		public bool QuizStart;
		public              bool                levelcheck1             = false;
		public              bool                levelcheck2             = false;
		public              bool                levelcheck3             = false;

		void OnEnable() {

			Content.SetActive(false);
			Resolution.SetActive(false);
			
			FirstRun = true;
			CursorLock = true;
			
		}
		QuizCols1 scriptInstance1 = null;
		QuizCols2 scriptInstance2 = null;
		QuizCols3 scriptInstance3 = null;	
		void Update () {
			GameObject tempObj1 = GameObject.Find("ATM1(Clone)");
			scriptInstance1 = tempObj1.GetComponent<QuizCols1>();
			GameObject tempObj2 = GameObject.Find("ATM2(Clone)");
			scriptInstance2 = tempObj2.GetComponent<QuizCols2>();
			GameObject tempObj3 = GameObject.Find("ATM3(Clone)");
			scriptInstance3 = tempObj3.GetComponent<QuizCols3>();
				

			levelcheck1 = scriptInstance1.pusher1;
			levelcheck2 = scriptInstance2.pusher2;
			levelcheck3 = scriptInstance3.pusher3;
		
			if (levelcheck1 == true || levelcheck2 == true || levelcheck3 == true) {


				Content.SetActive(true);
				Resolution.SetActive(true);
				FirstRun = true;
				
				CursorLock = false;

				QuizStart = true;
					
			}
		}
	}
}