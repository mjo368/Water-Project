using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueHolder : MonoBehaviour
{

    public string dialogue; 
    private DialogueManager dMAn; 

    public string [] dialogLines; 
    
    // Start is called before the first frame update
    void Start()
    {
        dMAn = FindObjectOfType<DialogueManager>(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
    
        if(other.gameObject.name == "Player")
        { 

            if(Input.GetKeyDown(KeyCode.Q)){

                if (!dMAn.dialogActive){

                    //dMAn.dialogLines = dialogueLines; 
                    //dMAn.currentLine = 0; 
                  //  dMAn.ShowDialogue(); 

                }


            }
        }

    }
}
