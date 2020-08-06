using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void PenguineGame()
    {
        SceneManager.LoadScene("Penguins");
    }

    public void HummingBirdGame()
    {
        SceneManager.LoadScene("FlowerIsland");
    }

    public void MatchingParenthesis()
    {
        SceneManager.LoadScene("MatchingParenthesis");
    }
    public void Palindrome()
    {
        SceneManager.LoadScene("Palindrome");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Game_Menu");
    
    }
    public void InstructorLink()
    {
        Application.OpenURL("http://www.niazilab.com/");
    }
    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
                Application.Quit();
        #elif UNITY_WEBGL
                Application.OpenURL("about:blank");
        #endif
    }
}
