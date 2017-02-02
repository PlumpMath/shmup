var boundaries : Vector2;

function LateUpdate () {
  if(transform.position.x > boundaries.x)
    Destroy(gameObject);
  else if(transform.position.x < -boundaries.x)
    Destroy(gameObject);
  else if(transform.position.y > boundaries.y)
    Destroy(gameObject);
  else if(transform.position.y < -boundaries.y)
    Destroy(gameObject);
}