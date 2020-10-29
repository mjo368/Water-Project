﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using dialogBox; 

public class QuestObject : MonoBehaviour
{
    public int questNumber; 

    public QuestManager theQM; 

    public string startText; 

    public string endText; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartQuest ()
    { 
        theQM.ShowQuestText (startText); 


    }

    public void EndQuest ()
    { 
       theQM.ShowQuestText (endText); 
       theQM.questCompleted[questNumber] = true; 
        gameObject.SetActive(false);

    }
}
