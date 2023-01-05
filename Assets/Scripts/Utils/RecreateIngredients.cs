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
      
      public static GameObject tomato2;
      public static GameObject mozzarella2;

      private static List<GameObject> allTypeIngredients = new List<GameObject>();
      private static List<GameObject> tom = new List<GameObject>();
      private static List<GameObject> moz = new List<GameObject>();
      private static List<GameObject> pep = new List<GameObject>();
      private static List<GameObject> mus = new List<GameObject>();
      private static List<GameObject> oli = new List<GameObject>();
      private static List<GameObject> sal = new List<GameObject>();

      private static GameObject pizzaClone;
      static int k = 0;
      
      void Start()
      {
        genTenOfEach();        
      }

      void genTenOfEach(){
            for(int i = 0;i<10;i++){
                GameObject mozz = Instantiate(mozzarella,new Vector3(Random.Range(-0.70f,-0.6f),0.168f,Random.Range(1.06f,1.3f)),Quaternion.identity);
                mozz.name = "mozzarella "+(i+1);
                moz.Add(mozz);
            }
            allTypeIngredients.Add(mozzarella);
            for(int i =0;i<10;i++){
                GameObject tomm = Instantiate(tomato,new Vector3(Random.Range(-0.5f,-0.37f),0.168f,Random.Range(1.06f,1.3f)),Quaternion.identity);
                tomm.name = "tomato "+(i+1);
                tom.Add(tomm);
            }
            allTypeIngredients.Add(tomato);
            for(int i =0;i<10;i++){
                GameObject sall = Instantiate(salami, new Vector3(Random.Range(0.2f,0.3f),0.168f,Random.Range(1.06f,1.3f)),Quaternion.identity);
                sall.name = "salami "+(i+1);
                sal.Add(sall);
            }
            allTypeIngredients.Add(salami);
             for(int i =0;i<10;i++){
                GameObject pepp = Instantiate(pepper,new Vector3(Random.Range(-0.20f,-0.20f),0.168f,Random.Range(1.06f,1.25f)),Quaternion.identity);
                pepp.name = "pepper "+(i+1);
                pep.Add(pepp);
            }
            allTypeIngredients.Add(pepper);
            for(int i =0;i<10;i++){
                GameObject olii = Instantiate(olive,new Vector3(Random.Range(-0.08f,0.08f),0.168f,Random.Range(1.06f,1.18f)),Quaternion.identity);
                olii.name = "olive "+(i+1);
                oli.Add(olii);
            }
            allTypeIngredients.Add(olive);
              for(int i =0;i<10;i++){
                GameObject muss = Instantiate(mushroom,new Vector3(Random.Range(-0.05f,0.07f),0.168f,Random.Range(1.18f,1.28f)),Quaternion.identity);
                muss.name = "mushroom "+(i+1);
                mus.Add(muss);
            }
            allTypeIngredients.Add(mushroom);

            pizzaClone = Instantiate(pizza,new Vector3(-0.95f,0.1f,1.16f),Quaternion.identity);
            allTypeIngredients.Add(pizza);
      }

      static void genTenOfEachStatic(){
            for(int i = 0;i<10;i++){
                GameObject mozz = Instantiate(allTypeIngredients[0],new Vector3(Random.Range(-0.70f,-0.6f),0.168f,Random.Range(1.06f,1.3f)),Quaternion.identity);
                mozz.name = "mozzarella "+(i+1);
                moz.Add(mozz);

                GameObject tomm = Instantiate(allTypeIngredients[1],new Vector3(Random.Range(-0.5f,-0.37f),0.168f,Random.Range(1.06f,1.3f)),Quaternion.identity);
                tomm.name = "tomato "+(i+1);
                tom.Add(tomm);

                GameObject sall = Instantiate(allTypeIngredients[2], new Vector3(Random.Range(0.2f,0.3f),0.168f,Random.Range(1.06f,1.3f)),Quaternion.identity);
                sall.name = "salami "+(i+1);
                sal.Add(sall);
                      
                GameObject pepp = Instantiate(allTypeIngredients[3],new Vector3(Random.Range(-0.20f,-0.20f),0.168f,Random.Range(1.06f,1.25f)),Quaternion.identity);
                pepp.name = "pepper "+(i+1);
                pep.Add(pepp);
         
                GameObject olii = Instantiate(allTypeIngredients[4],new Vector3(Random.Range(-0.08f,0.08f),0.168f,Random.Range(1.06f,1.18f)),Quaternion.identity);
                olii.name = "olive "+(i+1);
                oli.Add(olii);
         
                GameObject muss = Instantiate(allTypeIngredients[5],new Vector3(Random.Range(-0.05f,0.07f),0.168f,Random.Range(1.18f,1.28f)),Quaternion.identity);
                muss.name = "mushroom "+(i+1);
                mus.Add(muss);
            }
            pizzaClone = Instantiate(allTypeIngredients[6],new Vector3(-0.95f,0.1f,1.16f),Quaternion.identity);
      }

      public static void ResetIngredients(){
            foreach(GameObject el in moz){
                Destroy(el);
            }
            foreach(GameObject el in sal){
                Destroy(el);
            }
            foreach(GameObject el in pep){
                Destroy(el);
            }
            foreach(GameObject el in mus){
                Destroy(el);
            }
            foreach(GameObject el in oli){
                Destroy(el);
            }
            foreach(GameObject el in tom){
                Destroy(el);
            }

            foreach(GameObject el in allTypeIngredients){
                Debug.Log(el.name);
            }

            Destroy(pizzaClone);
            genTenOfEachStatic();
        }
    }
}