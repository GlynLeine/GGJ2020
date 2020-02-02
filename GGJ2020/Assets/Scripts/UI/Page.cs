using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Page : MonoBehaviour
{
    static int pageNumber = 0;

    public InstructionBook instructionBook;
    public TextMeshProUGUI text;

    private void Update()
    {
        text.text = instructionBook.GetInstruction(pageNumber).GetText();
    }

    // Update is called once per frame
    public void NextPage()
    {
        pageNumber++;
        if(pageNumber >= instructionBook.GetPageCount())
            pageNumber = instructionBook.GetPageCount() -1;
    }


    public void PreviousPage()
    {
        pageNumber--;
        if (pageNumber < 0)
            pageNumber = 0;
    }

}
