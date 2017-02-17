using UnityEngine;
using System.Collections;

public class FlapOnKeyPress : MonoBehaviour {
	public string key = "space";
	public float force = 1;
	public Vector2 direction = Vector2.up;

	void Update () {
		if (Input.GetKey(key))
		{
			GetComponent<Rigidbody2D>().AddForce(direction * force * Time.deltaTime, ForceMode2D.Impulse);
		}
	}
}
