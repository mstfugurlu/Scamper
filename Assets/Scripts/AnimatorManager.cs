using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
   [SerializeField] private Animator anim;

   [SerializeField] private string runAnim;

   public void RunAnimStart()
   {
      
      anim.SetBool(runAnim,true);
      
   }





}
