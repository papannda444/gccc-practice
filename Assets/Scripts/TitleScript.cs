using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public void StartClick()
    {
        SceneManager.LoadScene("Main");
    }
    public void EndClick()
    {
        Quit();
    }

    private void Quit()
    {
        #if UNITY_EDITOR
              UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
              UnityEngine.Application.Quit();
        #endif
    }
}
