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


    private void Start()
    {
        scoreText.color = new Color32(255, 255, 255, 255);
        theScore = 0;
        theStreak = 0;
        multiplier = 1;
    }


    // Update is called once per frame
    void Update()
    {
        if (theStreak < 10)
        {
            multiplierText.text = "1x multiplier";
            multiplierText.color = new Color32(255, 255, 255, 255);

        }

        else if (theStreak ==10)
        {
            multiplierText.text = "2x multiplier";
            multiplier = 2;
            multiplierText.color = new Color32(188, 243, 15, 255);
           
        }
        
        else if (theStreak == 20)
        {
            multiplierText.text = "3x multiplier";
            multiplier = 3;
            multiplierText.color = new Color32(0, 255, 150, 255);
        }

        else if (theStreak == 30)
        {
            multiplierText.text = "5x multiplier";
            multiplier = 5;
            multiplierText.color = new Color32(0, 231, 255, 255);
        }

        scoreText.text = theScore.ToString();
    }
}
