﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WrongDocument : MonoBehaviour
{
    // Start is called before the first frame update

    public CreateDocument changeDocument = null;
    public TMP_Text score;
    public TMP_Text numberOfWarnings;
    void Start()
    {

    }

    void OnMouseDown()
    {
        changeDocument.changeDocument = true;

        if (changeDocument.currentDate.tag == changeDocument.incorrectDate || changeDocument.currentLogo.tag == changeDocument.incorrectLogo || changeDocument.currentSignature.tag == changeDocument.incorrectSignature)
        {
            changeDocument.scoreCounter++;
            score.text = changeDocument.scoreCounter.ToString();
        }


        else
        {
            changeDocument.wrongCounter++;
            numberOfWarnings.text = changeDocument.wrongCounter.ToString();
        }

    }

}