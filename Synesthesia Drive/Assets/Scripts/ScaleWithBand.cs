using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWithBand : MonoBehaviour
{
    public int _band;
    public float _startScale, _scaleMultiplier;
    public bool _useBuffer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(_useBuffer){
            transform.localScale = new Vector3(transform.localScale.x,(AudioSpectrumTracker._audioBandBuffer[_band] * _scaleMultiplier) + _startScale ,transform.localScale.z);       
        }
        else{
            transform.localScale = new Vector3(transform.localScale.x,(AudioSpectrumTracker._audioBand[_band] * _scaleMultiplier) + _startScale ,transform.localScale.z);
        }
    }
}
