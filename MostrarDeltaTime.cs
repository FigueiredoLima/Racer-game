using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MostrarDeltaTime : MonoBehaviour {
	// Use this for initialization
	Text texto;
	float pontos;
	void Start () {
		texto = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		texto.text = "Tempo: "+ volta.voltas;
	}
}
