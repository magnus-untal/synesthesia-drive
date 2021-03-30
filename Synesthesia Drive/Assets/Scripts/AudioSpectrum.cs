using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{

    public static float spectrumValue {get; private set;} // to be accessed by other classes
    private float[] m_audioSpectrum; // storing music beats
    // Start is called before the first frame update
    void Start()
    {
        //array must be power of 2
        m_audioSpectrum = new float[128];
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hamming); //filling spectrum array

        if(m_audioSpectrum != null && m_audioSpectrum.Length > 0){
            spectrumValue = m_audioSpectrum[0] * 100;
        }
    }
}
