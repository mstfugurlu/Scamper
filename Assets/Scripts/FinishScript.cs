using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    [SerializeField] private PlayerMove MovePlayer;
    public GameObject CmCamera;
    public GameObject nextLevelCanvas;
    public GameObject Particle1, Particle2;
    public AudioSource Sound1, Sound2;
    public AnimatorManager animations;
    


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            nextLevelCanvas.SetActive(true);
            Particle1.SetActive(true);
            Particle2.SetActive(true);
            animations.DanceAnimStart();
            Sound1.enabled = true;
            Sound2.enabled = false;
            MovePlayer.canControl = false;
            //MovePlayer.LevelFailCanvas.SetActive(true);
            MovePlayer.speed = 0f;
            MovePlayer.animations.enabled = true;
            //MovePlayer.enabled = false;
            MovePlayer._audioSource.enabled = false;
            CmCamera.SetActive(false);

        }
    }
}