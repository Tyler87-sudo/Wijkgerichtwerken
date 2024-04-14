using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // ASSIGN DE FUCKING SCENE !!!
        SceneManager.LoadScene("");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
