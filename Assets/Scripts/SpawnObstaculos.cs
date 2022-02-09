using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaculos : MonoBehaviour
{
    public GameObject Obstaculos;// Declaro a variavel GameObject para ele referenciar os Objetos(Canos)
    public float alturaMax; // Variavel publica para que seja declarada em qualquer Script, e recebe os valores de altura dos Canos
    public float tempoMax = 1f; // Variavel publica que recebe os valores do Tempo de reaparecimento dos Canos
    private float tempo=0f; // Variavel Private para que ela seja declarada somente para esse Script e contador de Tempo
    // Void start sempre é o Primeiro codigo a ser Executado no Script 
    void Start()
    {
        GameObject newObstaculos = Instantiate(Obstaculos);// Intancia ou inicia um novo Objeto na Cena ou seja copia o objeto
        newObstaculos.transform.position = transform.position + new Vector3(0, Random.Range(-alturaMax,alturaMax),0);
        // Randomiza uma nova posição para o Objeto no Eixo Y, mantendo o Eixo X e Z sem alterar suas posições e  
        // limitando uma variações maxima para cima e para baixo na altura
    }

    void Update()
    {
        if(tempo > tempoMax)// Esse Codigo só irá executar se esse Condição for verdadeira
        {
            GameObject newObstaculos = Instantiate(Obstaculos);
            newObstaculos.transform.position = transform.position + new Vector3(0, Random.Range(-alturaMax,alturaMax),0);
            Destroy(newObstaculos, 10f); // Destroi o Novo objeto depois de 10 Segundos em Cena
            tempo = 0;
        }
        tempo += Time.deltaTime;// Contador de Tempo
    }
}
