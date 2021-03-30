using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;
    public Text multiplierText;
    public static int theScore = 0;
    public static int theStreak = 0;
    public static int multiplier = 1;

  

    // Update is called once per frame
    void Update()
    {
        if (theStreak < 10)
        {
            multiplierText.text = "1x multiplier";
           
        }

        else if (theStreak ==10)
        {
            multiplierText.text = "2x multiplier";
            multiplier = 2;
        }
        
        else if (theStreak == 20)
        {
            multiplierText.text = "3x multiplier";
            multiplier = 3;
        }

        else if (theStreak == 30)
        {
            multiplierText.text = "5x multiplier";
            multiplier = 5;
        }

        scoreText.text = theScore.ToString();
    }
}
