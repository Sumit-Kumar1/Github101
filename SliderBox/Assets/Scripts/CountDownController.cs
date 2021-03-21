using System.Runtime.CompilerServices;
using System;
using System.Globalization;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
    [SerializeField] int countdownTime = 3;
    [SerializeField] Text CountDownText;
    public GameManager gm;
    public AudioSource countdown;
    void Start()
    {
        StartCoroutine(CountDownStart());
    }
    IEnumerator CountDownStart()
    {
        
        while(countdownTime>0)
        {
            countdown.Play();
            CountDownText.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdown.Stop();
        CountDownText.text = "GO!";
        yield return new WaitForSeconds(1f);
        CountDownText.gameObject.SetActive(false);
        gm.BeginGame();
    }
}
