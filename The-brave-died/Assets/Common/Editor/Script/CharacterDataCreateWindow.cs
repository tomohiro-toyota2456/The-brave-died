using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CharacterDataCreateWindow : EditorWindow
{
  static ReorderableListNoSerializedObject<CharacterData> reorderableListNoSerializedObject = new ReorderableListNoSerializedObject<CharacterData>();
  static List<CharacterData> dataList = new List<CharacterData>();


  [MenuItem("CreateWindow/OpenCharacterDataWindow")]
  public static void Open()
  {
    GetWindow<CharacterDataCreateWindow>();
    reorderableListNoSerializedObject.Init(dataList,(rect, index, active, focused) =>
    {
      Rect r = new Rect();
      r.position = rect.position;
      r.width = 40;
      r.height = rect.height;

      EditorGUI.LabelField(r, "ID:"+index.ToString());

      r.x += r.width;
      r.width = 40;
      EditorGUI.LabelField(r,"Name");
      r.x += r.width;
      r.width = 200;
      dataList[index].CharaName = EditorGUI.TextField(r,dataList[index].CharaName);
    });
  }

  private void OnGUI()
  {
    reorderableListNoSerializedObject.DrawList();

    if(GUILayout.Button("CreateCharaData"))
    {

    }
  }
}
