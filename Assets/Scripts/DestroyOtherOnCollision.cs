using UnityEngine;

/**
 * Destroy GameObjects colliding with the GameObject this component is
 * attached to if they have a matching tag
 */
public class DestroyOtherOnCollision : MonoBehaviour
{
	// Only objects with this tag will be considered for collision
	// If blank, all collisions will be considered
	public string with;

	void OnCollisionEnter2D(Collision2D collision)
	{
		// if we collide with a GameObject with a tag matching `with`
		if (collision.gameObject.tag == with)
		{
			// destroy it
			Destroy(collision.gameObject);
		}
	}
}
