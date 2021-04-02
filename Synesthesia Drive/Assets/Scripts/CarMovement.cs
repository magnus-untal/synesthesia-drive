using UnityEngine;

public class CarMovement : MonoBehaviour
{
    bool pause = false;
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public Transform vehicle;
    // FixedUpdate works better with Physics
    void FixedUpdate()
    {
        vehicle.Translate(Vector3.forward * forwardForce * Time.deltaTime);

        if (Input.GetKey("a")){
        	vehicle.position = new Vector3(480, 3.5f, vehicle.position.z);
        }
        if (Input.GetKey("s")){
        	vehicle.position = new Vector3(500, 3.5f, vehicle.position.z);
        }
        if (Input.GetKey("d")){
        	vehicle.position = new Vector3(520, 3.5f, vehicle.position.z);
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pause = !pause;
            if (pause)
            {
                Time.timeScale = 0f;
                AudioSource[] music = FindObjectsOfType<AudioSource>(); 

                foreach(AudioSource a in music)
                {
                    a.Pause();
                }

            }
            else if (!pause)
            {
                Time.timeScale = 1f;
                AudioSource[] music = FindObjectsOfType<AudioSource>();

                foreach (AudioSource a in music)
                {
                    a.Play();
                }
            }
        }

    }
}
