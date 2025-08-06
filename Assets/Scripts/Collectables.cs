using UnityEngine;

public class Collectables : MonoBehaviour
{
    //Enuma eriþim saðlýyorum
    public CollectablesEnum CollectablesEnum;  // enumýn içindeki objelere erþebilirim (Coin,Shield,...)
    public int ToBeAddedHealth;
    public int ToBeAddedScore;
    public int ToBeAddedSpeed;
    public GameObject Player;

    private void Start()
    {
        if (CollectablesEnum == CollectablesEnum.Coin) 
        {
            Player = GameObject.FindFirstObjectByType<PlayerController>().gameObject; // Player objemize eriþtik
        }
    }



}
