using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement; 

public class Door : MonoBehaviour
{
    private PlayerController thePlayer; 

    public SpriteRenderer theSR; 
    public Sprite doorOpenSprite; 
    //public int nextSceneToLoad; 


    public bool doorOpen, waitingToOpen; 



    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>(); 

      //  nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1; 


    }

    

    // Update is called once per frame
    void Update()
    {
        if(waitingToOpen){

            if(Vector3.Distance(thePlayer.followingKey.transform.position, transform.position) <0.1f){

                waitingToOpen = false; 

                doorOpen = true; 

                theSR.sprite = doorOpenSprite;

                thePlayer.followingKey.gameObject.SetActive(false); 
                thePlayer.followingKey = null; 


            }


        }
        if (doorOpen && Input.GetKeyDown(KeyCode.Space)){
       // if(doorOpen && Vector3.Distance(thePlayer.transform.position, transform.position) < 1f && Input.GetAxis("Vertical") > 0.1f){
     
          //SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
           //SceneManager.LoadScene(nextSceneToLoad); 
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if(thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform; 
                waitingToOpen = true; 

            }


        

        }



    }
}
