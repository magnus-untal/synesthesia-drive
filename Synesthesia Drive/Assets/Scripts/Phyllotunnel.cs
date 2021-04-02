using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phyllotunnel : MonoBehaviour
{
    public Transform _tunnel3D, _phyllon2D;
    public AudioSpectrumTracker _audioSpectrumTracker;
    public float _tunnelSpeed, _cameraDistance;
    public Vector3 _cameraOffset;

    // Update is called once per frame
    void Update()
    {
        _tunnel3D.position = new Vector3(_tunnel3D.position.x, _tunnel3D.position.y, 
            _tunnel3D.position.z + (_audioSpectrumTracker._AmpBuffer * _tunnelSpeed));
        _phyllon2D.position = new Vector3(_phyllon2D.position.x, _phyllon2D.position.y, _phyllon2D.position.z + 
            (_audioSpectrumTracker._AmpBuffer * _tunnelSpeed));
        this.transform.position = new Vector3(_cameraOffset.x,_cameraOffset.y, _tunnel3D.position.z + _cameraOffset.z);
    }
}
