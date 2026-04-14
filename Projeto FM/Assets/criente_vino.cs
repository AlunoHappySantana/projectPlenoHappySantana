using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class criente_vino : MonoBehaviour {
public float tempo = 3f; 
public GameObject criente;
void Start () {
    criente.SetActive(false);
    Invoke("Aparecer", tempo);
    }
    void Aparecer () {
        criente.SetActive(true);
    }

}