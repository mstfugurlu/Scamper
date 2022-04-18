using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    bool once;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!once)
            {
                gameObject.SetActive(false);
                collision.gameObject.SetActive(false);
                once = true;
            }
        }
    }
}
