using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
   

   public class BodyStickControl : MonoBehaviour
   {
      [SerializeField] private List<GameObject> colorfullRing; 
      public GameObject HighestColorRing = null; 
      private List<GameObject> colorfulRing;

   private void Start()
   {
      foreach (Transform child in transform)
      {
         colorfullRing.Add(child.gameObject);
      }

   }
   private void Update()
   {


      var nearest = colorfulRing;

      float HighestColorRingPos = -1f;
      for (int i = 0; i < colorfullRing.Count; i++)
      {
         float thisY = colorfullRing[i].transform.position.y;
         if (thisY>HighestColorRingPos)
         {
            HighestColorRingPos = thisY;
            HighestColorRing = colorfullRing[i];
            
         }
      }
      
   }





   }
   
   

