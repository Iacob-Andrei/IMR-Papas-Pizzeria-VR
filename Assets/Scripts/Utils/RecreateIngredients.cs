using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class RecreateIngredients : MonoBehaviour
    {
      public GameObject tomato;
      public GameObject mozzarella;
      public GameObject pepper;
      public GameObject mushroom;
      public GameObject olive;
      public GameObject salami;
      public GameObject pizza;

      private List<GameObject> tom = new List<GameObject>();
      private List<GameObject> moz = new List<GameObject>();
      private List<GameObject> pep = new List<GameObject>();
      private List<GameObject> mus = new List<GameObject>();
      private List<GameObject> oli = new List<GameObject>();
      private List<GameObject> sal = new List<GameObject>();
      int k = 0;
      
      void Update()
      {
        if(k==0){
            for(int i = 0;i<7;i++){
                Vector3 randomPos = new Vector3(Random.Range(-0.70f,-0.6f),0.168f,Random.Range(1.06f,1.3f));
                moz.Add(Instantiate(mozzarella,randomPos,Quaternion.identity));
            }
            for(int i =0;i<10;i++){
                Vector3 randomPos = new Vector3(Random.Range(-0.5f,-0.37f),0.168f,Random.Range(1.06f,1.3f));
                tom.Add(Instantiate(tomato,randomPos,Quaternion.identity));
            }
            for(int i =0;i<10;i++){
                Vector3 randomPos = new Vector3(Random.Range(0.2f,0.3f),0.168f,Random.Range(1.06f,1.3f));
                sal.Add(Instantiate(salami,randomPos,Quaternion.identity));
            }
             for(int i =0;i<10;i++){
                Vector3 randomPos = new Vector3(Random.Range(-0.26f,-0.20f),0.168f,Random.Range(1.06f,1.3f));
                pep.Add(Instantiate(pepper,randomPos,Quaternion.identity));
            }
            for(int i =0;i<10;i++){
                Vector3 randomPos = new Vector3(Random.Range(-0.08f,0.08f),0.168f,Random.Range(1.06f,1.18f));
                oli.Add(Instantiate(olive,randomPos,Quaternion.identity));
            }
              for(int i =0;i<10;i++){
                Vector3 randomPos = new Vector3(Random.Range(-0.05f,0.07f),0.168f,Random.Range(1.18f,1.28f));
                mus.Add(Instantiate(mushroom,randomPos,Quaternion.identity));
            }
            Instantiate(pizza,new Vector3(-0.183f,-0.166f,0.206f),Quaternion.identity);
            Debug.Log(moz.Count);
            k++;
        }

      }
    }
}