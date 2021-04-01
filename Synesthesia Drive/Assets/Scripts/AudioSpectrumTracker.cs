using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class AudioSpectrumTracker : MonoBehaviour
{

    AudioSource _audioSource;
    public static float[] _audioSamples = new float[512];
    float[] _freqBand = new float[8];
    float[] _bandBuffer = new float[8];
    float[] _freqBandHighest = new float[8];
    

    float[] _bufferDecrease = new float[8];
    public static float[] _audioBand = new float[8];
    public static float[] _audioBandBuffer = new float[8];

    public static float _Amplitude, _AmplitudeBuffer;
    float _AmplitudeHighest;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        for(int i = 0; i<8; i++){
            _audioBand[i] = 0.01f;
            _audioBandBuffer[i] = 0.01f;
            _freqBandHighest[i] = 0.01f;
            _AmplitudeHighest = 0.01f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
        BandBuffer();
        CreateAudioBands();
        GetAmplitude();
    }

    void GetAmplitude(){
        float _CurrentAmplitude = 0;
        float _CurrentAmplitudeBuffer = 0;
        for(int i = 0; i<8; i++){
            _CurrentAmplitude += _audioBand[i];
            _CurrentAmplitudeBuffer += _audioBandBuffer[i];
        }
        if(_CurrentAmplitude > _AmplitudeHighest){
            _AmplitudeHighest = _CurrentAmplitude;
        }
        _Amplitude = _CurrentAmplitude / _AmplitudeHighest;
        _AmplitudeBuffer = _CurrentAmplitudeBuffer / _AmplitudeHighest;
    }

    void CreateAudioBands(){
        for(int i = 0; i< 8; i++){
            if(_freqBand[i] > _freqBandHighest[i]){
                _freqBandHighest[i] = _freqBand[i];
            }
            _audioBand[i] = (_freqBand[i] / _freqBandHighest[i]);
            _audioBandBuffer[i] = (_bandBuffer[i] / _freqBandHighest[i]);
        }
    }

    void GetSpectrumAudioSource(){
        _audioSource.GetSpectrumData(_audioSamples, 0, FFTWindow.Blackman);
    }

    void BandBuffer(){
        for(int i = 0; i<8; i++){
            if(_freqBand[i] > _bandBuffer[i]){
                _bandBuffer[i] = _freqBand[i];
                _bufferDecrease[i] = 0.005f;
            }

            if(_freqBand[i] < _bandBuffer[i]){
                _bandBuffer[i] -= _bufferDecrease[i];
                _bufferDecrease[i] *= 1.2f;// increase speed by 20%
            }
        }
    }

    void MakeFrequencyBands(){
        /*
            22050 / 512 = 43hz/sample *2
            Can divide into 7 channels
            20-60
            60-250
            250-500
            500-2000
            2000-4000
            4000-6000
            6000-20000

            0 - 2 samples - 86hz
            1 - 4 samples - 172 hz
            2 - 8 samples - 344 hz
            3 - 16 samples - 688 hz
            4 - 32 samples - 1376 hz
            5 - 64 samples - 2752 hz
            6 - 128 samples - 5504 hz
            7 - 256 samples - 11008 hz
            510 samples used
        */
        int count = 0;
        for(int i = 1; i<=8; i++){ //start at 1 for math power calculations

            float average = 0;
            int sampleCount = (int) Mathf.Pow(2,i);
            if(i==8){
                sampleCount += 2;
            }
            for(int j = 0; j<sampleCount; j++){
                average += _audioSamples[count] * (count + 1);
                count++;
            }
            average /= count;
            _freqBand[i-1] = average * 10;
        }
    }


}
