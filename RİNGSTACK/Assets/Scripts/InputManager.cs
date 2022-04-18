using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Transform selectedTransform;
    [SerializeField] private Vector2 firstTouch, lastTouch, result;
    [SerializeField] private float sensivity;
    [SerializeField] private LayerMask layermask;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out RaycastHit hit))
            {
                selectedTransform = hit.transform;
                firstTouch = Input.mousePosition;
            }
        }

        if (Input.GetMouseButton(0) && selectedTransform!=null)
        {
            lastTouch = Input.mousePosition;
            result = lastTouch - firstTouch;
            result *= sensivity;
            firstTouch = lastTouch;

            MoveTransform(selectedTransform, result);

        }

        if (Input.GetMouseButtonUp(0))
        {
            result = lastTouch = firstTouch = Vector3.zero;
            selectedTransform = null;
        }
    }

    private void MoveTransform(Transform tr, Vector3 res)
    {
     tr.position=Vector3.Lerp(tr.position,tr.position+new Vector3(res.x,res.y,res.z),Time.deltaTime*10f);
    }
}

  