using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterLine44 : MonoBehaviour
{



	public GameObject player;
	public GameObject llamadorPrefab22;
	public DibujaLinea lineaPrefab22;
	public int cant;
	private Llamador33[] llamadorPrefab22Clon;
	private DibujaLinea[] lineaPrefab22Clon;
	private GameObject[] soniditos;


	public bool[] entradaTrig;
	public bool[] salidaTrig;

	public bool[] lineaCreadaTrigAB;


	void Awake ()
	{
		for (int i = 0; i < cant; i++) {
			entradaTrig = new bool[cant];
			salidaTrig = new bool[cant];
			lineaCreadaTrigAB=new bool[cant];

			soniditos = new GameObject[cant];
			llamadorPrefab22Clon = new Llamador33 [cant];
			lineaPrefab22Clon = new DibujaLinea[cant];
		}
			
	}

	void Start ()
	{

		for (int i = 0; i < cant; i++) {
			this.soniditos [i] = Instantiate ((GameObject)Resources.Load ("nota_" + i));
			this.soniditos [i].SetActive (true);


		}



		for (int i = 0; i < cant; i++) {
			this.llamadorPrefab22Clon [i] = Instantiate (llamadorPrefab22.GetComponent<Llamador33> ());
			//this.llamadorPrefab22Clon [i].setTrigBClon (soniditos [i]);

			this.lineaPrefab22Clon [i] = Instantiate (lineaPrefab22.GetComponent<DibujaLinea> ());	


		}

//llamadorPrefab22Clon = Instantiate (llamadorPrefab22.GetComponent<Llamador22> ());
		//lineaPrefabClon = Instantiate (lineaPrefab.GetComponent<DibujaLinea> ());

		//	soniditos[0].GetComponent<AudioSource>().Play();

		//	print ("______++__ " + soniditos[0].GetComponent<AudioSource>().time);
	}

	void Update ()
	{
		setLinea ();

	}

	void setDatos ()
	{
		for (int i = 0; i < cant; i++) {

			lineaPrefab22Clon [i].setOrigen (llamadorPrefab22Clon [i].getTrigAClon ().transform.position);
			lineaPrefab22Clon [i].setDestino (player.transform.position);
		}
	}

	/*___________________*/

	void setEntradaSalida ()
	{
		for (int i = 0; i < cant; i++) {
			if (llamadorPrefab22Clon [i].getTrigAClon().GetComponent<Triggersito>().getEntrada ()) {
				entradaTrig [i] = true;
			}

			if (llamadorPrefab22Clon [i].getTrigBClon().GetComponent<TriggersitoSonoro>().getEntrada () && entradaTrig [i] == true) {
				salidaTrig [i] = true;
			}
		}
	}



	void setLinea ()
	{
		setEntradaSalida ();
		for (int i = 0; i < cant; i++) {
			if (entradaTrig [i] == true && salidaTrig [i] == false && lineaCreadaTrigAB[i]== false) {
				lineaPrefab22Clon [i].setOrigen (llamadorPrefab22Clon [i].getTrigAClon().transform.position);
				lineaPrefab22Clon [i].setDestino (player.transform.position);
				lineaPrefab22Clon [i].setActivaEntrada (true);

			}

			if (salidaTrig [i] == true && entradaTrig [i] == true) {
				lineaPrefab22Clon [i].setDestino (llamadorPrefab22Clon [i].getTrigBClon ().transform.position);
				lineaPrefab22Clon [i].setActivaSalida (true);
				//llamadorPrefab22Clon [i].setPlaySonidito (true);
				soniditos[i].GetComponent<AudioSource> ().Play();
				lineaCreadaTrigAB [i] = true;

				if(lineaCreadaTrigAB[i])
				{
					entradaTrig [i] = false;
					salidaTrig [i] = false;
				}

			}

		}
	}

}
