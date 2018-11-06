using System.Collections.Generic;
using UnityEngine;

public class TeamPolice : MonoBehaviour {

    private List<Policeman> policemanList;

    public TeamPolice()
    {
        this.policemanList = new List<Policeman>();
    }

    public void addPoliceMan(Policeman policeman)
    {
        policemanList.Add(policeman);
    }

       

}
