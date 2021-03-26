using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryOnClick : MonoBehaviour
{
    public string sceneName;

    public void StorySehen()
    {
        SceneManager.LoadScene(sceneName);
    }
}
