
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using MyVars;

namespace Doors {
public class Door : MonoBehaviour
{

    public Vector3 rotation;
    public bool IsOpen = false;
    
    [SerializeField]
    private float Speed = 3f;

    [Header("Sliding Configs")]
    [SerializeField]
    
    
    private Vector3 SlideDirection = Vector3.back;
    [SerializeField]
    private float SlideAmount = 2.6f;
    private Vector3 StartPosition;

    private Coroutine AnimationCoroutine;
    public bool activate;
    private GameObject textE;
    MyVarsClass scriptInstance = null;
    




    private void Awake()
    {
        StartPosition = transform.position;
        
    }
    public void Start(){

        GameObject tempObj = GameObject.Find("Fan_01 (1)");
        scriptInstance = tempObj.GetComponent<MyVarsClass>();
        textE = scriptInstance.TextE;
        textE.SetActive(false);
        
    }
    public void Update()
        {
          
            
            rotation = transform.eulerAngles;
            
            



            if (activate == true){
            if (!IsOpen)
            {
                if (Input.GetKeyDown("e"))
                {
                
                    AnimationCoroutine = StartCoroutine(DoSlidingOpen()); 
                }
            }
            else
            {
                if (Input.GetKeyDown("e"))
                {            
                AnimationCoroutine = StartCoroutine(DoSlidingClose());
                }
            }
            }
        }
    public void OnTriggerEnter(){
        //e
        activate = true;
        textE.SetActive(true);
        


    }

    public void OnTriggerExit(){

        activate = false;
        textE.SetActive(false);

    }

   
    
    

    private IEnumerator DoSlidingOpen()
    {
        Vector3 endPosition = StartPosition + SlideAmount * SlideDirection;
        Vector3 startPosition = transform.position;
        

        float time = 0;
        IsOpen = true;
        while (time < 1)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, time);
            yield return null;
            time += Time.deltaTime * Speed;
        }
    }

    

    private IEnumerator DoSlidingClose()
    {
        Vector3 endPosition = StartPosition;
        Vector3 startPosition = transform.position;
        float time = 0;

        IsOpen = false;

        while (time < 1)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, time);
            yield return null;
            time += Time.deltaTime * Speed;
        }
    }
}
}