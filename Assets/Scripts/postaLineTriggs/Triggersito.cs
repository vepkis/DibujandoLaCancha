using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggersito : MonoBehaviour
{

	public bool entrada, salida;

	void Start ()
	{
		entrada = false;
		salida = false;

	}

	public void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			entrada = true;
			print ("JUJJUUU----");
		}
		//	print (entrada);
	}

	public void OnTriggerExit (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			
			entrada = false;
		}
	}

	public bool getEntrada ()
	{
		return entrada;
	}

}
