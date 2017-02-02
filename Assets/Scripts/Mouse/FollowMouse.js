@Tooltip ("How close does the object follow the mouse?\n0 means don't move at all\n1 means match the mouse's position exactly")
@Range (0, 1)
var closeness : float = 1;

function Update () {
  var mouseCoords = Camera.main.ScreenToWorldPoint(Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
  transform.position = Vector3.Lerp(transform.position, mouseCoords, closeness);
}