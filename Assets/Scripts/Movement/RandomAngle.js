@Range (0, 360)
var minimumAngle : float = 0;

@Range (0, 360)
var maximumAngle : float = 360;

function Start () {
  transform.eulerAngles.z = Random.Range(minimumAngle, maximumAngle);
}