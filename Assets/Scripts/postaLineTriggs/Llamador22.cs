using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llamador22 : MonoBehaviour
{


	public GameObject trigA, trigB;
	public int cant;

	private GameObject trigAClon, trigBClon;
	void Start ()
	{
		float randy = UnityEngine.Random.Range (-15, 15);
		this.trigAClon =Instantiate (trigA, new Vector3 (randy, 1, -20), Quaternion.identity);
		this.trigBClon =Instantiate (trigB, new Vector3 (randy, 1, 0), Quaternion.identity);


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

