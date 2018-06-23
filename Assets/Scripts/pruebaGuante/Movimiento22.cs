using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento22 : MonoBehaviour {

	// Use this for initialization
	public float speed = 10.0F;
	//Velocidad de movimiento
	//		public float rotationSpeed = 100.0F;
	//Velocidad de rotación

	void Update ()
	{
		float movHorizontal = Input.GetAxis ("Horizontal");
		float movVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (movHorizontal, 0f, movVertical);

		transform.Translate (movement * Time.deltaTime * speed);
	}
}
