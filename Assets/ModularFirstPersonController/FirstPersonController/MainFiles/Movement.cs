using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyVars;
using System.Net;

public class Movement : MonoBehaviour
{

    public bool levelcheck1;
    public bool levelcheck2;
    public bool levelcheck3;
    public bool levelcheck4;

    public static int a;

    MyVarsClass scriptInstance = null;

	


  public GameObject Cam;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update(){

      GameObject tempObj1 = GameObject.Find("Control Center");
      scriptInstance = tempObj1.GetComponent<MyVarsClass>();

			// Access the variable from MyClass       
		  levelcheck1 = scriptInstance.Maze1;
      levelcheck2 = scriptInstance.Maze2;
      levelcheck3 = scriptInstance.Maze3;
      levelcheck4 = scriptInstance.Maze4;


      //εμφανισει τοποθεσιας
      //Debug.Log(Cam.transform.position);
			
	

     if(a != 1){
        if(levelcheck1 == true) {

          Cam.transform.position = new Vector3(-20, 4, 4);
          a = 1;
 
        }
        if(levelcheck2 == true) {

          Cam.transform.position = new Vector3(10, 4, 4);
          a = 1;

        }
        if(levelcheck3 == true) {

          Cam.transform.position = new Vector3(30, 4, 4);
          a = 1;

        }
        if(levelcheck4 == true) {

          Cam.transform.position = new Vector3(-26, 4, -17);
          a = 1;

        }
      } 
    }

    


}