using UnityEngine;

/**
 * Destroy the GameObject this component is attached to if it collides with
 * a GameObject that has a matching tag
 */
public class DestroySelfOnCollision : MonoBehaviour
{
	// Only objects with this tag will be considered for collision
	// If blank, all collisions will be considered
	public string with;

	void OnCollisionEnter2D(Collision2D collision)
	{
		// if we collide with a GameObject with a tag matching `with`
		if (collision.gameObject.tag == with)
		{
			// destroy the GameObject this component is attached to
			Destroy(gameObject);
		}
	}
}
