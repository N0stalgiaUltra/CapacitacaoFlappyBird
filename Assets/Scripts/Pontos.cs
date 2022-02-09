using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public GameControle gameControle; 
    void Start()
    {
        gameControle = FindObjectOfType<GameControle>(); // toda vez que esse objeto por criado em Cena o game object ira procurá-lo no Script ,pois ele é um Prefab
    }                                                    // e não está na Cena, ele é invocado na Cena. 
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D colisor)
    {
        gameControle.Pontos++; //Sempre que o Jogador colide com o Box collider 2D soma +1 ao pontos
        gameControle.pontosText.text = gameControle.Pontos.ToString(); // converte a contagem de Pontos para o Tipo Texto no Canvas.
    }
}
