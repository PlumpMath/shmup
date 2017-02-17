using UnityEngine;

/**
 * Constantly moves the attached GameObject forward at a constant speed
 */
public class ForwardMover : MonoBehaviour
{
	// How fast does the object move?
	// Measured in Unity units per second
	public float speed = 1;

	void Update()
	{
		// transform.up: the direction the object is facing in 2d
		// speed: how fast to move every second
		// Time.deltaTime: number of seconds since the last frame
		// multiplying them all produces a vector that we can add to the current
		// position to constantly move forward or backwards at the speed we chose
		transform.position += transform.up * speed * Time.deltaTime;
	}
}
