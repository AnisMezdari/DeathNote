using System.Collections.Generic;
using UnityEngine;

public class TeamKira : MonoBehaviour {

    private List<Character> studentsToDieList;

    public TeamKira()
    {
        this.studentsToDieList = new List<Character>();
    }

    public int NumberOfKiraALive()
    {
        return 0;
    }

}
