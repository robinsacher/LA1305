using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void PlayLevel1()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void PlayLevel2()
    {
        SceneManager.LoadSceneAsync(4);
    }
}

