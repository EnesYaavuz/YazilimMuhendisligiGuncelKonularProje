using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Kod_Arayuz_BalonPatlatma : MonoBehaviour
{
    public int canMiktari;
    public GameObject oyunBittiPaneli;
    public TMP_Text txt_canMiktari;

    public Transform balonPrefab;
    public int kacBalonUretilsin;

    public GameObject devamEtButonu;

    int patlayanBalonSayisi = 0;
    void Start()
    {
        txt_canMiktari.text = canMiktari.ToString();
        if (devamEtButonu != null) devamEtButonu.SetActive(false);
        BalonUret();
    }

    // Update is called once per frame
    public void CanMiktariGuncelle(int gelenCan)
{
    canMiktari += gelenCan;
    txt_canMiktari.text = canMiktari.ToString();

    if (canMiktari <= 0)
    {
        if (oyunBittiPaneli != null)
            oyunBittiPaneli.SetActive(true);
        // İstersen oyunu durdurabilirsin:
        // Time.timeScale = 0;
    }
}

    public void BalonPatlatildi()
    {
        patlayanBalonSayisi++;

        if (patlayanBalonSayisi == kacBalonUretilsin)
        {
            if (devamEtButonu != null) devamEtButonu.SetActive(true);
            // Artık sahne hemen değişmeyecek, buton bekleyecek
        }
    }

    public void DevamEtButonunaBasildi()
    {
        SceneManager.LoadScene("Balon Patlatma 2");
    }
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("Ana Sahne");
    }

    void BalonUret()
    {
        for (int i = 0; i < kacBalonUretilsin; i++)
        {
            Instantiate(balonPrefab, 
                        new Vector3(Random.Range(-8f, 8f),-10,0),
                        Quaternion.Euler(90,-90,90)
                        );
        }
    }
}