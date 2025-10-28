using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textoPontuacao;
    private int pontuacao = 0;

    public void AdicionarPontos(int pontos)
    {
        pontuacao += pontos;
        textoPontuacao.text = "PONTOS: " + pontuacao;
    }
    public void PerderPontos(int pontos)
    {
        pontuacao -= pontos;
        textoPontuacao.text = "PONTOS: " + pontuacao;
    }
}
 