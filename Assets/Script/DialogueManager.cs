﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox; 
    public Text dText; 

    public bool dialogActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(dialogActive && Input.GetKeyDown(KeyCode.Q))
       Debug.Log("it is working");
        {
            dBox.SetActive(false); 
            dialogActive = false; 
        
    }


    // public 
    // Debug.Log("it is working"):
    void SetActive(string dialogue) 

   
    { 
        dialogActive = true; 
        dBox.SetActive(true); 
        dText.text = dialogue; 

    }

   }  
}