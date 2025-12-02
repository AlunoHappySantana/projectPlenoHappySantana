using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MouseArrasta : MonoBehaviour
{ // === Configurações visíveis no Inspector ===
    [Header("Tempo de fritura (segundos)")]
    public float tempo_cozimento = 120f; // 120 segundos = 2 minutos (mude para testar)


    [Header("Debug")]
    public bool Mensagem = true; // se true, o script escreve mensagens no Console


    // === Estado interno do objeto ===
    private bool arrastando = false;   // true enquanto o jogador está arrastando
    private Vector3 deslocamento;   // diferença entre mouse e posição do objeto
    private bool EstaNaPanela = false;      // true se estiver dentro do trigger da frigideira
    private Transform FrigideiraTransform;    // referência para a frigideira (posição de encaixe)


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


        // Se não tiver Rigidbody2D, avisamos no Console — isso evita erros mais adiante
        if (rb == null && Mensagem)
        {
            Debug.LogWarning("Nenhum Rigidbody2D encontrado no pastel.");
        }
    }


    // OnMouseDown é chamado quando o jogador pressiona o botão do mouse sobre o Collider do objeto
    void OnMouseDown()
    {
        // Se já estiver fritando, não deixamos pegar o pastel (regra do jogo)
        if (fritando)
        {
            if (Mensagem) Debug.Log("Não pode pegar: pastel está fritando.");
            return; // sai sem ativar arraste
        }


        // Convertendo a posição do mouse (tela) para mundo (onde os objetos estão)
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        // Calculamos o offset para que o objeto não "salte" ao começar a arrastar
        deslocamento = transform.position - new Vector3(mousePosition.x, mousePosition.y, transform.position.z);


        // Marcamos que estamos arrastando
        arrastando = true;


        if (Mensagem)
        {
            Debug.Log("Começou a arrastar o pastel.");
        }
    }


    // OnMouseUp é chamado quando o jogador solta o botão do mouse
    void OnMouseUp()
    {
        // Paramos de arrastar
        arrastando = false;


        // Se estivermos sobre a frigideira e não estivermos fritando nem prontos,
        // iniciamos a fritura (snap + travar)
        if (EstaNaPanela && !fritando && !retirar)
        {
            StartCooking();
        }
        // Se o pastel já estiver pronto e o jogador soltar, entendemos que ele retirou o pastel
        else if (retirar)
        {
            // Resetamos o estado para permitir reutilizar o objeto
            fritando = false;


            if (Mensagem) Debug.Log("Você retirou o pastel pronto da frigideira.");
        }
        else
        {
            // Caso normal de soltar em outro lugar
            if (Mensagem) Debug.Log("Soltou o pastel.");
        }
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


        // Se estiver fritando, somamos o tempo e verificamos se já acabou
        if (fritando)
        {
            tempoFritura += Time.deltaTime; // Time.deltaTime = tempo em segundos desde o último frame


            // Quando o tempo acumulado alcança o tempo de fritura configurado:
            if (tempoFritura >= tempo_cozimento)
            {
                FinishCooking();
            }
        }
    }


    // OnTriggerEnter2D é chamado quando um Collider2D marcado como Trigger é tocado
    void OnTriggerEnter2D(Collider2D other)
    {
        // Verificamos se o objeto que entrou na trigger tem a tag "Frigideira"
        if (other.CompareTag("Frigideira"))
        {
            fritando = true;               // estamos sobre a frigideira
            FrigideiraTransform = other.transform; // guardamos referência para posição/centro da frigideira


            if (Mensagem) Debug.Log("Pastel entrou na área da frigideira.");
        }


        // --- ENTREGA ---
        if (other.CompareTag("Entrega") && pronto && !entregue)
        {
            EntregarPastel();
        }


    }


    // OnTriggerExit2D é chamado quando saímos da área do trigger
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Frigideira"))
        {
            fritando = false;      // não estamos mais sobre a frigideira
            FrigideiraTransform = null;  // limpamos a referência


            if (Mensagem) Debug.Log("Pastel saiu da área da frigideira.");
        }
    }


    // Começa o processo de fritura: encaixa, trava física e zera o timer
    void StartCooking()
    {
        fritando = true; // marcamos que está cozinhando
        tempoFritura = 0f;       // zeramos o contador


        // Se temos referência da frigideira, colocamos o pastel exatamente no centro dela
        if (FrigideiraTransform != null)
        {
            transform.position = FrigideiraTransform.position;
        }


        // Para que o pastel não seja movido por física nem por arrasto, colocamos o Rigidbody em Static.
        // Static = não é afetado pela física e não se move até mudarmos o tipo de corpo.
        // Observação: usar Static facilita travar o objeto enquanto frita.
        if (rb != null)
        {
            rb.bodyType = RigidbodyType2D.Static;
        }


        if (Mensagem) Debug.Log("Fritando pastel... (tempo iniciado)");
    }


    // Finaliza a fritura: indica que está pronto e permite retirar o pastel
    void FinishCooking()
    {
        fritando = false; // não está mais cozinhando
        retirar = true;    // pronto para ser retirado


        // Volta o Rigidbody para Kinematic para permitir ser movido por script/arrasto novamente.
        // Kinematic: não é afetado por forças, mas podemos ajustar a posição via transform ou arrastar.
        if (rb != null)
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
        }


        if (Mensagem) Debug.Log(" Pastel pronto! Retire agora!");
    }
     // === NOVO: Entregar pastel ===
    void EntregarPastel()
    {
        entregue = true; // Marca como entregue
        pronto = false;  // Já não está mais disponível para fritar ou pegar


        // Opcional: pode desativar o pastel, destruir ou mover para um ponto de descarte
        if (Mensagem) Debug.Log(" Pastel entregue com sucesso! Cliente satisfeito! ");


        // Exemplo opcional: destruir o pastel depois de um tempo
        // Destroy(gameObject, 1f);
    }
}

