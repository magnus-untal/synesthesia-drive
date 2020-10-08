using UnityEngine;

public class CarMovement : MonoBehaviour
{

	public Rigidbody rb;
    public float forwardForce = 1000f;
    public Transform vehicle;
    // FixedUpdate works better with Physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a")){
        	vehicle.position = new Vector3(-10, 0, vehicle.position.z);
        }
        if (Input.GetKey("s")){
        	vehicle.position = new Vector3(0, 0, vehicle.position.z);
        }
        if (Input.GetKey("d")){
        	vehicle.position = new Vector3(10, 0, vehicle.position.z);
        }
    }
}
