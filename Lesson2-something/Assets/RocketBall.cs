using UnityEngine;
using System.Collections;

public class RocketBall : MonoBehaviour {

    public float kickAmount = 1.0f;
    public float testingTimePassed = 0;
    public float spacespeedbuff = 0.02f;

    private Rigidbody m_myRigidBody;

	// Use this for initialization
	void Start () {
        m_myRigidBody = transform.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        m_myRigidBody.AddForce(0.0f, 0.0f, kickAmount, ForceMode.Impulse);
        kickAmount += 0.01f;
        if (kickAmount > 0.0f)
        {
            kickAmount = 0.0f;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            kickAmount -= spacespeedbuff;
        }

        if (Input.GetKey(KeyCode.R))
        {
            kickAmount = 0;
            m_myRigidBody.velocity = Vector3.zero;
            m_myRigidBody.angularVelocity = Vector3.zero;
            transform.position = new Vector3(-7.5f, 8.5f, 7.0f);
        }

    }
}
