using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour {
	private Rigidbody rb;
	public float fuerza;
	public float fuerzaDireccion;
	public float angulo;
	public KeyCode direccionD;
	public KeyCode anguloD;
	public KeyCode anguloI;
	public KeyCode direccionI;
	public KeyCode accion;
	private bool condicion = true;
	public KeyCode retry = KeyCode.R;


	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (retry))
		{
			condicion = true;
		}

		if (Input.GetKey(accion) && condicion == true) 
		{
			

			rb.AddForce (transform.forward * (fuerza * rb.mass));
			condicion = false;

		}

		if (Input.GetKey(direccionD) && condicion == true) 
		{
			transform.Translate (new Vector3 (0.05f ,0,0));
		}

		if (Input.GetKey(direccionI) && condicion == true) 
		{
			transform.Translate (new Vector3 (-0.05f ,0,0));
		}

		if (Input.GetKey (anguloD) && condicion == true) {
			transform.Rotate (new Vector3 (0, angulo, 0)); 
		}

		if (Input.GetKey (anguloI) && condicion == true) {
			transform.Rotate (new Vector3 (0, -angulo, 0)); 
		}
	}
}
