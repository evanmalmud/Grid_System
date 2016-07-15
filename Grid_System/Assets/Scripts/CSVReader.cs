using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;

public class CSVReader : MonoBehaviour {

    public TestAsset csvFile;

    public Player[] players;
    private char lineSeperater = '\n';
    private char fieldSeperater = ',';

    // Use this for initialization
    void Start () {
        List<string> header = new List<string>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void readData()
    {
        List<string> tempPlayer = new List<string>();
        string[] records = csvFile.text.Split(lineSeperater);
        bool hasHeader = false;

        foreach (string record in records)
        {
            string[] fields = record.Split(fieldSeperator);
            foreach (string field in fields)
            {
                if (!hasHeader)
                {
                    header.Add(field);
                }
                else
                {
                    //contentArea.text += field + "\t";
                }
            }

            if (!hasHeader)
            {
                hasHeader = true;
            }
        }
    }
// Add data to CSV file
}
