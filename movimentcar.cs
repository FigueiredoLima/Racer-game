using UnityEngine;
using System.Collections;

public class movimentcar : MonoBehaviour {

	private float velocidade = 0f;
	private float velocidaderot = 150f;

	float zrotation = 269.66f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			velocidade += 0.2f;
			velocidaderot -= 0.5f;
			velocidade = velocidade > 35 ? 35 : velocidade;
			velocidaderot = velocidaderot < 150 ? 150 : velocidaderot;

	
		} else { 
			velocidade -= 0.10f;
			velocidaderot += 0.2f;
			velocidade = velocidade < 0 ? 0 : velocidade;
			velocidaderot = velocidaderot > 500 ? 500 : velocidaderot;


	
				
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			velocidade -= 0.50f;
			velocidaderot += 0.20f;
		}
	

	
		transform.Translate (Vector3.up * Time.deltaTime * velocidade);

		zrotation -= Input.GetAxis ("Horizontal") * velocidaderot * Time.deltaTime * (velocidade > 0 ? 1 : 0);
		transform.eulerAngles = new Vector3 (0, 0, zrotation);
	
	}
	
}

