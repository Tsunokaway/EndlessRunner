using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject painelPause;
    private bool jogoPausado = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (jogoPausado)
                ContinuarJogo();
            else
                PausarJogo();
        }
    }

    public void PausarJogo()
    {
        painelPause.SetActive(true);
        Time.timeScale = 0f; // pausa o tempo
        jogoPausado = true;
    }

    public void ContinuarJogo()
    {
        painelPause.SetActive(false);
        Time.timeScale = 1f; // volta o tempo
        jogoPausado = false;
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
