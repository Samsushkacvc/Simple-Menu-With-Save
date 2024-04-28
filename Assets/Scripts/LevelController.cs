using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public void LoadNextLEvel()
    {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        var newSceneIndex = currentSceneIndex + 1;
        PlayerPrefs.SetInt("currentLevel", newSceneIndex);
        SceneManager.LoadScene(newSceneIndex);
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("currentLevel", 3);
        SceneManager.LoadScene(3);
    }
    public void LoadCurrentLevel()
    {
        var currentLevel = PlayerPrefs.GetInt("currentLevel");
        SceneManager.LoadScene(currentLevel);
    }
    public void Settings()
    {
        SceneManager.LoadScene(2);
    }
}
