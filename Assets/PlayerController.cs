
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float smooth = 1f; 
	public float rotateSpeed = 130; 
	private Rigidbody rb;
	private Vector3 targetAngles; 

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float rotateHorizontal = Input.GetAxis ("Horizontal2");
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float moveVertical2 = Input.GetAxis ("Vertical2");

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, moveVertical2);

		//ROTATE 

		/*if (Input.GetButtonDown("a"))
			transform.Rotate (Vector3.right * rotateSpeed * Time.deltaTime);
		
		else if (Input.GetButtonDown ("d"))
			transform.Rotate (-Vector3.right * rotateSpeed * Time.deltaTime);*/

		transform.Rotate (rotateHorizontal* Vector3.up * rotateSpeed * Time.deltaTime);


		rb.AddForce (movement * speed);
	}
}