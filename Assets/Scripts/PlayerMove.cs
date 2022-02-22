using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
   public PathCreator pathCreator;
   public EndOfPathInstruction endOfPathInstruction;
   public static float speed = 5f;
   private float distanceTravelled;
   public AnimatorManager animatorManager;
   public GameObject speeds;

   private void Start()
   {
      speed = 0;
      if (pathCreator!=null)
      {
         pathCreator.pathUpdated += OnPathChanged;
      }
   }


   private void Update()
   {
      if (Input.GetMouseButton(0))
      {
         animatorManager.RunAnimStart();
         
         speed = 13f;
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
