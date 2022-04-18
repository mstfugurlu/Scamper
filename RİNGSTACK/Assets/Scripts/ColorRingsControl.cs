using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRingsControl : MonoBehaviour
{
    public GameObject HighestColorRing = null;
    private void Update()
    {
        GameObject[] ColorRings = GameObject.FindGameObjectsWithTag("ColorRings");
        float HighestColorRingPos = -1f;
        for (int i = 0; i < ColorRings.Length; i++)
        {
            float thisY = ColorRings[i].transform.position.y;
            if (thisY>HighestColorRingPos)
            {
                HighestColorRingPos = thisY;
                HighestColorRing = ColorRings[i];
                Debug.Log(HighestColorRing);
            }
        }
    }
}
