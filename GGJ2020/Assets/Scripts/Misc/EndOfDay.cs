using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfDay : MonoBehaviour
{
    GameObject player;
    Wallet wallet;

    [SerializeField]
    List<string> causes;

    [SerializeField]
    private TMPro.TMP_Text currentMoney;
    [SerializeField]
    private TMPro.TMP_Text lostMoney;
    [SerializeField]
    private TMPro.TMP_Text youWon;
    [SerializeField]
    private TMPro.TMP_Text youLost;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        wallet = player.GetComponent<Wallet>();

        for(int i = 0; i < 3; i++)
        {
            int cost = Random.Range(0, 30);

            lostMoney.text += causes[Random.Range(0, causes.Count)] + " " + cost + " ";
            wallet.RequestFunds(cost);
        }

        if(wallet.GetFunds() <= 0)
        {
            youLost.enabled = true;
        }

        currentMoney.text += wallet.GetFunds() == 0 ? 0 : wallet.GetFunds();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BecomeCEO()
    {
        if (wallet.RequestFunds(1000))
            youWon.enabled = true;
    }

    public void StartNewDay()
    {
        SceneManager.LoadScene("Game");
    }
}
