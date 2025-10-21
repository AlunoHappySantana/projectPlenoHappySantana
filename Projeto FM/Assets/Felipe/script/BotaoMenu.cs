using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButaoMenu : MonoBehaviour
{

    public void PlayG()
    {
         SceneManager.LoadSceneAsync(1);
    }



}
