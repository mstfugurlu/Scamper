using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
  public Test1 TestScript;


  private void Awake()
  {
      TestScript.actionDeneme += test2Function;
  }

  void test2Function(string s,Vector3 v)
  {
      
      
      
      Debug.Log("okey");
      
      Debug.Log(s);
      Debug.Log(v);
      
      
  }
  
  
  
}
