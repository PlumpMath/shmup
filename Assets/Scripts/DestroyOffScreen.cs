using UnityEngine;

/**
 * Remove the attached GameObject if it leaves the boundaries
 */
public class DestroyOffScreen : MonoBehaviour
{
	// The width and height of the allowed area
	// if the attached GameObject leaves this area
	// it will be removed from the game
	public Vector2 boundaries;

	void LateUpdate()
	{
		// if the attached GameObject exceeds the boundaries
		// on any axis in any direction, remove it
		if (transform.position.x > boundaries.x)
			Destroy(gameObject);
		else if (transform.position.x < -boundaries.x)
			Destroy(gameObject);
		else if (transform.position.y > boundaries.y)
			Destroy(gameObject);
		else if (transform.position.y < -boundaries.y)
			Destroy(gameObject);
	}
}
