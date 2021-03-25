using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Camera))]
public class FloatingOrigin : MonoBehaviour
{
    public float threshold = 100.0f;
    public LevelLayoutGenerator layoutGenerator;

    void LateUpdate(){
        Vector3 cameraPosition = gameObject.transform.position;
        cameraPosition.y = 0;

        if(cameraPosition.magnitude > threshold){
            for(int z = 0; z <SceneManager.sceneCount; z++){
                foreach(GameObject g in SceneManager.GetSceneAt(z).GetRootGameObjects()){
                    g.transform.position = g.transform.position - new Vector3(0, 0, cameraPosition.z);
                    //g.transform.position = g.transform.position - cameraPosition;
                }
            }
        }
        Vector3 originDelta = Vector3.zero - cameraPosition;
        layoutGenerator.UpdateSpawnOrigin(originDelta);
        //Debug.Log("recentering, origin delta = " + originDelta);
    }
}
