using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] public GameObject gameStartMenu;// start menü paneli için
    [SerializeField] public GameObject gameRestartMenu;// Restart menü Paneli için
    [SerializeField] public TextMeshProUGUI score;// restart de görünen
    [SerializeField] public TextMeshProUGUI mainScore;// her iki ekrandada görünen

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameStartMenu.SetActive(true);// oyun baþladýðýnda startmenu paneli açýyor
        gameRestartMenu.SetActive(false);// oyun baþladýðýnda reStartMenu panelini kapatýyor.
    }

    // Update is called once per frame
    void Update()
    {
        mainScore.text = "Score : " + playerController.score;

        if (playerController.isDead)
        {
            gameRestartMenu.SetActive(true);
            score.text = "Score : " + playerController.score;

        }

    }
    public void StartGame()
    {
        playerController.isStart = true;// oyun baþladý
        playerController.myAnim.SetBool("Run", true);
        gameStartMenu.SetActive(false);
    }

    public void ReStartGame() 
    {
        // SceneManager.LoadScene(0); çok dinamik deðil
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);// daha dinamik yapýdýr.
    
    }


}
