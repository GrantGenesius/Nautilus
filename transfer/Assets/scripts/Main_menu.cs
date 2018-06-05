using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour {

    public void gobackTomainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void play_game() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void gotolevel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
    public void gotolevel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }
    public void gotolevel3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(4);
    }
    public void gotowinscreen()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(5);
    }
    public void gotolosescreen()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(6);
    }
    public void howtogameplay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(7);
    }
    public void howtocontrol()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(8);
    }
    public void credits()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(9);
    }


    public void quit_game() {
        Debug.Log("bye-bye!");
        Application.Quit();
    }

    public void Retry_stage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }

    public void Next_stage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void Back_toMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Retry_Failed_stage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }

    public void Back_Failed_toMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

}
