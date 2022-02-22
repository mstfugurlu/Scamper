using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
   
   public AnimatorManager animatorManager;
   //public PlayerMove playerMove;
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         Debug.Log("temas");
         animatorManager.fallAnimStart();
         PlayerMove.speed = 0f;
      }
   }
}
