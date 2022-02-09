using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControle : MonoBehaviour
{
    public int Pontos;// Variavel que guarda os Valores dos pontos
    public Text pontosText; // Variavel que guarda os valores de Caracteres  
    void Start()
    {
        Time.timeScale=1;
    }
    public void RestartGame()// Reinicia a cena
    {
        SceneManager.LoadScene(0);// Carrega novamente a Cena
    }
}
