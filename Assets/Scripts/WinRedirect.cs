using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinRedirect : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WinScene());
    }

    IEnumerator WinScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(4);
    }
}
