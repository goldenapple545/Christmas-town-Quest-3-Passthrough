using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SantaSceneManager : MonoBehaviour
{
    public void EndScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Santa Scene", LoadSceneMode.Single);
    }
}
