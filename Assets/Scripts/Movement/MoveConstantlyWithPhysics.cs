using UnityEngine;
using System.Collections;

public class MoveConstantlyWithPhysics : MonoBehaviour {
	public Vector2 direction = Vector2.up;

	void Update () {
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		rb.MovePosition(rb.position + direction * Time.deltaTime);
	}
}
