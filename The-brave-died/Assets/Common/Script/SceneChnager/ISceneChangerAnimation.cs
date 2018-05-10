//****************************************************
//ISceneChangerAnimation.cs
//Author harada
//****************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//****************************************************
//
//
//****************************************************
public interface ISceneChangerAnimation
{
  IEnumerator StartInAnimation();
  IEnumerator StartOutAnimation();
}
