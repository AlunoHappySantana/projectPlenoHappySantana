using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SkipTime : MonoBehaviour
{
  



    public Sprite pastelCozido; // Arraste o novo sprite aqui no Inspetor
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Pega o componente de imagem do objeto no início
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Detecta quando o pastel encosta na Panela
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto com o qual colidimos tem a Tag "Panela"
        if (collision.gameObject.CompareTag("Frigideira"))
        {
            MudarSprite();
        }
    }

    void MudarSprite()
    {
        if (pastelCozido != null)
        {
            spriteRenderer.sprite = pastelCozido;
        }
    }
}

