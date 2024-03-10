using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ders1 : MonoBehaviour
{
    string benimadim = "Mustafa Simsek";
    int yasim = 33;
    string cinsiyet = "Erkek";
    string adres = "Erzene/Bornova/izmir";
    float boy = 1.80f;
    int kilo = 80;
    int sonuc = 0;
    int faktoriyel = 1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(benimadim);
        Debug.Log(yasim);
        Debug.Log(cinsiyet);
        Debug.Log(adres);
        Debug.Log(boy);
        Debug.Log(kilo);
        Debug.Log(kilo / (boy * boy));

        for (int i = 1; i <= 100; i++)
        {
            sonuc += i;
            Debug.Log(i + " ");

            
        }

        Debug.Log(sonuc);

        for (int i = 1; i <= 100; i++)
        {
            

            if (i % 2 == 0)
            {
                Debug.Log(i + "cift");
            }

            
        }
        for (int i = 1; i <= 100; i++)
        {


            if (i % 2 == 1)
            {
                Debug.Log(i + "tek");
            }
        }


        for (int i = 1; i <= 7; i++) 
        {
            faktoriyel *= i;

            


        }

        Debug.Log("7! =" + faktoriyel);









    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
