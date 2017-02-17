using UnityEngine;

/**
 * Rotate the attached object left while the left key is pressed,
 * right while the right key is pressed, at a constant speed
 */
public class KeyboardRotater : MonoBehaviour
{
	// How fast does the object rotate?
	// Measured in angles per second.
	public float speed = 1;

	void Update()
	{
		// speed: how many angles to rotate every second
		// Time.deltaTime: number of seconds since the last frame
		// Input.GetAxis("Horizontal"): 1 if right key is pressed, -1 if left key is pressed
		// multiplying them together produces an angle to rotate the attached
		// object by. we use -Input.GetAxis("Horizontal") instead of Input.GetAxis("Horizontal")
		// because it felt more natural
		transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * speed * Time.deltaTime);
	}
}