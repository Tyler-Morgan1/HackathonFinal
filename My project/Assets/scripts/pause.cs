using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour
{
    private GameObject lion;
    private GameObject CanvasObj;
    private bool Paused = false;
    public GameObject[] backG;
    public GameObject[] endButtons;
    private GameObject lionMove;
    private GameObject spawnEnd;
    int lives;
    // Start is called before the first frame update
    void Start()
    {
        lionMove = GameObject.Find("lion");
        lion = GameObject.Find("LionSprite_0");
        CanvasObj = GameObject.Find("CanvasParent");
        spawnEnd = GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
       
        
 lives = lionMove.GetComponent<Movement>().playerLives;
if(lives <=0){
    
    endButtons[0].gameObject.SetActive(true);
     endButtons[1].gameObject.SetActive(true);
      endButtons[2].gameObject.SetActive(true);
}
if(spawnEnd.transform.childCount <= 0 && lives >= 1){
   StartCoroutine(endScreenGood());
        }

        if(Input.GetKeyDown("space") && Paused == false){
            backG[0].GetComponent<Renderer>().sortingOrder = 10;
            backG[1].GetComponent<Renderer>().sortingOrder = 10;
            backG[2].SetActive(true);

            Paused = true;
            lion.GetComponent<Animator>().enabled = false;
            CanvasObj.SetActive(false);
            Time.timeScale = 0;
        }
        else if(Input.GetKeyDown("space") && Paused == true){
            Paused = false;
            backG[0].GetComponent<Renderer>().sortingOrder = -10;
            backG[1].GetComponent<Renderer>().sortingOrder = -10;
            backG[2].SetActive(false);

            lion.GetComponent<Animator>().enabled = true;
            CanvasObj.SetActive(true);
            Time.timeScale = 1;
        }
    }

    IEnumerator endScreenGood(){
        yield return new WaitForSeconds(12.0f);
if(spawnEnd.transform.childCount <= 0 && lives >= 1){
    endButtons[0].gameObject.SetActive(true);
     endButtons[1].gameObject.SetActive(true);
     endButtons[3].gameObject.SetActive(true);
    }
    }


    public void RestartButton(){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
public void EndGameButton()
{
    #if UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif
}
}
