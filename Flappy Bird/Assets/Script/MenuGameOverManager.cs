using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOverManager : MonoBehaviour
{

    public void VoltarMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void Sair()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
