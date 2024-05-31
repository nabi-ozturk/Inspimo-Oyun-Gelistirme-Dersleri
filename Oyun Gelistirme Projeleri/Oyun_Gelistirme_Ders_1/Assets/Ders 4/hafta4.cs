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
        biyografi.text = "Bilgi çekilirken hata oluþtu, lütfen tekrar deneyiniz!";
        resim.gameObject.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void veriÇek() {


        resim.gameObject.SetActive(true);



        isimSoyisim.text = "Muhammed Nabi Öztürk";
        adres.text = "Fýrat Teknokent Ofis:221 \nMerkez/Elazýð";
        webSitesi.text = "www.nabiozturk.com";
        telefon.text = "0555 555 55 55";
        email.text = "nabiozturk34@gmail.com";
        biyografi.text = "Fýrat Üniversitesi Teknoloji Fakültesi Yazýlým Mühendisliði 1. Sýnýf Öðrencisi";

        resim.sprite = profilFotografi;








    }
}
