using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.AI;
using System.IO;

public class Game : NetworkBehaviour
{

    private double notoriety;
    private List<PNJ> pnjList;
    public const int NOMBRE_PNJ = 30;
    public const string PATH_FILE_PNJ_NAMES = "Assets/Resources/PNJ/pnj_names.txt";

    public Game()
    {
        this.notoriety = 0;
        this.pnjList = new List<PNJ>(NOMBRE_PNJ);
    }

    public void DesignateStudentToDieList()
    {

    }
    public void LaunchGame()
    {

    }
    public void LoadMap()
    {

    }
    public List<string> LoadPNJnameFile()
    {
        FileInfo theSourceFile = null;
        StreamReader reader = null;
        string text = " "; // assigned to allow first line to be read below

        theSourceFile = new FileInfo(PATH_FILE_PNJ_NAMES);
        reader = theSourceFile.OpenText();

        List<string> listNamePNJ = new List<string>(NOMBRE_PNJ);

        int n = 0;
        while (n < NOMBRE_PNJ - 1)
        {
            text = reader.ReadLine();
            listNamePNJ.Add(text);
            n++;
        }
        reader.Close();

        return listNamePNJ;
    }
    public void LoadPNJ()
    {
        if (isServer)
        {
            List<string> listNamePNJ = LoadPNJnameFile();
            foreach (var name in listNamePNJ)
            {
                int randomNumber = Random.Range(1, 10 - 1);
                PNJ pnj = new PNJ(true, name, Resources.Load("PNJ/PNJ"), GameObject.Find("Cube"+ randomNumber).transform);
                GameObject gameObjectPnj = pnj.Instantiate(GameObject.Find("Cube"+ randomNumber).transform.position);
                NetworkServer.Spawn(gameObjectPnj);
            }
        }     
    }
    public void LoadPlayer()
    {

    }
    public void LoadUI()
    {

    }
    public void StartGame()
    {
        
    }
    public void EndGame()
    {

    }

    void Start()
    {
        LoadPNJ();
    }
}
