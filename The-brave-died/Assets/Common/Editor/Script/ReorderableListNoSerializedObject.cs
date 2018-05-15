//****************************************************
//ReorderableListNoSerializedObject.cs
//Author harada
//****************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

//****************************************************
//EditorWindowでReorderableListを表示する基底クラス
//
//****************************************************
public class ReorderableListNoSerializedObject<T>
{
  ReorderableList reorderableList;
  Vector2 scrollPos;

  public void Init(List<T> dataList,ReorderableList.ElementCallbackDelegate callback)
  {
    if (reorderableList != null)
      return;

    reorderableList = new ReorderableList(dataList, typeof(T));
    reorderableList.drawElementCallback = callback;
  }

  public void DrawList()
  {
    if (reorderableList == null)
      return;

    using (var scroll = new EditorGUILayout.ScrollViewScope(scrollPos))
    {
      reorderableList.DoLayoutList();
      scrollPos = scroll.scrollPosition;
    }
  }

}
