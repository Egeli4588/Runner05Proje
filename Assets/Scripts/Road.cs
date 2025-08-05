using UnityEngine;

public class Road : MonoBehaviour
{
    GameObject Player;// serialize kullanmayýz çünkü yollarýmýz dinamik olarak oluþuyor 
                      // bnu yüzden kod kod dosyasýna eriþeceðizz.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");// Player etiketine sahip olan koda eriþim saðlýyoruz 
    }

    // Update is called once per frame
    void Update()
    {     //oyuncunun pozisyonu ile yolun pozisyonu arasýndaki fark 25 ten büyük olduðunda arkadaki yollarý destroy et
        if ((Player.transform.position.z - this.transform.position.z) > 25)
        {
            Destroy(this.gameObject);
        }


    }
}
