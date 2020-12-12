using UnityEngine;
using UnityEngine.SceneManagement;

public class menuIntract : MonoBehaviour
{
    public AudioSource source;
    public void StartGame()
    {
        source.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
