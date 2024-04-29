using UnityEngine;
using QuizCol;
using Doors;
using System.Diagnostics;
using System.Numerics;




namespace MyVars{
    public class MyVarsClass : MonoBehaviour{
        
        public bool[] Maze = {false,false,false,true};
        public bool Maze1 = false;
        public bool Maze2 = false;
        public bool Maze3 = false;
        public bool Maze4 = true;
        public bool diadromos = true; // Checks if the player has entered a diadromos level to spawn the coins
        public bool changelevel = true; // Checks whether the level has changed to spawn Question machines. 
        public int level = 1;
        public int levelch = 1;
        public int Question;



        public GameObject[] QuestionList = new GameObject[3];

                                // CoinR[level , x/y/z....]
                                //     x1  ,   x2  ,    y   ,   z1  ,  z2  , ammount-1
        public float[,] CoinR =  { {  -51  ,  -32  ,  0.5f  ,  -24  , -20  ,      4     },    //Level 1
                                   {   0   ,   0   ,   0    ,   0    ,  0   ,     0     },    //Level 2       }
                                   {   0   ,   0   ,   0    ,   0    ,  0   ,     0     },    //Level 3       |  Coordinates to 
                                   {   0   ,   0   ,   0    ,   0    ,  0   ,     0     },    //Level 4       |  be figured out
                                   {   0   ,   0   ,   0    ,   0    ,  0   ,     0     }, }; //Level 5       }
 

                                  //  QuestionR[ level , Question , x/y/z ]
                                  //              Level 1           ,            Level 2          ,    Level 3   ,    Level 4    ,   Level 5
                                  //        x    ,   y   ,    z           x    ,   y   ,    z         x , y , z      x , y , z      x , y , z
        public float[,,] QuestionR ={ { { -80.6f , 0.01f , -8.94f  }, { -78.6f , 0.01f , -8.94f  }, { 0 , 0 , 0 }, { 0 , 0 , 0 }, { 0 , 0 , 0 } },   //Question 1
                                      { { -80.6f , 0.01f , -11.57f }, { -78.6f , 0.01f , -11.57f }, { 0 , 0 , 0 }, { 0 , 0 , 0 }, { 0 , 0 , 0 } },   //Question 2
                                      { { -80.6f , 0.01f , -15.65f }, { -78.6f , 0.01f , -15.65f }, { 0 , 0 , 0 }, { 0 , 0 , 0 }, { 0 , 0 , 0 } } }; //Question 3
        public GameObject coin;

        

    
        public void Start(){

            UnityEngine.Debug.Log("sh");

        }

        public void OnEnable(){
           UnityEngine.Debug.Log("sh");


        }


        
        QuizCols1 scriptInstance1 = null;
        QuizCols2 scriptInstance2 = null;
        QuizCols3 scriptInstance3 = null;
      


        public void Update()
        {


     
            if( level != levelch ){

                levelch = level;
                changelevel = true;

            }


            #region Coins

            if (diadromos ==true){



                for(float i=0; i<= CoinR[0,5]; i++){
                    Invoke("SpawnCoin",0.3f);
                }
                diadromos= false;

            }

         







            #endregion Coins

            #region Questions

            if (changelevel == true){
                    UnityEngine.Debug.Log("ping");
                    //for(Question = 0; Question >= 2; Question++){   SpawnQuestions(level,Question); }    
                    //Doesn't work with the for(), for some reason...

                    UnityEngine.Vector3  QuestionPos = new UnityEngine.Vector3(QuestionR[level-1,0,0],QuestionR[0,level-1,1],QuestionR[0,level-1,2]);
                    UnityEngine.Quaternion QuestionQ = new UnityEngine.Quaternion(0,0,0,0);
                    Instantiate(QuestionList[Question], QuestionPos, QuestionQ);
                    UnityEngine.Vector3  QuestionPos2 = new UnityEngine.Vector3(QuestionR[1,level-1,0],QuestionR[1,level-1,1],QuestionR[1,level-1,2]);
                    UnityEngine.Quaternion QuestionQ2 = new UnityEngine.Quaternion(0,0,0,0);
                    Instantiate(QuestionList[1], QuestionPos2, QuestionQ2);
                    UnityEngine.Vector3  QuestionPos3 = new UnityEngine.Vector3(QuestionR[2,level-1,0],QuestionR[2,level-1,1],QuestionR[2,level-1,2]);
                    UnityEngine.Quaternion QuestionQ3= new UnityEngine.Quaternion(0,0,0,0);
                    Instantiate(QuestionList[2], QuestionPos3, QuestionQ3);
                    UnityEngine.Debug.Log("ping");

                changelevel = false;
            }

            #endregion Questions
            GameObject tempObj1 = GameObject.Find("ATM1(Clone)");
            scriptInstance1 = tempObj1.GetComponent<QuizCols1>();
            GameObject tempObj2 = GameObject.Find("ATM2(Clone)");
            scriptInstance2 = tempObj2.GetComponent<QuizCols2>();
            GameObject tempObj3 = GameObject.Find("ATM3(Clone)");
            scriptInstance3 = tempObj3.GetComponent<QuizCols3>();

            if(scriptInstance1.pusher1 == true && scriptInstance2.pusher2 == true  && scriptInstance3.pusher3 == true  ){

                level++;

            }

    }

        public void SpawnCoin(){

            UnityEngine.Vector3 randCoinPos = new UnityEngine.Vector3(UnityEngine.Random.Range(CoinR[level-1,0], CoinR[level-1,1]), CoinR[level-1,2], UnityEngine.Random.Range(CoinR[level - 1,3], CoinR[level-1,4]));
            UnityEngine.Quaternion CoinQ = new UnityEngine.Quaternion(0,0,0,0);
            Instantiate(coin, randCoinPos, CoinQ);

        }
    }
}

