using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VoltarMenu : MonoBehaviour
{
   public void Voltar()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
