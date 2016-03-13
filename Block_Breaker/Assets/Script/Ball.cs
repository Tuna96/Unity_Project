using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private bool hasStart;
	private Vector3 paddleToBall = new Vector3();

	public Paddle paddle;
	// Use this for initialization
	void Start () {
		hasStart = false;
		paddleToBall = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasStart) {
			this.transform.position = paddleToBall + paddle.transform.position;
			}
		if (Input.GetMouseButtonDown (0)) {
			hasStart = true;
			this.GetComponent<Rigidbody2D>().velocity = new Vector2 (5f, 20f);
		}			
	}
}
