using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AklindanBirSayiTut : MonoBehaviour
{
    int minSayi = 1, maxSayi = 100, tahmin;
    bool oyunBasladi = false;
    bool oyunBitti = false;
    // Start is called before the first frame update
    void Start()
    {
        print("Benimle bir oyun oynamak ister misin? (E/H)");
    }

    // Update is called once per frame
    void Update()
    {
        if(!oyunBasladi)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Harika! Aklindan 1-100 arasinda bir sayi tut ve Enter tusuna bas!");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Sen bilirsin ;(");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Kontrol();
                oyunBasladi=true;
            }
        }
        else (!oyunBitti)
        {
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
                oyunBitti=true;
            }
        }
        void Kontrol()
        {
            tahmin = (minSayi + maxSayi) / 2;
            print("Aklindan tuttugun sayi " + tahmin + " mi? (YUKARI YON: Daha buyuk | ASAGI YON: Daha kucuk | BOSLUK: Dogru Cevap)");
        }

    }
}
