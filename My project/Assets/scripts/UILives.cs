using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILives : MonoBehaviour
{
    public Movement lives; // instance off of Movement script
    [SerializeField] public Text displayLives; // text field


    void Start()
    {
        //initial livesat the start of the game
        displayLives = GetComponent<Text>();

        displayLives.text = "3 Lives";
    }

    void Update()
    {
        // should have a forLive.playerLives + 1).ToString() for the number taken from Movement Script
        displayLives.text = "Lives: " + (lives.playerLives).ToString();
    }
}
