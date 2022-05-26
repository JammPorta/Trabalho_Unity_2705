using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnviarNome : MonoBehaviour
{
   public string nomeplayer;
   public GameObject inputField;
   public GameObject textDisplay;
     public void StoreName()
    {
       nomeplayer = inputField.GetComponent<Text>().text;
       textDisplay.GetComponent<Text>().text = "Bem vindo" + nomeplayer + "ao nosso jogo";
    }
}
