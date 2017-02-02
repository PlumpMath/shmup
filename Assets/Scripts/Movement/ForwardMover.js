﻿@Tooltip ("How fast does the object move?\nMeasured in Unity units per second")
var speed : float = 1;

function Update () {
  transform.position += transform.up * speed * Time.deltaTime;
}