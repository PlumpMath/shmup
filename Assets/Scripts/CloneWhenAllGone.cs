using UnityEngine;

/**
 * Clone a GameObjects when all GameObjects with a certain tag disapear
 */
public class CloneWhenAllGone : MonoBehaviour
{
	// Which tag to watch for
	public string which;

	// The object to clone
	// Can be an object Hierarchy tab
	// or a prefab in the Project tab
	public GameObject clone;

	// How far should the clone be created from this object?
	// Measured in Unity units
	public Vector2 offset;

	// Have we cloned the object yet?
	// Used to prevent us from making multiple copies
	private bool cloned = false;

	void Update()
	{
		// if the number of GameObjects with the tag `which` is zero
		// and we have not cloned yet
		if (GameObject.FindGameObjectsWithTag(which).Length == 0 && !cloned)
		{
			// record the fact that we have cloned
			cloned = true;
			// make a copy of `clone` and position it according to `offset`
			Instantiate(clone, transform.position + transform.TransformDirection(new Vector3(offset.x, offset.y, 0)), transform.rotation);
		}
	}
}
