using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalvarTudo : MonoBehaviour
{
   [SerializeField]
   private GameObject triangulo;
   public void Salvar()
   {
        DontDestroyOnLoad(triangulo);
   }
}
