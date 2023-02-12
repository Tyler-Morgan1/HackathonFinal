using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Movement score;
    [SerializeField] public Text displayScore;
    void Start()
    {
        // initial score of 0
        displayScore = GetComponent<Text>();

        displayScore.text = "Score: 0000";
    }


    void Update()
    {
        // should have a forLive.playerScore + 1).ToString() for the number taken from Movement Script
        displayScore.text = "Score: " + (score.playerScore).ToString();
    }
}
