using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseArrasta : MonoBehaviour
{

 // === Estado interno do objeto ===
    private bool arrastando = false;   // true enquanto o jogador está arrastando
    private Vector3 deslocamento;   // diferença entre mouse e posição do objeto
   


    private bool fritando = false;    // true enquanto está fritando
    private bool retirar = false;      // true quando a fritura terminou (pronto para retirar)
    private float tempoFritura = 0f;          // contador de tempo enquanto frita


    private Rigidbody2D rb;            // referência ao Rigidbody2D do pastel
    private bool pronto;
    private bool entregue;






    // Awake é chamado quando o objeto é instanciado
    void Awake()
    {
        // Pegamos o Rigidbody2D anexado a este GameObject (se existir)
        rb = GetComponent<Rigidbody2D>();


     
    }


    // OnMouseDown é chamado quando o jogador pressiona o botão do mouse sobre o Collider do objeto
    void OnMouseDown()
    {

        // Convertendo a posição do mouse (tela) para mundo (onde os objetos estão)
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculamos o offset para que o objeto não "salte" ao começar a arrastar
        deslocamento = transform.position - new Vector3(mousePosition.x, mousePosition.y, transform.position.z);

        // Marcamos que estamos arrastando
        arrastando = true;

      
    }


    // OnMouseUp é chamado quando o jogador solta o botão do mouse
    void OnMouseUp()
    {
        // Paramos de arrastar
        arrastando = false;


     
    }


    // Update roda a cada frame — aqui movemos o objeto quando arrastado e contamos o tempo
    void Update()
    {
        // Se estamos arrastando, atualizamos a posição do pastel para acompanhar o mouse
        if (arrastando)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Aplicamos o offset para manter a posição relativa original ao clicar
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z) + deslocamento;
        }



}

   
}