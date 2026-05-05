using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panela : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto que encostou tem a Tag "Ingrediente"
        if (collision.CompareTag("Frigideira"))
        {
            TornarFrigideiraVisivel();

            Destroy(collision.gameObject);
        }
    }

    void TornarFrigideiraVisivel()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = true;
            Debug.Log("A frigideira apareceu!");
        }
    }

}

