using UnityEngine;
using System.Collections;

public class UpAndDown : MonoBehaviour {
	public float amplitude;
	public float frequency;
	float initialY;

	void Start () {
		initialY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, initialY + amplitude * Mathf.Sin(Time.time * frequency), transform.position.z);
	}
}
