using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersitoSonoro : MonoBehaviour {

//	public GameObject sonidito;
	private AudioSource soniditoClon;

	public bool entrada, salida;

	void Start ()
	{
		entrada = false;
		salida = false;
	//	soniditoClon=Instantiate(sonidito.GetComponent<AudioSource>());
	//	soniditoClon.SetActive (true);


	}
		
	void Update()
	{
	}

	public void setSonidito(GameObject objetoSonoro_)
	{
		this.soniditoClon = (AudioSource)Instantiate(objetoSonoro_.GetComponent<AudioSource> ());
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
		
	public void disparaSonidito ()
	{
		if (entrada && Input.GetKey(KeyCode.E))
		{
			soniditoClon.Play ();
		//	sonidito.GetComponent<AudioSource> ().Play ();
			//       Destroy(this.gameObject);
		}
	}

	public void disparaSoniditoII (bool playSonidito_)
	{
		if (playSonidito_)
		{
			soniditoClon.Play ();
		}
	}

	public bool getEntrada ()
	{
		return entrada;
	}

}
