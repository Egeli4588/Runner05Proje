using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] Rigidbody rb;
    [SerializeField] public Animator myAnim;
    [Header("Settings")]
    [Tooltip("bu deðiþken oyuncunun hýzýný ifade eder")]
    [SerializeField] public float speed;
    [Tooltip("bu deðiþken saða sola kayma birimini ifade eder")]
    [SerializeField] public float shift = 2;
    [Tooltip("Bool ile karakter kontrolunde sag sol orta konumu ayarlama")]
    [SerializeField] public bool isLeft, isMiddle, isRight;
    [HideInInspector] public string denemeforgizleme;//gizleme1
    [System.NonSerialized] public string denemeforgizleme2;// gizleme 2

    //bool ile sürünmeden kurtulalaým

    public bool isDead;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMiddle = true;
        // transform.position= new Vector3 (0, 0, 5);
        myAnim.SetBool("Run", true);
    }

    // Update is called once per frame
    void Update()
    {

        moveCharacter();


        karakterHareket();

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

    /// <summary>
    /// burda otomatik ürettirdiðimiz metod
    /// </summary>
    void karakterHareket()
    {
        // programa ürettirdiðimiz metod
    }

    /// <summary>
    /// bu fonksiyon karakter hareketini saðlýyor
    /// </summary>
    void moveCharacter()
    {
        if (isDead) return;


        #region karakter sýnýrlama
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // 1.yöntem
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -0.5f)
        {
            transform.Translate(new Vector3(-shift, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 0.5f)
        {
            transform.Translate(shift, 0, 0);

        }






        //2.yöntem
        /*  if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && isLeft == false)

          {
              if (isMiddle)
              {
                  isLeft = true;
                  isMiddle = false;
              }
              else if (isRight)
              {
                  isMiddle = true;
                  isRight = false;
              }
              transform.Translate(new Vector3(-shift, 0, 0));
          }

          else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && isRight == false)

          {
              if (isMiddle)
              {
                  isRight = true;
                  isMiddle = false;

              }
              else if (isLeft) 
              {
                 isMiddle= true;
                  isLeft= false;
              }
              transform.Translate(new Vector3(shift, 0, 0));
          }

          */
        #endregion


    }

    /// <summary>
    /// oncollision Enter metodu herhangi bir objeyle çarpýþmayý kontrol eder
    /// çarpýþmanýn baþladýðý aný ifade eder
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("çarpýþtýk");

        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Obstacle çarpýþtýk " + other.gameObject.name);
                      
            myAnim.SetBool("Death", true);
            isDead = true;

        }

       /* if (other.gameObject.CompareTag("duvar")) 
        {
            Debug.Log("Duvar çarpýþtýk " + other.gameObject.name);
        }
       */
    }


    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    private void FixedUpdate()
    {
        // rb.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);

    }

}
