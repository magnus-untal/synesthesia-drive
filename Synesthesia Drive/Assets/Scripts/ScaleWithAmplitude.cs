using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWithAmplitude : MonoBehaviour
{
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
            transform.localScale = new Vector3((AudioSpectrumTracker._AmplitudeBuffer * _scaleMultiplier) + _startScale, (AudioSpectrumTracker._AmplitudeBuffer * _scaleMultiplier) + _startScale, (AudioSpectrumTracker._AmplitudeBuffer * _scaleMultiplier) + _startScale);       
        }
        else{
            transform.localScale = new Vector3((AudioSpectrumTracker._Amplitude * _scaleMultiplier) + _startScale, (AudioSpectrumTracker._Amplitude * _scaleMultiplier) + _startScale, (AudioSpectrumTracker._Amplitude * _scaleMultiplier) + _startScale);
        }
    }
}
