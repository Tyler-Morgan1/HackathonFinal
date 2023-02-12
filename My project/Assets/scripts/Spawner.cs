using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    private int num_of_questions = 10;
    public bool sGame = false;
    private bool gameisRunning = true;
    private Movement liveCounter;
    private GameObject parentQuestion;
    
    
    // Start is called before the first frame update
    void Start()
    {
        num_of_questions = gameObject.transform.childCount;
        StartCoroutine(startGame());
        liveCounter = GameObject.Find("lion").GetComponent<Movement>();
        parentQuestion = GameObject.Find("parent");
    }

    // Update is called once per frame
    void Update()
    {
        if (liveCounter.playerLives == 0){
            gameisRunning = false;
        }
    }

    IEnumerator startGame(){
        
        while(gameisRunning && num_of_questions >= 1){
            
            yield return new WaitForSeconds(.01f);
            
            int random = Random.Range(0, num_of_questions);
            Transform child_transform = transform.GetChild(random);
            child_transform.parent = null;
            num_of_questions -= 1; 
            child_transform.gameObject.SetActive(true);
            parentQuestion.transform.GetChild(random).gameObject.SetActive(true);
        //wait until touch
       
            yield return new WaitUntil(() => sGame == true);
            Destroy(parentQuestion.transform.GetChild(random).gameObject);
            Destroy(child_transform.gameObject);
            sGame = false;
            
         
    
    }

   
    }

    
}


