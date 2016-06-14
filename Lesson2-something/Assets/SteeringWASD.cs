using UnityEngine;

public class SteeringWASD : MonoBehaviour {
    public float speed;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float movehorizontal = Input.GetAxis("Horizontal");
        float moveverticle = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-movehorizontal, moveverticle, 0.0f);
        rb.AddForce(movement * speed);
    }
}
