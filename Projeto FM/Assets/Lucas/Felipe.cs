using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Felipe : MonoBehaviour
{
   public void Gustavo()
    {
        SceneManager.LoadSceneAsyncc(0);
    }
    void Start()
    {
        Invoke("Gustavo");
    }
}
