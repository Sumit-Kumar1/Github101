using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] movement _mntScript;
    public void Resume()
    {
        _mntScript.flag = true;
        _mntScript._pauseUI.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
