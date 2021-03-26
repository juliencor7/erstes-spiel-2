using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsOnClick : MonoBehaviour
{
    



    public string sceneName;

    public void CreditsSehen()
    {
    SceneManager.LoadScene(sceneName);
    }
}
