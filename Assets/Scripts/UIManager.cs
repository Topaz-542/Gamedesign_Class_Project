using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameObject resumeButton;
    [SerializeField]
    GameObject startButton;
    [SerializeField]
    GameObject menuLayout;
    [SerializeField]
    GameObject bup;

    public static bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel") || Input.GetKeyDown(KeyCode.P))
        {
            if (!isPaused)
                Pause();
            else
                Unpause();
        }
    }

    public void Pause()
    {
        menuLayout.SetActive(true);
        resumeButton.SetActive(true);
        isPaused = true;
        Time.timeScale = .0f;
    }

    public void Unpause()
    {
        menuLayout.SetActive(false);
        resumeButton.SetActive(false);
        isPaused = false;
        Time.timeScale = 1.0f;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Minigame");
        menuLayout.SetActive(false);
        startButton.SetActive(false);
        bup.SetActive(false);
        
    }

    public void Quit()
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
