@Tooltip ("How fast does the object rotate?\nMeasured in angles per second.")
var speed : float = 1;

function Update () {
  transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * speed * Time.deltaTime);
}