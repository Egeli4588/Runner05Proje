using UnityEngine;

public class CamFallow : MonoBehaviour
{
    // burda oyuncunun pozisyon bilgisi alacaðýz.
    [SerializeField] Transform Player;
    float zoffset;
    private void Start()
    {
        zoffset=transform.position.z-Player.position.z;
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Player.position.z+zoffset);
    }
}
