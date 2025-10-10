using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrasta : MonoBehaviour
{
    public float frituTimer = 15.0f; //tempo de fritura

    public bool mensag = false; //mensagem dentro do jogo

    private bool arrastando = false; // marca q o pastel ta sendo arrastado
    private Vector3D deslocamento; //capta q o mause esta se mexendo

    private bool naFrigideira = false;//ve se o pastel ta na frigideira
    private Transform frigideiraPosition;//pegar a posição da frigideira

    private bool fritando = false; //verificar frituramento
    private bool pronto = false;//verificar se esta bom
    private float contTempo = 0f;//contar tempo de pastel na frigideira 

    private rigidBody2D rb;//obj rigidBody
    private bool entregue = false;//verificar se foi entregue



}
