using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour
{
    public void quit()
    {
        Debug.Log("Button geklickt - Spiel beenden");

#if UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying = false;

#else
Application.Quit();

#endif



    }
}
