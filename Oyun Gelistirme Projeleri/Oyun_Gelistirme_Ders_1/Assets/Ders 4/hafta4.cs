using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hafta4 : MonoBehaviour
{
    public Text isimSoyisim;
    public Text adres;
    public Text webSitesi;
    public Text telefon;
    public Text email;
    public Text biyografi;

    public Image resim; 
    public Sprite profilFotografi;
    void Start()
    {
        biyografi.text = "Bilgi �ekilirken hata olu�tu, l�tfen tekrar deneyiniz!";
        resim.gameObject.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void veri�ek() {


        resim.gameObject.SetActive(true);



        isimSoyisim.text = "Muhammed Nabi �zt�rk";
        adres.text = "F�rat Teknokent Ofis:221 \nMerkez/Elaz��";
        webSitesi.text = "www.nabiozturk.com";
        telefon.text = "0555 555 55 55";
        email.text = "nabiozturk34@gmail.com";
        biyografi.text = "F�rat �niversitesi Teknoloji Fak�ltesi Yaz�l�m M�hendisli�i 1. S�n�f ��rencisi";

        resim.sprite = profilFotografi;








    }
}
