using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class dersUc : MonoBehaviour
{
    // Soru Baþlýðý Ýçeriði
    public Text soruBasligiMetni;
    // Sorunun Metni
    public Text sorununMetni;
    // Sorunun Numarasý
    public int soruNumarasý;
    public Text soruNumarasiMetni;

    // Ýlk Görev Tamamlandý


    public Text aSikkiMetni;
    public Text bSikkiMetni;

    public string dogruCevap;


    public Image aSikkiDogrulukResmi;
    public Image bSikkiDogrulukResmi;
    private string cevap;

    void Start()
    {
        SoruUret();

    }
    void Update()
    {

       
    }
    public void dogrulukKontrolü(string cevap)
    {
        dogruCevap = "Ýlham";

        if (dogruCevap == cevap)
        {



            sorununMetni.text = "Tebrikler! Doðru Cevap.";
            aSikkiDogrulukResmi.color = Color.green;
            bSikkiDogrulukResmi.color = Color.white;
        }
        else
        {
            sorununMetni.text = "Hay Aksi! Yanlýþ Cevap.";
            aSikkiDogrulukResmi.color = Color.white;
            bSikkiDogrulukResmi.color = Color.red;
        }
    }
        public void SoruUret() 
    {
        aSikkiDogrulukResmi.color = Color.white;
        bSikkiDogrulukResmi.color = Color.white;
        soruBasligiMetni.text = "Genel Kültür/Teknoloji";
        sorununMetni.text = "Ýnspimo'nun kelime anlamý aþaðýdakilerden hangisidir?";
        soruNumarasý = 1;
        soruNumarasiMetni.text = soruNumarasý.ToString();
        aSikkiMetni.text = "A) " + "Ýlham";
        bSikkiMetni.text = "B) " + "Ýntikam";
    }
}
