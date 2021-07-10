using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
 public GameObject player;
 public Vector3 offset;
 
 void Start()
 {
     offset = transform.position - player.transform.position;
 }
 
 void LateUpdate()
 {
     float newXPosition = player.transform.position.x + offset.x;
     float newYPosition = player.transform.position.y + offset.y;
     float newZPosition = player.transform.position.z + offset.z;
 
     transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
 }
}
