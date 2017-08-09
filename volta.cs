using UnityEngine;
using System.Collections;

public class volta : MonoBehaviour {

	public static float voltas = 0f;
	private float temp = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		temp++;
	}
	void OnTriggerEnter2D (Collider2D outro) {

		voltas = temp;
		voltas = voltas / 50;
		temp = 0;
	}
}
