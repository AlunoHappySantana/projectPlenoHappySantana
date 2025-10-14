using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preparo : MonoBehaviour
{
  public float frituTimer = 15f; //tempo de fritura

  public bool  mensag = false; // qualquer mensagem no jogo

  private bool arrastando = false; // marca se está arrastando o pastel
  private Vector3 deslocamento; // captura o deslocamento do mouse

  private bool naFrigideira = false; // verifica se pastel está na frigideira
  private Transform frigideiraPosition; // trazer a posição da frigideira

  private bool fritando = false; // verificar se está fritando o pastel
  private bool pronto = false;// verificar se está pronto
  private float contTempo = 0f; // contar o tempo do pastel na frigideira

  private Rigidbody2D rb; // obj Rigidbody
  private bool entregue = false; // verificar se foi entregue
 











}
