using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    private bool isPause = false;
    public GameObject pauseBtn;
    public GameObject pausePanel;
    public GameObject GameOverPanel;
    public GameObject JarPanelTxt;
    public GameObject GameOverJarText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            GameOverJarText.GetComponent<Text>().text = PlayerPrefs.GetInt("JarAmount") + "";
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("2D_runner_pixel_art");
    }
    
    public void GameOver()
    {
        JarPanelTxt.GetComponent<JarAmount>().SaveJar();
        GameOverPanel.SetActive(true);
        pausePanel.SetActive(false);
		pauseBtn.SetActive(false);
        Time.timeScale = 0;
        GameOverJarText.GetComponent<Text>().text = PlayerPrefs.GetInt("JarAmount") + "";
    }

    public void PausePlay()
    {
        if (isPause)
        {
            isPause = false;
            Time.timeScale = 1;
            pauseBtn.SetActive(true);
            pausePanel.SetActive(false);
        }
        else
        {
            isPause = true;
            Time.timeScale = 0;
            pauseBtn.SetActive(false);
            pausePanel.SetActive(true);
        }
    }
}
