using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llamador33 : MonoBehaviour
{


	public GameObject trigA, trigB;
	public int cant;

	private GameObject trigAClon, trigBClon;
	void Start ()
	{
		float randy = UnityEngine.Random.Range (-15+UnityEngine.Random.Range (0, 4), 15);
		this.trigAClon =Instantiate (trigA, new Vector3 (randy, 5, -20), Quaternion.identity);
		this.trigBClon =Instantiate (trigB, new Vector3 (randy, 5, 0), Quaternion.identity);


	}

	void Update ()
	{
	}

	public GameObject getTrigAClon ()
	{
		return this.trigAClon;
	}

	public GameObject getTrigBClon ()
	{
		return this.trigBClon;
	}

	public int getCant ()
	{
		return cant;
	}

	public void setCant (int cant_)
	{
		cant = cant_;

	}


}
