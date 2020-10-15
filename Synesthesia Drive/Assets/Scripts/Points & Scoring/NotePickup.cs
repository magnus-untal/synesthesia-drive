using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePickup : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        ScoreSystem.theStreak += 1;
        ScoreSystem.theScore += 100*ScoreSystem.multiplier;
        Destroy(gameObject);
    }
}
