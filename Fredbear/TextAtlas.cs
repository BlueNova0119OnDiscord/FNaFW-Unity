using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAtlas : MonoBehaviour
{
    public List<string> Dialogue1 = new List<string> { };
    public List<string> ClockDialogue1 = new List<string> { };
    public List<string> Dialogue2 = new List<string> { };
    public List<string> ClockDialogue2 = new List<string> { };
    public List<string> Dialogue3 = new List<string> { };
    public List<string> ClockDialogue3 = new List<string> { };
    public List<string> Dialogue4 = new List<string> { };
    public List<string> ClockDialogue4 = new List<string> { };
    public List<string> Dialogue5 = new List<string> { };
    public List<string> ClockDialogue5 = new List<string> { };
    public List<string> Dialogue6 = new List<string> { };
    public List<string> ClockDialogue6 = new List<string> { };
    public List<string> Dialogue7 = new List<string> { };
    public List<string> ClockDialogue7 = new List<string> { };
    public List<string> Dialogue8 = new List<string> { };
    public List<string> ClockDialogue8 = new List<string> { };
    public List<string> Dialogue9 = new List<string> { };
    public List<string> ClockDialogue9 = new List<string> { };

    public List<string>[] Dialogues;
    public List<string>[] ClockDialogues;

    void Awake()
    {
        Dialogues = new List<string>[10];
        ClockDialogues = new List<string>[10];

        Dialogues[1] = Dialogue1;
        ClockDialogues[1] = ClockDialogue1;
        Dialogues[2] = Dialogue2;
        ClockDialogues[2] = ClockDialogue2;
        Dialogues[3] = Dialogue3;
        ClockDialogues[3] = ClockDialogue3;
        Dialogues[4] = Dialogue4;
        ClockDialogues[4] = ClockDialogue4;
        Dialogues[5] = Dialogue5;
        ClockDialogues[5] = ClockDialogue5;
        Dialogues[6] = Dialogue6;
        ClockDialogues[6] = ClockDialogue6;
        Dialogues[7] = Dialogue7;
        ClockDialogues[7] = ClockDialogue7;
        Dialogues[8] = Dialogue8;
        ClockDialogues[8] = ClockDialogue8;
        Dialogues[9] = Dialogue9;
        ClockDialogues[9] = ClockDialogue9;
    }
}
