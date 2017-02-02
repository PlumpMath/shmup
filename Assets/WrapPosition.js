var boundaries : Vector2;

function LateUpdate () {
  if(transform.position.x > boundaries.x)
    transform.position.x -= boundaries.x * 2;
  else if(transform.position.x < -boundaries.x)
    transform.position.x += boundaries.x * 2;
  else if(transform.position.y > boundaries.y)
    transform.position.y -= boundaries.y * 2;
  else if(transform.position.y < -boundaries.y)
    transform.position.y += boundaries.y * 2;
}