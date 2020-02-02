using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfDay : MonoBehaviour
{
    GameObject player;
    Wallet wallet;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        wallet = player.GetComponent<Wallet>();

        if(wallet.GetFunds() < 0)
        {
            Debug.Log("LOST GAME");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BecomeCEO()
    {
        if (wallet.RequestFunds(1000))
            Debug.Log("YOU WON");
    }

    public void StartNewDay()
    {
        SceneManager.LoadScene("Game");
    }
}
