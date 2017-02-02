@Tooltip ("How fast does the object move?\nMeasured in Unity units per second")
var speed : float = 1;

function Update () {
  transform.position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
}