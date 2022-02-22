using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Test1 : MonoBehaviour
{
    public UnityAction<string,Vector3> actionDeneme;
    

    private void OnEnable()
    {
        actionDeneme?.Invoke("mıstık",Vector3.back);
        
    }
}
