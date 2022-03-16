using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using PathCreation;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
   public Animator animations;
   public PathCreator pathCreator;
   public EndOfPathInstruction endOfPathInstruction;
   public float speed = 5f;
   private float distanceTravelled;
   [SerializeField] private AnimatorManager animatorManager;
   public bool canControl;
   public GameObject LevelFailCanvas;
   public AudioSource _audioSource;
   public List<GameObject> PlayerBody = new List<GameObject>();
   public PathCreator pathCreator2;



   private void Awake()
   {
      pathCreator.path.EndofTheRoad += endofroad;
      _audioSource = gameObject.GetComponent<AudioSource>();
      animations = gameObject.GetComponent<Animator>();
      
   }

   private void endofroad()
   {
      distanceTravelled = 0;
      pathCreator = pathCreator2;
      
     
   }

   private void Start()
   {
      
      canControl = true;
      speed = 0;
      if (pathCreator!=null)
      {
         pathCreator.pathUpdated += OnPathChanged;
      }
   }




   private void Update()
   {
     
     
      if (canControl==true)
      {
         if (Input.GetMouseButton(0))
         {
            animatorManager.RunAnimStart();
            _audioSource.enabled = true;
            
         
            speed = 10f;
            
            
         }
         

      }
      else
      {
         speed = 0f;
      }
      if (pathCreator!=null)
      {
         distanceTravelled += speed * Time.deltaTime;
         transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
         transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
         pathCreator.path.localPoints.ToList();
         
      }
      
   }

   


   void OnPathChanged()
   {

      distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
   }

   

   
}
