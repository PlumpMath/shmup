var which : String;

@Tooltip ("The object to clone\nCan be an object Hierarchy tab\nor a prefab in the Project tab")
var clone : GameObject;

@Tooltip ("How far should the clone be created from this object?\nMeasured in Unity units")
var offset : Vector2;

private var cloned : boolean = false;

function Update () {
  if(GameObject.FindGameObjectsWithTag(which).Length == 0 && !cloned) {
    cloned = true;
    Instantiate(clone, transform.position + transform.TransformDirection(Vector3(offset.x, offset.y, 0)), transform.rotation);
  }
}