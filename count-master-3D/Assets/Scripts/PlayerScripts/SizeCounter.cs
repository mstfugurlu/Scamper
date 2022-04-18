using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeCounter : MonoBehaviour
{
    public GameObject playerParent;

    [HideInInspector]
    public int playerSize;
   
    void Size()
    {
      playerSize = playerParent.transform.childCount;
    }  
}
