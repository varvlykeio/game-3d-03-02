using System.Collections;
using System;
using System.Collections.Generic;
using Unity;
using UnityEngine;
using UnityEditor;
using JetBrains.Annotations;
using UnityEngine.UI;
using Unity.VisualScripting;
using MyVars;

public class Maze1 : MonoBehaviour

{



	public static bool levelcheck;
	public static GameObject fpc;
	public Image ImgMaze1;
	

	public bool FirstRun = true;
	
	
	void Start() {

		ImgMaze1.enabled = false;

	}

	void Update() {

		//Create an instance of MyClass
        MyVarsClass myInstance = new MyVarsClass();

        // Access the variable from MyClass       
		levelcheck = myInstance.Maze1;
		//fpc = myInstance.fpc;
		

		if( levelcheck == true ){
			if(FirstRun == true) {

				ImgMaze1.enabled = true;
				//spera
				
			}
			else{

				//script for Maze 1
						

			}
		}
	}
}
