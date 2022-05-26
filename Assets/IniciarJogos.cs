using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IniciarJogos : MonoBehaviour
{
   public string nomeDaCena;
   
   public InputField playerName;
   public void MudarCena()
   {
    Debug.Log("O nome do player é " + playerName.text);
    SceneManager.LoadScene(nomeDaCena);
   }

   public void SairCena()
   {
       Application.Quit();
   }
}
