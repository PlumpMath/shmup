using UnityEngine;
using System.Collections;

public class AlwaysLookAt : MonoBehaviour {
	public GameObject target;

	void Update () {
		transform.up = target.transform.position - transform.position;
	}
}
