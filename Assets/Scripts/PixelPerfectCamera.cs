using UnityEngine;
 
using System.Collections;
 
// http://aidtech-game.com/pixel-perfect-camera-unity-2d/#.V0I9RY-gqEI
[ExecuteInEditMode]
public class PixelPerfectCamera : MonoBehaviour {
  public float textureSize = 100f;
  float unitsPerPixel;
  
  void Update () {
    unitsPerPixel = 1f / textureSize;
    Camera.main.orthographicSize = (Screen.height / 2f) * unitsPerPixel;
  }
}