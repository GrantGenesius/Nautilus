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
        SceneManager.LoadScene(5);
    }
    public void gotolosescreen()
    {
        SceneManager.LoadScene(6);
    }
    public void howtogameplay()
    {
        SceneManager.LoadScene(7);
    }
    public void howtocontrol()
    {
        SceneManager.LoadScene(8);
    }
    public void credits()
    {
        SceneManager.LoadScene(9);
    }


    public void quit_game() {
        Debug.Log("bye-bye!");
        Application.Quit();
    }

    public void Retry_stage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }

    public void Next_stage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }

    public void Back_toMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Retry_Failed_stage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }

    public void Back_Failed_toMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

}
