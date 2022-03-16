using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTrigger : MonoBehaviour
{
    [SerializeField] private PlayerMove MovePlayer;
    public GameObject CmCamera;
    public AudioSource AudioSource;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.enabled = true;
            MovePlayer.canControl = false;
            MovePlayer.LevelFailCanvas.SetActive(true);
            MovePlayer.speed = 0f;
            MovePlayer.animations.enabled = false;
            MovePlayer.enabled = false;
            CmCamera.SetActive(false);
            MovePlayer._audioSource.enabled = false;
            foreach (GameObject rb in MovePlayer.PlayerBody)
            {
                rb.GetComponent<Rigidbody>().isKinematic = false;
            }

            
        }
    }
}
