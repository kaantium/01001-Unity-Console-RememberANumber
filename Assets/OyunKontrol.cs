using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{

    int minSayi = 1, maxSayi = 100, tahmin; 
    // Start is called before the first frame update
    void Start()
    {
        print("Benimle bir oyun oynamak ister misin? (E/H)");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Harika! Akl�ndan 1-100 aras�nda bir say� tut ve Enter tu�una bas!");
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            print("Sen bilirsin ;(");
        }




        if (Input.GetKeyDown(KeyCode.Return))
        {
            tahmin = (minSayi + maxSayi) / 2;
            Kontrol();
        }





        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minSayi = tahmin;
            Kontrol();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxSayi = tahmin;
            Kontrol();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Yuppiii!");
        }

        void Kontrol()
        {
            tahmin = (minSayi / maxSayi) / 2;
            print("Akl�ndan tuttu�un say�" + tahmin + "mi? (YUKARI Y�N: Daha b�y�k | A�A�I Y�N: Daha k���k | BO�LUK: Do�ru Cevap)");
        }
    }
}
