using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrastarText: MonoBehaviour
{

 private Vector3 diferencaMouse;
// Diferença entre o ponto clicado e o centro do objeto

private bool arrastando = false;
// Controla se o objeto está sendo arrastado

private Vector3 posicaoInicial;
// Guarda a posição inicial para poder voltar depois

void Start()
{
// Guarda a posição inicial do objeto quando o jogo começa
posicaoInicial = transform.position;
}

void OnMouseDown()
    {
        
        arrastando = true;
// Pega a posição do mouse na tela e converte a posição para 2D

    Vector3 posMouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
// Calcula a diferença entre o ponto do clique e a posição do objeto

    diferencaMouse = transform.position - new Vector3(posMouse.x, posMouse.y, transform.position.z);

    }

void OnMouseDrag()
    {
        if (!arrastando)
        {
            return;
        }
    // Atualiza a posição do mouse
Vector3 posMouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
    
    // Move o objeto com o mouse
transform.position = new Vector3 (posMouse.x, posMouse.y, transform.position.z) + diferencaMouse;
    }

    void OnMouseUp()
    {
        arrastando = false;
    }

void OnMouseUp()
    {
        
    }


} 