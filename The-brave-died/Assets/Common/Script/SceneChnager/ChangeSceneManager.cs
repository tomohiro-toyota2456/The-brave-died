using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneManager : UnitySingleton<ChangeSceneManager>
{
  [SerializeField]
  string startSceneName;

  ISceneChanger sceneChanger;
  ISceneChangerAnimation changerAnimation;

  public bool IsInitialized { set { sceneChanger.IsInitialized = value; } }
  public bool IsLoaded { get; private set; }
	// Use this for initialization
	void Start ()
  {
    sceneChanger = GetComponent<ISceneChanger>();
    changerAnimation = GetComponent<ISceneChangerAnimation>();
    ChangeScene(startSceneName);
	}

  public void ChangeScene(string sceneName)
  {
    StartCoroutine(_ChangeScene(sceneName));
  }

  IEnumerator _ChangeScene(string sceneName)
  {
    IsLoaded = false;
    yield return changerAnimation.StartInAnimation();
    yield return sceneChanger.ChangeScene(sceneName);
    yield return changerAnimation.StartOutAnimation();
    IsLoaded = true;   
  }
}
