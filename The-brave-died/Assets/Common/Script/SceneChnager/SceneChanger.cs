using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour,ISceneChanger
{
  string nowSceneName = "";
  bool isInitialized;
  bool isLoaded;

  public bool IsInitialized { set { isInitialized = value; } }
  public bool IsLoaded { get { return isLoaded; } }

  //シーン切り替え関数
  public IEnumerator ChangeScene(string nextSceneName)
  {
    isInitialized = false;
    isLoaded = false;
    //ロードされているシーンがあれば廃棄
    if(!string.IsNullOrEmpty(nowSceneName))
    {
      var op = SceneManager.UnloadSceneAsync(nowSceneName);
      while (!op.isDone)
        yield return null;
    }

    var op2 = SceneManager.LoadSceneAsync(nextSceneName, LoadSceneMode.Additive);
    while (!op2.isDone && !isInitialized)
      yield return null;

    nowSceneName = nextSceneName;
    isLoaded = true;
  }
}
