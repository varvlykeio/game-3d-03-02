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



public class Maze2 : MonoBehaviour
{
	public static bool levelcheck;
	static void Main()
    {
        //Create an instance of MyClass
        MyVarsClass myInstance = new MyVarsClass();

        // Access the variable from MyClass       
		levelcheck = myInstance.Maze2;
    }

    public Image ImgMaze2;
	
	
	void Start() {

		
	}
	public bool FirstRun = true;

	void Update() {

		//Create an instance of MyClass
        MyVarsClass myInstance = new MyVarsClass();

        // Access the variable from MyClass       
		levelcheck = myInstance.Maze1;
		

		if( levelcheck == true ){
			if(FirstRun == true) {

				ImgMaze2.enabled = true;
				FirstRun = false;				
			}
			else{

				//script for Maze 2
						

			}
		}
	}
}
