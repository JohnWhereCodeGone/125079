using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Pause : MonoBehaviour
{
    private bool isPaused = false;


    private GameObject pauseScreen;

    private void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) // I genuinely despise the new input system right now.
        {
            isPaused = !isPaused;
            pauseScreen.SetActive(isPaused);
            
            

        }
        if (isPaused == true)
        {
            Time.timeScale = 0f;
        }
        else Time.timeScale = 1f;
        //Possible simplification to look into. Time.timescale = 1f * isPaused
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }

    private void Start()
    {
        pauseScreen = gameObject.transform.GetChild(0).gameObject;
        
    }
}
