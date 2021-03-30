using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollide : MonoBehaviour
{
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Obstacle")
        {
            ScoreSystem.theStreak = 0;
            ScoreSystem.multiplier = 1;
        }
    }
}
