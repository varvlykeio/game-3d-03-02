using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

//εμφανιση του i στον ανεμιστηρα 

public class UiAppear : MonoBehaviour
{
    [SerializeField] private TMP_Text customText;
    //[SerializeField] private TMP_Text customText2;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customText.enabled = true;             
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customText.enabled = false;
        }
    }
}