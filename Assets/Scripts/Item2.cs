using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item2 : MonoBehaviour
{

    //  int coins = 0;
    //  int sword = 0;

    //[SerializeField] Text coinsCounter;
    //  [SerializeField] AudioSource collectionSound;


    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
           

         //   collectionSound.Play();
        }

     /*   if (other.gameObject.CompareTag("Coin"))
        {



            //   collectionSound.Play();   
        }  */

    }
}