using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    int ToUnlocked;
    public Button[] SelecterButton;

     void Start()
    {
        ToUnlocked = PlayerPrefs.GetInt("Unlocked",1);

        for (int i = 0; i < SelecterButton.Length; i++)
        {
            SelecterButton[i].interactable = false;
        }

        for (int i = 0; i < ToUnlocked; i++)
        {
            SelecterButton[i].interactable = true;
        }
    }

   

    public void LoadLevel(int LevelIndex)
    {
        SceneManager.LoadScene(LevelIndex);

    }

    public void ResetAll()
    {
       PlayerPrefs.DeleteKey("Unlocked");
        Application.Quit();
    }
}
