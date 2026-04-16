using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class criente_vino : MonoBehaviour {

    public int pastel = 0;
    public float tempo = 3f; 
    public GameObject criente;

    public TextMeshProUGUI textoPastel; // referência ao texto na UI

    void Start () {
        if (pastel == 0) {
            criente.SetActive(false);
            Invoke("Aparecer", tempo);

            pastel = Random.Range(1, 3);

            AtualizarTexto(); // atualiza o texto na tela
        }
    }

    void Aparecer () {
        criente.SetActive(true);
    }

    void AtualizarTexto() {
        textoPastel.text = "Pastel: " + pastel.ToString();
    }
}