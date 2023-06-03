using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    public PlayerController playerController;
  
    // Update is called once per frame
    void Update()
    {
        if (playerController.score == 15)
        {
            SceneManager.LoadScene("g.slider");
        }
    }
}
