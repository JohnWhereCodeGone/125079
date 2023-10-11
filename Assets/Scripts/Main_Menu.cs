using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    public void StartGame() // Publicity modifier for buttons should be public.
    {
        SceneManager.LoadScene(1);
    }
}
