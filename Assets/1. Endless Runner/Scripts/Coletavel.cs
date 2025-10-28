using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public float velocidade = 3f;
    private Transform player;
    private GameManager gameManager;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (player != null)
        {
            // Faz o item se mover em direção ao jogador
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                velocidade * Time.deltaTime
            );
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Adiciona pontos
            gameManager.AdicionarPontos(20);

        }
    }
}
