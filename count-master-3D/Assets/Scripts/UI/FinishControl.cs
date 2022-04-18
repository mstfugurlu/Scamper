using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishControl : MonoBehaviour
{
    public GameObject SuccessCanvas;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "PlayerParent")
        {
            SuccessCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
