using UnityEngine;

/**
 * Keep the attached GameObject within the boundaries,
 * wrapping it around if it ever leaves
 */
public class WrapPosition : MonoBehaviour
{
	// The width and height of the allowed area
	// if the attached GameObject leaves this area
	// it will be wrapped around
	public Vector2 boundaries;

	void LateUpdate()
	{
		// if the attached GameObject exceeds the boundaries
		// on any axis in any direction, wrap it around
		if (transform.position.x > boundaries.x)
			transform.position = new Vector3(transform.position.x - boundaries.x * 2,
											 transform.position.y,
											 transform.position.z);
		else if (transform.position.x < -boundaries.x)
			transform.position = new Vector3(transform.position.x + boundaries.x * 2,
											 transform.position.y,
											 transform.position.z);
		else if (transform.position.y > boundaries.y)
			transform.position = new Vector3(transform.position.x,
											 transform.position.y - boundaries.y * 2,
											 transform.position.z);
		else if (transform.position.y < -boundaries.y)
			transform.position = new Vector3(transform.position.x,
											 transform.position.y + boundaries.y * 2,
											 transform.position.z);	}
}
