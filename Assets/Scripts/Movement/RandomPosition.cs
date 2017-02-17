using UnityEngine;

/**
 * Position the attached GameObject at a random position within the boundaries
 */
public class RandomPosition : MonoBehaviour
{
	// The width and height of the area to position inside of
	public Vector2 boundaries;

	void Start()
	{
		// set the position of the attached object to be a random x
		// and random y within the boundaries
		transform.position = new Vector3(Random.Range(-boundaries.x, boundaries.x),
		                                 Random.Range(-boundaries.y, boundaries.y),
		                                 0);
	}
}
