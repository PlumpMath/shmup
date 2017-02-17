using UnityEngine;

/**
 * Moves the attached object upwards while the up key is pressed,
 * downwards while the down key is pressed, at a constant speed
 */
public class KeyboardUpDownMover : MonoBehaviour
{
	// How fast does the object move?
	// Measured in Unity units per second
	public float speed = 1;

	void Update()
	{
		// speed: how fast to move every second
		// Time.deltaTime: number of seconds since the last frame
		// Input.GetAxis("Vertical"): 1 if up key is pressed, -1 if down key is pressed
		// multiplying them all produces a distance that we can add to the current
		// y coordinate to move up or down at the speed we chose depending
		// on the up and down keys
		// we reuse the current x and z positions
		transform.position = new Vector3(
			transform.position.x,
			transform.position.y + Input.GetAxis("Vertical") * speed * Time.deltaTime,
			transform.position.z);
	}
}
