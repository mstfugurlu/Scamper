using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCounter : MonoBehaviour
{
    
    public Text playerCount;
    private int currentPlayerCount = 1;
    private int maxPlayerCount;

    private void Start()
    {
       

        currentPlayerCount = maxPlayerCount;
        playerCount.text = maxPlayerCount.ToString();

    }

    void Update()
    {
       
        CountPlayers();
    }

    

    void CountPlayers()
    {
        maxPlayerCount = GameObject.FindGameObjectsWithTag("Player").Length;
        playerCount.text = maxPlayerCount.ToString();
    }
}
