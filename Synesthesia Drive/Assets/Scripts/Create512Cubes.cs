using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create512Cubes : MonoBehaviour
{
    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCubes = new GameObject[512];
    public float _maxSize;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 512; i++){
            GameObject _instanceSampleCube = (GameObject)Instantiate (_sampleCubePrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            _instanceSampleCube.transform.position = Vector3.forward * 500;
            _sampleCubes[i] = _instanceSampleCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i<512; i++){
            if(_sampleCubes != null){
                _sampleCubes[i].transform.localScale = new Vector3(5, AudioSpectrumTracker._audioSamples[i] * _maxSize + 2, 5);
            }
        }
    }
}
