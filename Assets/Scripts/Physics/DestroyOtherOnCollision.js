@Tooltip ("Only objects with this tag will be considered for collision\nIf blank, all collisions will be considered")
var with : String;

function OnCollisionEnter2D(collision : Collision2D) {
  if(with == "" || collision.gameObject.tag == with)
    Destroy(collision.gameObject);
}