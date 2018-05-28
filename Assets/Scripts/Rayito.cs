using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayito : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	RaycastHit hit;
	Ray ray;

	void Update()
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(ray, out hit))
		{
			Debug.Log(" you clicked on " + hit.collider.gameObject.name);

			if(hit.collider.gameObject.name == "Your 3D Model Name")
			{
				// Write things you want to do when you click.
			}
		}
	}
}
