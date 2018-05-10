//****************************************************
//ISceneChanger.cs
//Author harada
//****************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//****************************************************
//
//
//****************************************************
public interface ISceneChanger
{
  bool IsInitialized { set; }//ロード先でtrueにするまでロード完了はしない
  bool IsLoaded { get; }
  IEnumerator ChangeScene(string nextSceneName);
}
