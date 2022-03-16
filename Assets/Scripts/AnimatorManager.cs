using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
   [SerializeField] private Animator anim;

   [SerializeField] private string runAnim;

   [SerializeField] private string fallAnim; 
   [SerializeField] private string danceAnim;

   public void RunAnimStart()
   {
      
      anim.SetBool(runAnim,true);
      
   }

   public void fallAnimStart()
   {
      anim.SetBool(runAnim,false);
      anim.SetBool(fallAnim,true);
      
   }

   public void DanceAnimStart()
   {
      anim.SetBool(runAnim,false);
      
      anim.SetBool(danceAnim,true);
      
      
   }
  
   

}
