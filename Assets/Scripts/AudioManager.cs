using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
   public static AudioClip WalkSound, CrashSound;
   private static AudioSource audioSrc;


   private void Start()
   {
      WalkSound = Resources.Load<AudioClip>("Walk");
      CrashSound = Resources.Load<AudioClip>("Crash");

      audioSrc = GetComponent<AudioSource>();
   }

   
      
   

}
