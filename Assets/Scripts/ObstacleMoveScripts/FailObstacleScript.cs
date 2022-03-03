using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailObstacleScript : MonoBehaviour
{
    public GameObject Opaque;
    public GameObject Transparent;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="MakeTransparentObject")
        {
         
            Debug.Log("dokundu");
            Opaque.SetActive(false);
            Transparent.SetActive(true);
        }
    }
}
