using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
    float mousePosInBlock;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        mousePosInBlock = (Input.mousePosition.x / Screen.width) * 16;
        Vector3 paddlePos = new Vector3(Mathf.Clamp(mousePosInBlock, 0f, 12f), 0f, 0f);
        this.transform.position = paddlePos;
	}
}
