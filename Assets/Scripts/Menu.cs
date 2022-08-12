using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*    Classe que gerencia as funções dos botões
 *    das cenas: MenuInicial, Intro e Creditos
 */

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Carrega a cena "Intro"
    public void LoadIntro()
    {
        SceneManager.LoadScene("Intro");
    }

    // Carrega a cena "Creditos"
    public void LoadCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    // Carrega a cena "MenuInicial"
    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    // Fecha o jogo
    public void ExitGame()
    {
        Application.Quit();
    }
}
