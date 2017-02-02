@script RequireComponent(Collider2D)

@Tooltip ("Only objects with this tag will be considered for collision\nIf blank, all collisions will be considered")
var with : String;

@Tooltip ("The object to clone\nCan be an object Hierarchy tab\nor a prefab in the Project tab")
var clone : GameObject;

@Tooltip ("How far should the clone be created from this object?\nMeasured in Unity units")
var offset : Vector2;

function OnCollisionEnter2D (collision : Collision2D) {
  if(clone && (with == "" || collision.gameObject.tag == with))
    Instantiate(clone, transform.position + Vector3(offset.x, offset.y, 0), transform.rotation);
}