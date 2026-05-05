using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desistir : MonoBehaviour
{
    public GameObject button;
    public float tempoParaAparecer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
        Invoke("Desista", tempoParaAparecer);

        
    }
    void Desista()
    {
        button.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
