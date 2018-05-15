//************************************************************
//WeponData.cs
//Author harada
//************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponData : ScriptableObject
{
  [SerializeField]
  string name;
  [SerializeField]
  ulong atk;
  [SerializeField]
  int id;
  [SerializeField]
  int imageId;

  public ulong Atk { get { return atk; } set { atk = value; } }
  public string WeponName { get { return name; } set { name = value; } }
  public int Id { get { return id; } set { id = value; } }
  public int ImageId { get { return imageId; } set { imageId = value; } }
}
