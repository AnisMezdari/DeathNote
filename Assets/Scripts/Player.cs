using UnityEngine;

public abstract class Player : Character{

    protected bool buttonIsDisplayed;
    protected CharacterController characterController;

    private float movementSpeed;

    public Player(bool isInteractable, string name) : base(isInteractable, name)
    {
        this.buttonIsDisplayed = false;
    }

    private void Start()
    {
        this.characterController = GetComponent<CharacterController>();
        this.movementSpeed = 5.0F;
    }

    public override void PlayerMovement()
    {
        float horizInput = Input.GetAxis("Horizontal") * this.movementSpeed;
        float vertInput = Input.GetAxis("Vertical") * this.movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        this.characterController.SimpleMove(forwardMovement + rightMovement);
    }

    public override void SetIsInteractable()
    {
       
    }

    public void DisplayUIButtonInteract()
    {

    }

    public void Interact()
    {

    }

    public void DisplayUIInteract()
    {

    }

    public void CheckCharacter()
    {

    }

    private void Update()
    {
        this.PlayerMovement();
    }
}
