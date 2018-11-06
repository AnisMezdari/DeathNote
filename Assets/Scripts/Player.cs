
public abstract class Player : Character{

    protected bool buttonIsDisplayed;

    public Player(bool isInteractable, string name) : 
        base(isInteractable, name){
        this.buttonIsDisplayed = false;
    }

    public override void Moving()
    {

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
}
