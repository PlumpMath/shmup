using UnityEngine;

/**
 * Clone a GameObject when if a key is pressed
 * Place the new clone next to the GameObject 
 * this component is attached to according to `offset`
 */

public class CloneOnKeyPress : MonoBehaviour
{
	// Which key to listen for
	public string key;

	// The object to clone
	// Can be an object Hierarchy tab
	// or a prefab in the Project tab
	public GameObject clone;

	// How far should the clone be created from this object?
	// Measured in Unity units
	public Vector2 offset;

	void Update()
	{
		// if the key has been pressed and a clone as been set
		if (Input.GetKeyDown(key) && clone)
		{
			// make a copy of `clone` and position it according to `offset`
			Instantiate(clone, transform.position + transform.TransformDirection(new Vector3(offset.x, offset.y, 0)), transform.rotation);
		}
	}
}
