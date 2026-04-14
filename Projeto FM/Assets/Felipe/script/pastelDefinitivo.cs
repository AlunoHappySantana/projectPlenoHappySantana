using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //troca de Scene


public class TrocaSprite : MonoBehaviour
{
    // Referência para o Sprite da massa fechada
    public Sprite massaFechadaSprite;
    /* para receber as massas
    public Sprite massaQueijoSprite;
    public Sprite massaCarneSprite;
    */
   
    private SpriteRenderer spriteRenderer;




    void Start()
    {
        //Permite que o objeto não seja destruido ao trocar de cena
        DontDestroyOnLoad(this.gameObject);
        // Pega o componente SpriteRenderer do próprio objeto
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    // Função que será chamada quando o ingrediente encostar na massa
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto que colidiu tem a Tag "Ingrediente"
        if (collision.CompareTag("Ingrediente"))
        {
            TrocarImagem();
            // Opcional: Destrói o ingrediente após ele "entrar" na massa
            Destroy(collision.gameObject);
        }
        /* Mais identificando ingredientes
        if (collision.CompareTag("Queijo"))
        {
            FecharMassa(massaQueijoSprite);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Carne"))
        {
            FecharMassa(massaCarneSprite);
            Destroy(collision.gameObject);
        }
    }*/


        if (collision.CompareTag("pontoFritar"))
        {
            SceneManager.LoadScene("sala de fritura");
        }
    }


    void TrocarImagem()
    {
        if (massaFechadaSprite != null)
        {
            spriteRenderer.sprite = massaFechadaSprite;
        }
    }
}



