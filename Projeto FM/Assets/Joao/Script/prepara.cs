using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prepara : MonoBehaviour
{


    public float friTime = 15.0f; //tempo de fritrura

    public bool mensag = false; //qualquer mensagem no jogo

    private bool arrastando = false; //marca se esta arrastando o pastel 

    private Vector3D deslocamento; //capitura o deslocamento do mouse

    private bool nafrigideira = false; //verifica se o pastel esta na frigideira

    private Transform frigideiraposition; //trazer a posicao da frigideira

    private bool fritando = false; //verificar se esta fritando o pastel

    private bool pronto = false; //verificar se esta pronto

    private float contTempo = 0f; //contar o tempo do pastel na frigideira 

    private Rigidibody2D rb; //obj Rigidbody

    private bool entregue = false; //vereificar se foi entregue




}
