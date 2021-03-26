using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject _pauseUI;
    bool flag=false;
    private void Start()
    {
        _pauseUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void Resume()
    {
        _pauseUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0) ;
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1) ;
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!flag)
            {
                Time.timeScale = 0;
                flag = true;
                _pauseUI.SetActive(true);
            }
            else
            {
                flag = false;
                _pauseUI.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
