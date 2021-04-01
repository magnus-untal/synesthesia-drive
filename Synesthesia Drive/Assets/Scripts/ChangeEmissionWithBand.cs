using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEmissionWithBand : MonoBehaviour
{
    public int _band;
    public bool _useBuffer;

    Material _material;
    // Start is called before the first frame update
    void Start()
    {
        _material = GetComponent<MeshRenderer> ().materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(_useBuffer){
            Color _color = new Color(AudioSpectrumTracker._audioBandBuffer[_band],AudioSpectrumTracker._audioBandBuffer[_band],AudioSpectrumTracker._audioBandBuffer[_band]);
            _material.SetColor("_EmissionColor", _color);        
        }
        else{
            Color _color = new Color(AudioSpectrumTracker._audioBand[_band],AudioSpectrumTracker._audioBand[_band],AudioSpectrumTracker._audioBand[_band]);
            _material.SetColor("_EmissionColor", _color);
        }

        
    }
}
