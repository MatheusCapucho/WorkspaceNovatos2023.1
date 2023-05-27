using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;
    public void LoadGame()
    {
        SceneManager.LoadSceneAsync("CenaTeste");
    }

    public void LoadGameByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoadGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            mainMenu.SetActive(!mainMenu.activeInHierarchy);
        }
    }

}
