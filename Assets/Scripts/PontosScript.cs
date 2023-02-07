using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PontosScript : MonoBehaviour
{
    public TMP_Text pontosGui;// Arrastar da hierarquia Pontos para a variavel publica Pontos da Main Camera
    public TMP_Text recordeGui;// Arrastar da hierarquia Recorde para a variavel publica Recorde da Main Camera
    public int pontos = 0;// Dar acesso ao script nave, por isso deve ser public

    // Update is called once per frame
    void Update()
    {
        if (pontos > PlayerPrefs.GetInt("Recorde"))
        {
            PlayerPrefs.SetInt("Recorde", pontos);
        }
        pontosGui.fontStyle = FontStyles.Bold;
        recordeGui.fontStyle = FontStyles.Bold;
        pontosGui.fontSize = 18;
        recordeGui.fontSize = 18;
        pontosGui.text = "Pontos " + pontos;
        recordeGui.text = "Recorde: " + PlayerPrefs.GetInt("Recorde");
    }
}
