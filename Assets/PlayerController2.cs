using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]
public class PlayerController2 : MonoBehaviour {

	public float movementSpeed = 5.0f;
	public float clockwise = 50.0f;
	public float counterClockwise = -50.0f;

	void Start () {
	}

	void Update () {
		if (Input.GetKey (KeyCode.Y)) {
			transform.position += transform.forward * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.H)) {
			transform.position -= transform.forward * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.G)) {
			transform.position -= transform.right * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.J)) {
			transform.position += transform.right * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.Keypad8)) {
			transform.position += transform.up * Time.deltaTime * movementSpeed;
		} else if (Input.GetKey (KeyCode.Keypad5)) {
			transform.position -= transform.up * Time.deltaTime * movementSpeed;
		}else if(Input.GetKey(KeyCode.Keypad6)) {
			transform.Rotate(0, Time.deltaTime * clockwise, 0);
		}else if(Input.GetKey(KeyCode.Keypad4)) {
			transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
		}
	}
}