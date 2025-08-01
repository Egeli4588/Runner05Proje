using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] public Animator myAnim;
    [SerializeField] public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // transform.position= new Vector3 (0, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
       // rb.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);



        // transform translate ile ýþýnlama 
        //  transform.Translate(Vector3.forward*speed*Time.deltaTime);


        /*  if (Input.GetKey(KeyCode.A))
          {
              myAnim.SetBool("Run", true);
          }
          else if (Input.GetKeyUp(KeyCode.A))
          {
              myAnim.SetBool("Run", false);
          }
          if (Input.GetKeyDown(KeyCode.Space)) 
          {
              myAnim.SetBool("Jump", true);        
          }
          else if (Input.GetKeyUp(KeyCode.Space))
          {
              myAnim.SetBool("Jump", false);
          }

          */

    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);

    }

}
