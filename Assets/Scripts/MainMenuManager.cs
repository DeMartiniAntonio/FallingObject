using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button playButton;
    //[SerializeField] private Button optionsButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject instructionsPanel;


    public void Instructions()
    {
        instructionsPanel.SetActive(true);
    }

    public void Play()
    {
        instructionsPanel.SetActive(false);
        mainMenu.SetActive(false);
        SceneManager.LoadScene(1); 

    }
    public void TryAgainExit()
    {
        mainMenu.SetActive(true);
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
