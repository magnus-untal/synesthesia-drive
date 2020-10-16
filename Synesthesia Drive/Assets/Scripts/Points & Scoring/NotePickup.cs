using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePickup : MonoBehaviour
{
    public Transform noteEffect;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        ScoreSystem.theStreak += 1;
        ScoreSystem.theScore += 100*ScoreSystem.multiplier;
        Transform effect = (Transform)Instantiate(noteEffect, transform.position, transform.rotation);
        Destroy(effect.gameObject, 3);
        Destroy(gameObject);
    }
}
