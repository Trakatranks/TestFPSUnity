using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 10;

    [Range(0,40)]
    public float jumpForce = 10;

    public GameObject Camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float strafe = Input.GetAxis("Horizontal");
        float move = Input.GetAxis("Vertical");

        Debug.DrawRay(transform.position, Vector3.forward, Color.red, Time.deltaTime);

        transform.position = new Vector3(transform.position.x + strafe * Time.deltaTime * speed, transform.position.y, transform.position.z + move * Time.deltaTime * speed);

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
        }

    }
}
