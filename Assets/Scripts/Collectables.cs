using UnityEngine;
using DG.Tweening;

public class Collectables : MonoBehaviour
{
    //Enuma eri�im sa�l�yorum
    public CollectablesEnum CollectablesEnum;  // enum�n i�indeki objelere er�ebilirim (Coin,Shield,...)
    public int ToBeAddedHealth;
    public int ToBeAddedScore;
    public int ToBeAddedSpeed;
    public GameObject Player;

    private void Start()
    {
        if (CollectablesEnum == CollectablesEnum.Coin)
        {
            Player = GameObject.FindFirstObjectByType<PlayerController>().gameObject; // Player objemize eri�tik
        }
    }

    private void Update()
    {
        if (CollectablesEnum == CollectablesEnum.Coin && Player.GetComponent<PlayerController>().isMagnetActive)
        {
            if (Vector3.Distance(Player.transform.position, this.transform.position) < 8)
            {
                transform.DOMove(Player.transform.position + new Vector3(0, 1, 0), 0.35f);
            }
        }
    }



}
