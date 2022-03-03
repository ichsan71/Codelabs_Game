using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
 
   public void BtnPlay_OnClick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void BtnExit_OnClick()
    {
        Application.Quit();
    }
}
