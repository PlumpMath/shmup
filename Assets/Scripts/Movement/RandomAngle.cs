using UnityEngine;

/**
 * Start the attached object rotated at a random angle
 */
public class RandomAngle : MonoBehaviour
{
	// The smallest angle allowed
	public float minimumAngle = 0;

	// The largest angle allowed
	public float maximumAngle = 360;

	void Start()
	{
		// generate a random number between the smallest and largest angles allowed
		// and set the rotation in z to that value
		transform.eulerAngles = new Vector3(0, 0, Random.Range(minimumAngle, maximumAngle));
	}
}
