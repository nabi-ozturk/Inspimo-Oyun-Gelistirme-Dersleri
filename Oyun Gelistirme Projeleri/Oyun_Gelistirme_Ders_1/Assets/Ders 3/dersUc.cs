using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class dersUc : MonoBehaviour
{
    // Soru Ba�l��� ��eri�i
    public Text soruBasligiMetni;
    // Sorunun Metni
    public Text sorununMetni;
    // Sorunun Numaras�
    public int soruNumaras�;
    public Text soruNumarasiMetni;

    // �lk G�rev Tamamland�


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
    public void dogrulukKontrol�(string cevap)
    {
        dogruCevap = "�lham";

        if (dogruCevap == cevap)
        {



            sorununMetni.text = "Tebrikler! Do�ru Cevap.";
            aSikkiDogrulukResmi.color = Color.green;
            bSikkiDogrulukResmi.color = Color.white;
        }
        else
        {
            sorununMetni.text = "Hay Aksi! Yanl�� Cevap.";
            aSikkiDogrulukResmi.color = Color.white;
            bSikkiDogrulukResmi.color = Color.red;
        }
    }
        public void SoruUret() 
    {
        aSikkiDogrulukResmi.color = Color.white;
        bSikkiDogrulukResmi.color = Color.white;
        soruBasligiMetni.text = "Genel K�lt�r/Teknoloji";
        sorununMetni.text = "�nspimo'nun kelime anlam� a�a��dakilerden hangisidir?";
        soruNumaras� = 1;
        soruNumarasiMetni.text = soruNumaras�.ToString();
        aSikkiMetni.text = "A) " + "�lham";
        bSikkiMetni.text = "B) " + "�ntikam";
    }
}
