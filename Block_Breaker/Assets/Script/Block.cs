using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	public int maxHits;
	private int timeHits;

	// Use this for initialization
	void Start () {
		timeHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D collision) {
		timeHits ++;
	}
}
