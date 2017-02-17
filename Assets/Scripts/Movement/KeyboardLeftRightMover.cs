using UnityEngine;

/**
 * Moves the attached object leftwards while the left key is pressed,
 * rightwards while the right key is pressed, at a constant speed
 */
public class KeyboardLeftRightMover : MonoBehaviour
{
	// How fast does the object move?
	// Measured in Unity units per second
	public float speed = 1;

	void Update()
	{
		// speed: how fast to move every second
		// Time.deltaTime: number of seconds since the last frame
		// Input.GetAxis("Horizontal"): 1 if right key is pressed, -1 if left key is pressed
		// multiplying them all produces a distance that we can add to the current
		// x coordinate to move left or right at the speed we chose depending
		// on the left and right keys
		// we reuse the current y and z positions
		transform.position = new Vector3(
			transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime,
			transform.position.y,
			transform.position.z);
	}
}
