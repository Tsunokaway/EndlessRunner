using UnityEngine;

public class Item : MonoBehaviour
{
    public float velocidade = 0.6f;
    private GameManager gameManager;
    public float variacaoY;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Item ativo");
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            // Adiciona pontos
            gameManager.AdicionarPontos(20);

        }
    }
}