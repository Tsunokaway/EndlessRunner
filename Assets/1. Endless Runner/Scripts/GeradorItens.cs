using UnityEngine;

public class GeradorItens : MonoBehaviour
{
     public GameObject modeloItem;

    public float tempoParaGerar = 3;
    private float cronometro;

    
    private void Awake()
    {
        cronometro = tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        if (modeloItem == null)
        {
            Debug.LogWarning("GeradorItens: Nenhum modeloItem atribuído!");
            return;
        }
        cronometro -= Time.deltaTime;
        if(cronometro < 0)
        {
            Debug.Log("Item gerado!");
            GameObject.Instantiate(modeloItem, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
        
    }
}