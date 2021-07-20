using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Randomizer : MonoBehaviour
{
    private int ID;

    public Animator Image;
    public Text Name;
    public Text Description;

    List<string> Names = new List<string>
    {"Freddy", "Bonnie", "Chica", "Foxy", "Endo 01", "Marionette", "Nightmare", "Fredbear", "Balloon Boy", "Purpleguy", "Paperpals", "Crying Child", "Toy Freddy", "Jack-O-Bonnie", "Toy Chica", "Withered Foxy", "Endo 02", "Phantom Marionette", "Nightmare Fredbear", "JJ", "Springtrap", "Virtua-Freddy", "Withered Bonnie", "Nightmare Chica", "Phantom Mangle", "Endoplush", "Nightmarionne", "Phantom BB", "Plushtrap", "Shadow Freddy", "Toy Bonnie", "Withered Chica", "Mangle", "Nightmare BB", "Golden Freddy", "Spring Bonnie", "Phantom Chica", "Phantom Foxy", "Phantom Freddy", "Nightmare Bonnie", "Jack-O-Chica", "Funtime Foxy", "Nightmare Freddy", "RWQFSFASXC", "Nightmare Foxy", "Withered Freddy"};

    List<string> Descriptions = new List<string>
    {"Back to basics!", "Jammin!", "Let's Eat!", "Back-In-Order!", "Because look at him!", "Think outside the box!", "This is why you wake up.", "Where it all started.", "Everyone's favorite!", "I take 10 seconds to draw!", "Huh?", "Still sad.", "Still Freddy- but shiny.", "Not canon, but still here.", "Let's Party!", "Still Foxy- but more YAAARG!", "Not as cute, but more useful.", "Put it back in the box!", "Getting down to business.", "Because one wasn't enough!", "Cuter in person; still a killer.", "Blink, and you'll miss him!", "Look into my eye!", "Making you a sandwich.", "Because he needed to be weirder.", "Because character quota.", "I'm taller in person.", "Because reasons.", "Because the world needed a plush version.", "I will eat your soul.", "Something new!", "What happened to Chica?!", "Kids can be so cruel...", "Some things can't be made cute.", "It's me.", "Male? Female? It's a rabbit, who cares.", "Stop calling me a watermelon.", "Because you can never have too much Foxy.", "Just taking a stroll.", "Let's get mean!", "Feeling empty inside.", "It wasn't meant to last.", "The more, the merrier.", "SAY MY NAME!", "Out of order since FNaF 1.", "Because we needed one more."};

    void Start()
    {
        ID = Random.Range(1, 46);
        int IDLists = ID - 1;

        Image.Play($"{ID}", 0);
        Name.text = Names[IDLists];
        Description.text = Descriptions[IDLists];

        //Debug.Log($"{ID} is {Names[IDLists]}");

        SceneManager.LoadScene(scenes.Overworld1);
    }
}
