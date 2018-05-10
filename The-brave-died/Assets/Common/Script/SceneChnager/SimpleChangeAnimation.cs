//****************************************************
//SimpleChangeAnimation
//
//****************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SimpleChangeAnimation : MonoBehaviour,ISceneChangerAnimation
{
  [SerializeField]
  Image fadeImage;
  [SerializeField]
  float duration;


  public IEnumerator StartInAnimation()
  {
    bool isTweening = true;
    fadeImage.DOFade(0, 0);
    fadeImage.gameObject.SetActive(true);
    fadeImage.DOFade(1.0f, duration).OnComplete(()=>isTweening = false);

    while(isTweening)
    {
      yield return null;
    }

  }

  public IEnumerator StartOutAnimation()
  {
    bool isTweening = true;
    fadeImage.DOFade(1, 0);
    fadeImage.gameObject.SetActive(true);
    fadeImage.DOFade(0.0f, duration).OnComplete(() => isTweening = false);

    while (isTweening)
    {
      yield return null;
    }

    fadeImage.gameObject.SetActive(false);
  }
}
