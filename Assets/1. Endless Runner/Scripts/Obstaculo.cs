using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float velocidade = 0.6f;

    private GameManager gameManager;
    public float variacaoY;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoY,variacaoY));
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            gameManager.PerderVida();
            Destroy(gameObject); // opcional, se quiser remover o obstáculo depois da colisão
        }
    }

}