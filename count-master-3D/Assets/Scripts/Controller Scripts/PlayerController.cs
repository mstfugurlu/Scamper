using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;

    Vector3 firstTouchPosition = Vector3.zero;
    Vector3 deltaTouchPosition = Vector3.zero;
    Vector3 direction = Vector3.zero;

    Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();

    }

    private void Update()
    {
       transform.position =  new Vector3(Mathf.Clamp(transform.position.x, -10f, 9f), transform.position.y, transform.position.z);
    }

    private void FixedUpdate()
    {
        Vector3 forwardMovement = transform.forward * speed * Time.fixedDeltaTime * 2f;
        body.MovePosition(body.position + forwardMovement);

        if (Input.GetMouseButtonDown(0))
        {
            firstTouchPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            deltaTouchPosition = Input.mousePosition - firstTouchPosition;
            direction = new Vector3(deltaTouchPosition.x * speed, 0f, 0f);

            body.velocity = direction.normalized * 10f;
        }
        else
        {
            body.velocity = Vector3.zero;
        }
    }
}
