using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] road; //road adýnda içinde gameobject barýndan bir dizi tanýmladýk

    [SerializeField] Transform Player; // oyuncunun konumuna ihtiyacým var çünkü buna göre yollarýmý instantie edeceðim

    [SerializeField] Transform roadParent;// dinamik olarak yollarý üzerinde oluþturacaðýmýz obje (holder)

    [SerializeField] GameObject[] collactables; // dinamik olarak oluþturacaðým kodlarý tutacak olan dizi




    float roadLength = 20;

    int startRoadCount = 6;

    private void Start()
    {   //bu komut temelde klon oluþturmaya yarýyor.
        Instantiate(road[0], transform.position, Quaternion.identity, roadParent);

        for (int i = 0; i < startRoadCount; i++)
        {
            GenerateRoad();

        }
        SpawnCollectable();
    }

    void SpawnCollectable()
    {
        GameObject collectableObject = Instantiate(collactables[Random.Range(0, collactables.Length)], Player.position + new Vector3(0, 0.5f, 50f), Quaternion.identity);

        Invoke("SpawnCollectable", Random.Range(3f, 10f));
    }

    private void Update()
    {
        if (Player.position.z > roadLength / 2)
        {
            GenerateRoad();
        }
    }
    void GenerateRoad()
    {
        Instantiate(road[Random.Range(0, road.Length)], transform.position + new Vector3(0, 0, roadLength), Quaternion.identity, roadParent);
        roadLength += 20;

    }
}
