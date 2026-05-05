using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pedidos : MonoBehaviour
{
    string[] pedido = { "Queijo", "Carne", "CarneQueijo", "Frango", "Pizza" };
    string pedidoAtual;

    int pedidosFeitos = 0;
    int maxPedidos = 5;

    public GameObject cliente;
    public Sprite[] spritesClientes;

    public TextMeshProUGUI texto;

    bool pedidoAtivo = false;
    bool podeEntregar = false;

    // 🥇 Cliente chega no balcão
    public void ClienteChegou()
    {
        if (pedidoAtivo) return;

        int index = Random.Range(0, pedido.Length);
        pedidoAtual = pedido[index];

        pedidoAtivo = true;
        podeEntregar = false;

        Debug.Log("Pedido gerado: " + pedidoAtual);
        string textos ="Pedido gerado: " + pedidoAtual;
        MostrarMensagem(textos);
    }

    // 🥈 Jogador clicou na cozinha (começou a preparar)
    public void IrParaCozinha()
    {
        if (!pedidoAtivo) return;
        

        Debug.Log("Preparando pedido: " + pedidoAtual);
    }

    // 🥉 Jogador terminou o pastel
    public void PedidoPronto()
    {
        if (!pedidoAtivo) return;

        podeEntregar = true;

        Debug.Log("Pedido pronto para entrega");
        MostrarMensagem("Leve o pedido ao cliente!");
    }

    // 🍳 Entrega (colisão com cliente)
    public void Entregar(string pastelMontado)
    {
        if (!podeEntregar) return;

        if (pastelMontado == pedidoAtual)
        {
            pedidosFeitos++;
            MostrarMensagem("Pedido entregue!");

            pedidoAtivo = false;
            podeEntregar = false;

            if (pedidosFeitos < maxPedidos)
            {
                Invoke(nameof(NovoCliente), 2f);
            }
            else
            {
                MostrarMensagem("Fim do jogo!");
            }
        }
        else
        {
            MostrarMensagem("Pedido errado!");
        }
    }

    // 🔄 Novo cliente
    void NovoCliente()
    {
        int index = Random.Range(0, spritesClientes.Length);
        cliente.GetComponent<SpriteRenderer>().sprite = spritesClientes[index];

        ClienteChegou();
    }

    // 💬 UI
    void MostrarMensagem(string msg)
    {
        texto.text = msg;
        texto.gameObject.SetActive(true);

        Invoke(nameof(EsconderMensagem), 2f);
    }

    void EsconderMensagem()
    {
        texto.gameObject.SetActive(false);
    }
    
public pedidos game;

private void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Balcao"))
    {
        game.ClienteChegou();
    }
}
void Awake()
{
    DontDestroyOnLoad(gameObject);
}

}
