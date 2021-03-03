using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwitchScenes : MonoBehaviour
{
    public Text TextField;
    public void LoadGame()
    {
        
        if (File.Exists(Application.persistentDataPath
                        + "/CharacterData.json"))
        {
            SceneManager.LoadScene("PlayGame");
        }
        else
        {
            TextField.text = "There is no character saved." +
                             "\nGenerate a character to play the game.";
        }
        
    }
    public void NextScene()
    {
        SceneManager.LoadScene("MainPage");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
