using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainMenu : MonoBehaviour
{
    public static string difficulty;
    void Start()
    {   Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ReturnToMainMenu()
    {
        //Debug.Log("wadaw");
        SceneManager.LoadScene("MainMenu");
    }

    public void ChangeDifficulty()
    {
        
        difficulty = EventSystem.current.currentSelectedGameObject.name;
    }
}
