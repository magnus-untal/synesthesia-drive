using UnityEngine;

public class CarMovement : MonoBehaviour
{

	public Rigidbody rb;
    public float forwardForce = 1000f;
    public Transform vehicle;
    // FixedUpdate works better with Physics
    void FixedUpdate()
    {
        vehicle.Translate(Vector3.forward * 100 * Time.deltaTime);

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
