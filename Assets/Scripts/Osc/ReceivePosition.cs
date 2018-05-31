//recordar setActive y crear un array de imagenes


using UnityEngine;
using System.Collections;

public class ReceivePosition : MonoBehaviour
{
    
	public OSC osc;
	public Vector3 valorVector;

	public float velocidad = 10.0F; //Velocidad de movimiento
	public float rotationSpeed = 100.0F; //Velocidad de rotación

	// Use this for initialization
	public void Start ()
	{
		osc.SetAddressHandler ("/user1/guanteDer/PosX", OnReceiveX);
		osc.SetAddressHandler ("/user1/guanteDer/PosY", OnReceiveY);
		osc.SetAddressHandler ("/user1/guanteDer/PosZ", OnReceiveZ);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	//Recordar que esto hay que modificarlo!__K	
	void OnReceiveX (OscMessage message)
	{
		float x = message.GetFloat (0);

		valorVector = transform.position;

		valorVector.x = x*velocidad*Time.deltaTime;

		transform.position = valorVector;

	}

/*	void OnReceiveX (OscMessage message)
	{
		float x = message.GetFloat (0);

		valorVector = transform.position;

		valorVector.x = x;

		transform.position = valorVector;

	}
*/
	void OnReceiveY (OscMessage message)
	{
		float y = message.GetFloat (0);

		valorVector = transform.position;

		valorVector.y = y;

		transform.position = valorVector;
	}

	void OnReceiveZ (OscMessage message)
	{
		float z = message.GetFloat (0);

		valorVector= transform.position;

		valorVector.z = z;

		transform.position = valorVector;
	}


	public Vector3 getValorVector ()
	{

		return valorVector;
	}





}
