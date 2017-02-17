using UnityEngine;

/**
 * Moves the attached GameObject forward while the up key is pressed,
 * backwards while the down key is pressed, at a constant speed
 */
public class KeyboardForwardBackwardMover : MonoBehaviour
{
	// How fast does the object move?
	// Measured in Unity units per second
	public float speed = 1;

	void Update()
	{
		// transform.up: the direction the object is facing in 2d
		// speed: how fast to move every second
		// Time.deltaTime: number of seconds since the last frame
		// Input.GetAxis("Vertical"): 1 if up key is pressed, -1 if down key is pressed
		// multiplying them all produces a vector that we can add to the current
		// position to move forward or backwards at the speed we chose depending
		// on the up and down keys
		transform.position += Input.GetAxis("Vertical") * transform.up * speed * Time.deltaTime;
	}
}
