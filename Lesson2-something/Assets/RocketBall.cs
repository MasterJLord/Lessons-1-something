using UnityEngine;
using System.Collections;

public class RocketBall : MonoBehaviour {

    public float kickAmount = 1.0f;

    private Rigidbody m_myRigidBody;

	// Use this for initialization
	void Start () {
        m_myRigidBody = transform.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        m_myRigidBody.AddForce(kickAmount, 0.0f, 0.0f, ForceMode.Impulse);
        
    }
}
