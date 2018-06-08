using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMano : MonoBehaviour {

	public GameObject Clavija;

	public float speed = 10.0F; //Velocidad de movimiento
	public float rotationSpeed = 100.0F; //Velocidad de rotación

	private Vector3 posClavija;
	void Start()
	{
//		Clavija = GameObject.GetComponents<>();
//		posClavija = Clavija.GetComponent <Position>(); 
	}

	void Update() {
	//	transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
	//	transform.rota (0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime , 0);
	
	
	
		float smooth = 5.0f;
		float tiltAngle = 270.0f;

			// Smoothly tilts a transform towards a target rotation.
			float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
			float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

			Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

			// Dampen towards the target rotation
			transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

	
	}
}
