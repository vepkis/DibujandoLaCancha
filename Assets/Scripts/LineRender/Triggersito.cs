using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggersito : MonoBehaviour
{

	public bool entrada, salida;
	//public GameObject Player;
	// Use this for initialization
	void Start ()
	{
		entrada = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}



	public void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			entrada = true;
		}

	}

	public void OnTriggerExit ()
	{
		entrada = false;
	}
	/*

	public bool getDentro()
	{
		return entrada;
	}
	*/

	public bool getEntrada ()
	{
		return entrada;
	}

}
