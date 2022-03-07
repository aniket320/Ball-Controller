using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour
{
    public static pause instance { private get; set; }
    public GameObject PausePsnel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pausemenu()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Selectlevel()
    {
        int CurrentLevel = SceneManager.GetActiveScene().buildIndex;
        if (CurrentLevel >= PlayerPrefs.GetInt("Unlocked"))
        {
            PlayerPrefs.SetInt("Unlocked", CurrentLevel + 1);

        }

        //SceneManager.LoadScene(CurrentLevel + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
