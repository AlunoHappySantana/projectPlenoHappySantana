using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float frituTimer = 15f; //tempo de fritura

    public bool mensag = false; // qualquer mensagem no jogo

    private bool arrastando = false; // marca se esta a arrastando o pastel
    private Vector3 deslocamento; // captura o deslocamento do mouse

    private bool naFrigideira = false; // verifica se o pastel esta na frigideira
    private Transform frigideiraPosition; // trazer a posicao da frigideira

    private bool fritando = false; // verificar se esta fritando o pastel
    private bool pronto = false; // verificar se esta pronto
    private float contTempo = 0f; // contar o tempo do pastel na frigideira

    private Rigidbody2D rb; // objeto Rigidbody
    private bool entregue = false; // verificar se foi entregue


}
