using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SteuerungOnClick : MonoBehaviour
{

    public string sceneName;

    public void SteuerungAnsehen()
    {
        SceneManager.LoadScene(sceneName);
    }
}
