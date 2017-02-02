var key : String;

@Tooltip ("The object to clone\nCan be an object Hierarchy tab\nor a prefab in the Project tab")
var clone : GameObject;

@Tooltip ("How far should the clone be created from this object?\nMeasured in Unity units")
var offset : Vector2;


function Update () {
  if(Input.GetKeyDown(key) && clone) {
    Instantiate(clone, transform.position + transform.TransformDirection(Vector3(offset.x, offset.y, 0)), transform.rotation);
  }
}