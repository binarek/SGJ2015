﻿#pragma strict

var speed : float = 5.0;
 var target : Transform;
  
 function Update () {
     if (Input.GetMouseButton(0)) {
         transform.LookAt(target);
         transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X")*speed);
     }
 }
