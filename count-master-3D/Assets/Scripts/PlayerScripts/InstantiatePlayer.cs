using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class InstantiatePlayer : MonoBehaviour
{
 
    public GameObject playerParent;
    public GameObject targetPos;
    ObjectPooler objectPooler;
    public SpawnerState currentMathState;
    public int size;

    private TMP_Text sizeText;

    public enum SpawnerState
    {
        additive,
        multiplier
    }

    private void Awake()
    {
        sizeText = GetComponentInChildren<TMP_Text>();
    }

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        switch (currentMathState)
        {
            case SpawnerState.additive:
                sizeText.text = "+" + size.ToString();
                break;
            case SpawnerState.multiplier:
                sizeText.text = "x" + size.ToString();
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "PlayerParent")
        {
            StartCoroutine(ColliderCloser(other));
            switch (currentMathState)
            {
                case SpawnerState.additive:
                    AddPlayer(size, other);
                    other.GetComponent<SizeCounter>().playerSize += size;
                    break;
                case SpawnerState.multiplier:
                    int multiplierSize = (other.GetComponent<SizeCounter>().playerSize * size) - other.GetComponent<SizeCounter>().playerSize;
                    AddPlayer(multiplierSize, other);
                    other.GetComponent<SizeCounter>().playerSize += multiplierSize;
                    break;
            }
        }
    }


    private void AddPlayer(int size, Collider collider)
    {
        for (int i = 0; i < size; i++)
        {
            objectPooler.GetComponent<ObjectPooler>().SpawnFromPool("Player", targetPos.transform.position , Quaternion.identity);
          
        }
    }

    IEnumerator ColliderCloser(Collider collider)
    {
        collider.gameObject.GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(0.3f);
        collider.gameObject.GetComponent<Collider>().enabled = true;
    }
}




 
