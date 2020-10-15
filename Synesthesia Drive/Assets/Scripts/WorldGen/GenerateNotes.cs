using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNotes : MonoBehaviour
{
    [SerializeField]
    private GameObject notePrefab;

    int[] laneVectorLocations = new int[3] { -10, 0, 10 };
    private void Start()
    {
        SpawnNotes();
    }
    private void SpawnNotes()
    {

        for (int i = 1; i < 60; i++)
            {
                int randomLane = Random.Range(0, laneVectorLocations.Length);
                Instantiate(notePrefab, new Vector3(laneVectorLocations[randomLane], 2.5f, i*50 + 30f), Quaternion.identity);
            }
        
       
    }
}
