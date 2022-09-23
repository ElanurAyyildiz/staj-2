using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dortİslem : MonoBehaviour
{
    public UnityEngine.UI.Text İlkSayi,İkinciSayı,İslemİsareti,cevap,sonuc;
    public UnityEngine.UI.InputField sonucInput;
    int sayi1, sayi2, islemIsareti;
    int islemSonucu;
    //float bolumeSoucu;
    int maxSayi = 10;
    void Start()
    {
        YeniSoru();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CevapKontrol()
    {
        if (int.Parse(cevap.text) == islemSonucu)
        {
            sonuc.text = "DOGRU";
        }
        else
        {
            sonuc.text = "yanlış";
        }
    }
    public void YeniSoru()
    {
        sonuc.text = "";
        sonucInput.text = "";
        maxSayi = maxSayi + 2;
        sayi1 = Random.Range(1, maxSayi);
        sayi2 = Random.Range(1, maxSayi);
        islemIsareti = Random.Range(1,5);
        switch (islemIsareti)
        {
            case 1:
                İslemİsareti.text = "+";
                islemSonucu = sayi1 + sayi2;
                break;
            case 2:
                İslemİsareti.text = "-";
                islemSonucu = sayi1 - sayi2;
                break;
            case 3:
                İslemİsareti.text = "*";
                islemSonucu = sayi1 * sayi2;
                break;
            //case 4:
               // İslemİsareti.text = "/";
               // bolumeSoucu = sayi1 / sayi2;
                //break;
        }
        İlkSayi.text = sayi1 + "";
        İkinciSayı.text = sayi2 + "";
    }
}
