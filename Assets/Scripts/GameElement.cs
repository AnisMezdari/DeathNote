using UnityEngine;

public abstract class GameElement : MonoBehaviour{

    protected bool isInteractable;

    public GameElement(bool isInteractable)
    {
        this.isInteractable = isInteractable;
    }

    public abstract void SetIsInteractable();
}
