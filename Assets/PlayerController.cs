using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

	public float movementSpeed = 5.0f;
	public float clockwise = 50.0f;
	public float counterClockwise = -50.0f;

	void Start () {
	}

	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.A)) {
			transform.position -= transform.right * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.D)) {
			transform.position += transform.right * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += transform.up * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position -= transform.up * Time.deltaTime * movementSpeed;
		}else if(Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate(0, Time.deltaTime * clockwise, 0);
		}else if(Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
		}
	}
}