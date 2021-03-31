using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollide : MonoBehaviour
{
    Renderer rend;
    Color hit = new Color(0, 0, 0, 0.5f);
    Color start = new Color(1, 1, 1, 1);

    
    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", start);
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        ScoreSystem.theStreak = 0;
        ScoreSystem.multiplier = 1;
      
        rend.material.SetColor("_Color", hit);
    }
}
