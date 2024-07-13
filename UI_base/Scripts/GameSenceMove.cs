using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScencesMove : MonoBehaviour
{
    public void GameScnesCtrl()
    {
        SceneManager.LoadScene("Game_start");
        // " " 안에 이동할 씬이름 입력

        Debug.Log("Game Scenes Go");
    }
    public void GameScnesCtrl_Upgrade()
    {
        SceneManager.LoadScene("Upgrade");
        // " " 안에 이동할 씬이름 입력

        Debug.Log("Upgrade Go");
    }
    public void GameScnesCtrl_corret()
    {
        SceneManager.LoadScene("corret");
        // " " 안에 이동할 씬이름 입력

        Debug.Log("corret Go");
    }
    public void GameScnesCtrl_incorret()
    {
        SceneManager.LoadScene("incorret");
        // " " 안에 이동할 씬이름 입력

        Debug.Log("incorret Go");
    }
    public void GameScnesCtrl_Upgrade2()
    {
        SceneManager.LoadScene("Upgrade2");
        // " " 두번째(다음) 퀴즈로 이동 
        Debug.Log("Upgrade2 Go");
    }
    public void GameScnesCtrl_Menu()
    {
        SceneManager.LoadScene("Game_Menu");
        // " " 메뉴로 이동 
        Debug.Log("Menu Go");
    }
}
