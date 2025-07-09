using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;
    //[SerializeField] private Button optionsButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject scoreText;
    [SerializeField] private GameObject livesText;
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private GameObject playerMovement;
    [SerializeField] private GameManager gameManager;

    public void Play()
    {
        mainMenu.SetActive(false);
        gameOverMenu.SetActive(false);
        livesText.SetActive(true);
        scoreText.SetActive(true);
        
    }
    public void TryAgainExit()
    {
        mainMenu.SetActive(true);
        gameOverMenu.SetActive(false);
        livesText.SetActive(false);
        scoreText.SetActive(false);       
    }

    public void Quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
