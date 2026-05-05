using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassaController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Pega o componente de imagem da massa
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Garante que a massa comece invisível
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = false;
        }
    }

    // Este método é chamado quando algo entra no Trigger da massa
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que encostou tem a Tag "Ingrediente"
        if (other.CompareTag("Ingrediente"))
        {
            TornarMassaVisivel();
        }
    }

    void TornarMassaVisivel()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = true;
            Debug.Log("A massa apareceu!");
        }
    }
}