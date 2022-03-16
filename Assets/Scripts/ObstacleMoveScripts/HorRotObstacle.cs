using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
public class HorRotObstacle : MonoBehaviour
{
    public Slide SlideRotation;
    public float RotationSensitivity = 5f;
    [SerializeField] private PlayerMove MovePlayer;
    public GameObject CmCamera;
    public AudioSource AudioSource;
   


    private void Awake()
    {
        SlideRotation.RotateObstacle += ObstacleRotation;
        AudioSource = gameObject.GetComponent<AudioSource>();
    }

    private void ObstacleRotation(float sd)
    {


        if (gameObject.tag == "HorRotObs")
        {
            transform.Rotate(0, sd / RotationSensitivity,0 );
        }

    }


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
            MovePlayer.GetComponent<BoxCollider>().enabled = false;
            CmCamera.SetActive(false);
            MovePlayer._audioSource.enabled = false;
            foreach (GameObject rb in MovePlayer.PlayerBody)
            {
                rb.GetComponent<Rigidbody>().isKinematic = false;
            }

            Vector3 direction = transform.position - MovePlayer.transform.position;
         
            direction.y = -5f;
            MovePlayer.PlayerBody[10].GetComponent<Rigidbody>().AddForce(direction.normalized*30,ForceMode.VelocityChange);
            MovePlayer.PlayerBody[0].GetComponent<Rigidbody>().AddForce(direction.normalized*30,ForceMode.VelocityChange);
         
         
        }
    }
}
