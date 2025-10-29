using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Pontuação")]
    public TextMeshProUGUI textoPontuacao;
    private int pontuacao = 0;

    [Header("Vidas")]
    public Image[] coracoes;  // Arraste as 5 imagens aqui no Inspector
    private int vidas = 5;

    public void AdicionarPontos(int pontos)
    {
        pontuacao += pontos;
        textoPontuacao.text = "PONTOS: " + pontuacao;
    }

    public void PerderVida()
    {
        if (vidas > 0)
        {
            vidas--;

            // Esconde o coração correspondente
            coracoes[vidas].enabled = false;

            if (vidas <= 0)
            {
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        Debug.Log("GAME OVER!");
        // Aqui você pode:
        // - Mostrar um painel de Game Over
        // - Reiniciar a cena:
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
