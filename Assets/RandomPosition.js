var boundaries : Vector2;

function Start () {
  transform.position = Vector3(Random.Range(-boundaries.x, boundaries.x),
                               Random.Range(-boundaries.y, boundaries.y),
                               0);
}