using System.Collections;
using System.Collections.Generic;
using PlasticGui.WorkspaceWindow;
using UnityEngine;
using QuizCol;
using Doors;
using Codice.CM.Common;
using log4net.Core;
using System.Diagnostics;
using System.Numerics;



#region MyVars

namespace MyVars{
    public class MyVarsClass : MonoBehaviour{
        
        public bool Maze1 = false;
        public bool Maze2 = false;
        public bool Maze3 = false;
        public bool Maze4 = true;
        public bool diadromos = true;

        public int level = 1;
                                //     x1  ,   x2  ,    y   ,   z1  ,  z2  , ammount
        public float[,] CoinR =  { {  -51  ,  -32  ,  0.5f  ,  -24  , -20  ,     4    },    //Level 1
                                   {   0   ,   0   ,   0    ,   0    ,  0   ,    0    },    //Level 2       
                                   {   0   ,   0   ,   0    ,   0    ,  0   ,    0    },    //Level 3
                                   {   0   ,   0   ,   0    ,   0    ,  0   ,    0    },    //Level 4       
                                   {   0   ,   0   ,   0    ,   0    ,  0   ,    0    }, }; //Level 5
 


                                  //       Level 1                  ,    Level 2   ,    Level 3   ,    Level 4    ,   Level 5
                                  //        x    ,   y   ,    z         x , y , z      x , y , z      x , y , z      x , y , z
        public float[,,] QuestionR ={ { { -80.6f , 0.01f , -8.94f  }, { -78.6f , 0.01f , -8.94f  }, { 0 , 0 , 0 }, { 0 , 0 , 0 }, { 0 , 0 , 0 } },   //Question 1
                                      { { -80.6f , 0.01f , -11.57f }, { -78.6f , 0.01f , -11.57f }, { 0 , 0 , 0 }, { 0 , 0 , 0 }, { 0 , 0 , 0 } },   //Question 2
                                      { { -80.6f , 0.01f , -15.65f }, { -78.6f , 0.01f , -15.65f }, { 0 , 0 , 0 }, { 0 , 0 , 0 }, { 0 , 0 , 0 } } }; //Question 3
        public GameObject coin;

        #region Coins

    
        public void Start(){



        }


        
        public void Update(){


            //The ifs will choose the coordinates' range where the coins will spawn depending on what διάδρομος we are in 

            //if(level1 == true){
            //CoinR[0] = -51;     CoinR[1] = -32;     CoinR[2] = 0.5f;     CoinR[3] = -24;     CoinR[4] = -20; 
            /*}
            else if(level2 == true){
                CoinR[0] = -21;     CoinR[1] = -33;     CoinR[2] = 4;     CoinR[3] = -54;     CoinR[4] = -16;
            } ....
            */

            //The ifs will choose the coordinates' range where the coins will spawn depending on what διάδρομος we are in 


            


            if (diadromos ==true){



                for(float i=0; i<= CoinR[0,5]; i++){
                    Invoke("SpawnCoin",0.3f);
                }
                diadromos= false;

            }
    }

        public void SpawnCoin(){

            UnityEngine.Vector3 randCoinPos = new UnityEngine.Vector3(Random.Range(CoinR[level-1,0], CoinR[level-1,1]), CoinR[level-1,2], Random.Range(CoinR[level-1,3], CoinR[level-1,4]));
            UnityEngine.Quaternion CoinQ = new UnityEngine.Quaternion(0,0,0,0);
            Instantiate(coin, randCoinPos, CoinQ);

        }

        /*public void SpawnQuestions(int level){
            UnityEngine.Vector3  QuestionPos = new UnityEngine.Vector3(QuestionR[0,0,0],QuestionR[0,0,1],QuestionR[0,0,2]);
            UnityEngine.Quaternion QuestionQ = new UnityEngine.Quaternion(0,0,0,0);
            Instantiate(coin, QuestionPos, QuestionQ);


        }*/

    #endregion Coins


    }
}

#endregion