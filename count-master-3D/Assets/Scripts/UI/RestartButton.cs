using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject SuccessCanvas;
    public GameObject FailCanvas;

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
        SuccessCanvas.SetActive(false);
        FailCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
