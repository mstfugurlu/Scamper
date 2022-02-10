using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class PlayerMove : MonoBehaviour
{
   public PathCreator pathCreator;
   public EndOfPathInstruction endOfPathInstruction;
   public float speed = 5f;
   private float distanceTravelled;


   private void Start()
   {
      if (pathCreator!=null)
      {
         pathCreator.pathUpdated += OnPathChanged;
      }
   }


   private void Update()
   {
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
