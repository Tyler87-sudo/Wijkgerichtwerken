using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // ASSIGN DE FUCKING SCENE !!!
        SceneManager.LoadScene("Scenes/Scene1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
