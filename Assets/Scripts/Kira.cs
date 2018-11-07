using System.Collections.Generic;

public class Kira : Player {

    private bool getDeathNote;
    private List<Character> characterMeetList;
    private bool isNeutralized;

    public Kira(bool isInteractable, string name) :
        base(isInteractable, name)
    {
        this.getDeathNote = true;
        this.characterMeetList = new List<Character>();
        this.isNeutralized = false;
    }

    public void OpenDeathNote()
    {
    }

    public void ChooseStudent()
    {
    }
}
