using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseHandler : MonoBehaviour
{
    
    public GameObject pauseMenu;
    public GameObject endMenu;
    

    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        endMenu.SetActive(false);
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if player presses escape, pause the game
        if (Input.GetKeyDown(KeyCode.Escape) && !endMenu.activeSelf)
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    
    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        pauseMenu.SetActive(true);
    }
    
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseMenu.SetActive(false);
    }
    
    public void RestartGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(1);
    }
    
    public void MainMenu()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(0);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
