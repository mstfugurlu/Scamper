using System;
using System.Collections;
using System.Collections.Generic;
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
   
   public List<GameObject> PlayerBody = new List<GameObject>();


   private void Awake()
   {
      animations = gameObject.GetComponent<Animator>();
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
         
            speed = 3f;
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
      }
      
   }

   


   void OnPathChanged()
   {

      distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
   }

   

   
}
