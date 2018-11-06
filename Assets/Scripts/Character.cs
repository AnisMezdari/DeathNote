public abstract class Character : GameElement {

    protected string name;
    protected bool isDead;
    protected bool isChecked;
    protected bool isBlocked;

    public Character(bool isInteractable, string name) : base(isInteractable)
    {
        this.name = name;
        this.isDead = false;
        this.isChecked = false;
        this.isBlocked = false;
    }

    public void RotationToSpeaker() {}

    public void Die() {}

    public abstract void Moving();

    public abstract override void SetIsInteractable();
}
