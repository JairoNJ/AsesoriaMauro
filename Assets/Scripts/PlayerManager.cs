using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    [SerializeField] float speedPlayer;
    [SerializeField] float moveHorizontal;
    [SerializeField] float moveVertical;
    CharacterController player;
    Vector3 playerInput;
    Vector3 movePlayer;

    //Accede al script levelChager para validar el cambio de escena
    [SerializeField]
    private LevelChanger levelChanger;


    Animator playerAnimatorController;


    public Camera mainCamera; 
    private Vector3 camForward;
    private Vector3 camRight;

    private void Awake()
    {
        levelChanger = FindObjectOfType<LevelChanger>().GetComponent<LevelChanger>();

    }

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        //playerAnimatorController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        playerInput = new Vector3(moveHorizontal, 0, moveVertical);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

       // playerAnimatorController.SetFloat("AnyRunVelocity", playerInput.magnitude * speedPlayer);

        CamDirection();

        movePlayer = playerInput.x * camRight + playerInput.z * camForward;
        player.transform.LookAt(player.transform.position + movePlayer);

        player.Move(movePlayer * speedPlayer * Time.deltaTime);


        //Debug.Log(player.velocity.magnitude);
    }

    void CamDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "door1")
        {
            levelChanger.FadeToNextLevel_1();
            Debug.Log("TRIGUER OK!");
        }
        else if(other.gameObject.tag == "door2")
        {
            levelChanger.FadeToNextLevel_2();
            Debug.Log("TRIGUER OK!");
        }
        else if (other.gameObject.tag == "door3")
        {
            levelChanger.FadeToNextLevel_3();
            Debug.Log("TRIGUER OK!");
        }
        else if (other.gameObject.tag == "door4")
        {
            levelChanger.FadeToNextLevel_0();
            Debug.Log("TRIGUER OK!");
        }
        else
        {
            return;
        }
    }

    private void OnAnimatorMove()
    {
        
    }
    
    
  
}
