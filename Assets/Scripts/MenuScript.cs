using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // A tecla ESC sai do jogo, mas somente no executavel e nao dentro do editor
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 50;

        Rect buttonTitulo = new Rect(400, 50, 400, 50);

        // Determinar o lugar do botão na tela
        Rect buttonPrimeira = new Rect(400, 100, buttonWidth, buttonHeight);

        Rect buttonSair = new Rect(400, 150, buttonWidth, buttonHeight);
        Rect buttonCreditos = new Rect(400, 400, 450, 50);

        GUI.Button(buttonTitulo, "Menu Principal - The Asteroids 2D");
        GUI.Label(buttonCreditos, "Desenvolvido por pauloreis66");

        if (GUI.Button(buttonPrimeira, "Primeiro Nível"))
        {
            SceneManager.LoadScene("Fase1");
        }

        if (GUI.Button(buttonSair, "Sair"))
        {
            Application.Quit();
        }

    }

}
