using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    int count;
    public GameObject PlayerParent;
    public GameObject failCanvas;

    void CheckPlayerCount()
    {

        int numberOfTaggedObjects = GameObject.FindGameObjectsWithTag("Player").Length;

        if (numberOfTaggedObjects == 0)
        {
            failCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void Update()
    {
        CheckPlayerCount();
    }
}
