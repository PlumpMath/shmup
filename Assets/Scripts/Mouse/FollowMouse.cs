using UnityEngine;

/**
 * Cause the attached GameObject to follow the mouse
 */
public class FollowMouse : MonoBehaviour
{
	// How close does the object follow the mouse?
	// 0 means don't move at all
	// 1 means match the mouse's position exactly
	public float closeness = 1;

	void Update()
	{
		// use the camera to compute where the mouse pointer
		// is in unity's world coordinates
		Vector3 mouseCoords = Camera.main.ScreenToWorldPoint(
			new Vector3(Input.mousePosition.x,
						Input.mousePosition.y,
						Camera.main.nearClipPlane));

		// move towards the mouse's world coordinates
		transform.position = Vector3.Lerp(transform.position, mouseCoords, closeness);
	}
}
