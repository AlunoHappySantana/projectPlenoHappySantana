using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preparo : MonoBehaviour
{
    public float TempoDeFritura = 15f; // tempo de fritura
    public bool mensag = false; // qualquer mensagem no jogo
    private bool arrastando = false; // marca se esta arrastando o pastel
    private Vector3 movimento; // captura o deslocamento do mouse
    private bool Frigideira = false; // verifica se pastel esta na frigideira
    private Transform FrigideiraPosition; // trazer a posicao da frigideira
    private bool fritando = false; // verificar se esta fritando o pastel
    private bool pronto = false; //verificar se esta pronto
    private float ContadorTempo = 0f; // contar o tempo do pastel na frigideira

    private Rigidbody2D rb; // obj Rigidbody
    private bool entregue = false; // verificar se foi entregue
}