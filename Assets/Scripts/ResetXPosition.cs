using UnityEngine;
using System.Collections;

public class ResetXPosition : MonoBehaviour {
	public float minimumX;
	public float resetTo;
	void Update () {
		if (transform.position.x < minimumX)
		{
			transform.position = new Vector3(transform.position.x + resetTo, transform.position.y, transform.position.z);
		}
	}
}
