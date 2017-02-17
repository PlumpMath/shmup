using UnityEngine;

/**
 * Clone a GameObject if the GameObject this component is attached to collides
 * with another GameObject with a particular tag
 */
public class CloneOnCollison : MonoBehaviour
{
	// Only objects with this tag will be considered for collision
	// If blank, all collisions will be considered
	public string with;

	// The object to clone
	// Can be an object Hierarchy tab
	// or a prefab in the Project tab
	public GameObject clone;

	// How far should the clone be created from this object?
	// Measured in Unity units
	public Vector2 offset;

	void OnCollisionEnter2D(Collision2D collision)
	{
		// if we clone is not null and we collide with a GameObject
		// with a tag matching `with`
		if (clone != null && collision.gameObject.tag == with)
		{
			// make a copy of `clone` and position it according to `offset`
			Instantiate(clone, transform.position + new Vector3(offset.x, offset.y, 0), transform.rotation);
		}
	}
}
