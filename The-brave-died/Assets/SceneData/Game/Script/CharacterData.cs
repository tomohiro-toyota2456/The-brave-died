//************************************************************
//CharacterData.cs
//Autor harada
//************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//************************************************************
//
//
//************************************************************
public class CharacterData : ScriptableObject
{
  [SerializeField]
  string name;
  [SerializeField]
  ulong maxAtk;
  [SerializeField]
  GrowthType growthType;
  [SerializeField]
  int id;

  public enum GrowthType
  {
    Fast,
    Normal,
    Slow
  }

  public string CharaName { get { return name; }set { name = value; } }
  public ulong MaxAtk { get { return maxAtk; } set { maxAtk = value; } }
  public GrowthType Type { get { return growthType; } set { growthType = value; } }
  public int Id { get { return id; } set { id = value; } }

}
