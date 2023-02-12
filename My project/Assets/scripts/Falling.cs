using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D ridge;
        private Vector2 position;
        private float speed = 1.0f;
        
        public bool correct = false;
        private GameObject forSpawner;
    void Start()
    {
        ridge = gameObject.GetComponent<Rigidbody2D>();
        position = new Vector2(0,-1);
       GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void FixedUpdate(){

    ridge.MovePosition(ridge.position + position * speed * Time.fixedDeltaTime);

    }
     void OnTriggerEnter2D(Collider2D collision){
        if(correct == false && collision.gameObject.name != "Background"){
        GameObject.Find("Spawner").GetComponent<Spawner>().sGame = true;

        GameObject.Find("lion").GetComponent<Movement>().playerLives--;
        Debug.Log("Incorrect");
        }
        else if(correct == true && collision.gameObject.name != "Background"){
         GameObject.Find("Spawner").GetComponent<Spawner>().sGame = true;

        Debug.Log("Correct");
        }
        else if (correct == false && collision.gameObject.name == "Background"){
        
        }
        else if (correct == true && collision.gameObject.name == "Background"){
        Debug.Log("false");
        GameObject.Find("Spawner").GetComponent<Spawner>().sGame = true;
        GameObject.Find("lion").GetComponent<Movement>().playerLives--;

        }

     }
}
