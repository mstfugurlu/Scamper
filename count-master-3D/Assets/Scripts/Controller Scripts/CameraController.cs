using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public float lerpValue;

    private void LateUpdate()
    {
       
        if(target == null)
        {
            target = FindPlayer();
            return;
        } else
        {
            Vector3 desiredPosition = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, desiredPosition, lerpValue);

        }
    }

    private Transform FindPlayer()
    {
        Transform searchResult = GameObject.FindGameObjectWithTag("Player").transform;

        if (searchResult == null)
        {
            Debug.LogWarning("Player object could not be found.");
            return null;
        }
        else
        {
            return searchResult;
        }

    }
}
