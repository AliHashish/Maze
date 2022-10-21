using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;          // added to control scene management
public class MainMenu : MonoBehaviour
{
    
    public void NextLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);       // gets the next level
    }

    public void QuitGame()
    {
        // Debug.Log("Quitting Game! Bueno Adios");
        Application.Quit();     // dh msh byezhar fl unity editor, fa zwd debug lyk
                                // hysht8l lama t3ml build lel game tho
    }
}
