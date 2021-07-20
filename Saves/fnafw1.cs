using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fnafw1 : MonoBehaviour
{
    public static float[] have;
    public static float[] slot;
    public static float[] active;
    public static float[] chip;
    public static bool    newstart;
    public static float   x;
    public static float   y;
    public static float   underworldx;
    public static float   underworldy;
    public static float[] activeb;
    public static float[] bytes;
    public static float   started;
    public static float[] jumps;
    public static float   cine;
    public static float   glitched;
    public static float   clock;
    public static float   key;
    public static float   tokens;
    public static float[] ar;
    public static float   pearls;
    public static float   area;

    void Awake()
    {
        have = new float[49];
        slot = new float[9];
        active = new float[5];
        chip = new float[22];
        activeb = new float[5];
        bytes = new float[22];
        jumps = new float[7];
        ar = new float[4];
    }

    public static void resetSave()
    {
        int i = 1;
        while (i < 49)
        {
            PlayerPrefs.DeleteKey($"have{i}");
            i++;
        }
        i = 1;
        while (i < 9)
        {
            PlayerPrefs.DeleteKey($"slot{i}");
            i++;
        }
        i = 1;
        while (i < 5)
        {
            PlayerPrefs.DeleteKey($"active{i}");
            i++;
        }
        i = 1;
        while (i < 22)
        {
            PlayerPrefs.DeleteKey($"chip{i}");
            i++;
        }
        i = 1;
        PlayerPrefs.DeleteKey($"x");
        PlayerPrefs.DeleteKey($"y");
        PlayerPrefs.DeleteKey($"underworldx");
        PlayerPrefs.DeleteKey($"underworldy");
        while (i < 5)
        {
            PlayerPrefs.DeleteKey($"activeb{i}");
            i++;
        }
        i = 1;
        while (i < 22)
        {
            PlayerPrefs.DeleteKey($"bytes{i}");
            i++;
        }
        PlayerPrefs.DeleteKey("started");
        i = 1;
        while (i < 7)
        {
            PlayerPrefs.DeleteKey($"jumps{i}");
            i++;
        }
        PlayerPrefs.DeleteKey("cine");
        PlayerPrefs.DeleteKey("glitched");
        PlayerPrefs.DeleteKey("clock");
        PlayerPrefs.DeleteKey("key");
        PlayerPrefs.DeleteKey("tokens");
        i = 1;
        while (i < 4)
        {
            PlayerPrefs.DeleteKey($"ar{i}");
            i++;
        }
        PlayerPrefs.DeleteKey("pearls");
        PlayerPrefs.DeleteKey("area");
    }

    public static void saveSlotValue(float characterID, int id)
    {
        slot[id] = characterID;
        PlayerPrefs.SetFloat($"slot{id}", characterID);
        //Debug.Log($"Saved slot{id} with a value of {slot[id].ToString()}.");
    }

    public static void loadSlotValue(int id)
    {
        slot[id] = PlayerPrefs.GetFloat($"slot{id}", -1f);
        //Debug.Log($"Loaded slot{id} with a value of {slot[id]}.");
    }

    public static void saveHaveValue(float save, int id)
    {
        have[id] = save;
        PlayerPrefs.SetFloat($"have{id}", save);
        //Debug.Log($"Saved {name} with a value of {have[id].ToString()}.");
    }

    public static void loadHaveValue(int id)
    {
        have[id] = PlayerPrefs.GetFloat($"have{id}", 0f);
        //Debug.Log($"Loaded have{idhave} with a value of {have[idhave]}.");
    }

    public static void saveChipValue(float save, int id)
    {
        chip[id] = save;
        PlayerPrefs.SetFloat($"chip{id}", save);
        //Debug.Log($"Saved {chip[id]} with a value of {chip[id].ToString()}.");
    }

    public static void loadChipValue(int id)
    {
        chip[id] = PlayerPrefs.GetFloat($"chip{id}", 0f);
        //Debug.Log($"Loaded chip{id} with a value of {chip[id]}.");
    }

    public static void saveActiveValue(float characterID, int id)
    {
        active[id] = characterID;
        PlayerPrefs.SetFloat($"active{id}", characterID);
        //Debug.Log($"Saved active{id} with a value of {active[id].ToString()}.");
    }

    public static void loadActiveValue(int id)
    {
        active[id] = PlayerPrefs.GetFloat($"active{id}", -1f);
        //Debug.Log($"Loaded active{id} with a value of {active[id]}.");
    }

    public static void saveByteValue(float save, int id)
    {
        bytes[id] = save;
        PlayerPrefs.SetFloat($"bytes{id}", save);
        //Debug.Log($"Saved {bytes[id]} with a value of {bytes[id].ToString()}.");
    }

    public static void loadByteValue(int id)
    {
        bytes[id] = PlayerPrefs.GetFloat($"bytes{id}", 0f);
        //Debug.Log($"Loaded bytes{id} with a value of {bytes[id]}.");
    }

    public static void saveActiveBValue(float characterID, int id)
    {
        activeb[id] = characterID;
        PlayerPrefs.SetFloat($"activeb{id}", characterID);
        //Debug.Log($"Saved activeb{id} with a value of {activeb[id].ToString()}.");
    }

    public static void loadActiveBValue(int id)
    {
        activeb[id] = PlayerPrefs.GetFloat($"activeb{id}", -1f);
        //Debug.Log($"Loaded activeb{id} with a value of {activeb[id]}.");
    }

    public static void saveStartedValue(int save)
    {
        started = save;
        PlayerPrefs.SetFloat("started", save);
    }

    public static void loadStartedValue()
    {
        started = PlayerPrefs.GetFloat("started", 0f);
    }

    public static void saveJumpValue(float save, int id)
    {
        jumps[id] = save;
        PlayerPrefs.SetFloat($"jumps{id}", save);
        //Debug.Log($"Saved {jumps[id]} with a value of {jumps[id].ToString()}.");
    }

    public static void loadJumpValue(int id)
    {
        jumps[id] = PlayerPrefs.GetFloat($"jumps{id}", 0f);
        //Debug.Log($"Loaded jumps{id} with a value of {jumps[id]}.");
    }

    public static void saveCineValue(float save)
    {
        cine = save;
        PlayerPrefs.SetFloat($"cine", save);
        //Debug.Log($"Saved cine with a value of {cine}.");
    }

    public static void loadCineValue()
    {
        cine = PlayerPrefs.GetFloat($"cine", 1f);
        //Debug.Log($"Loaded cine with a value of {cine}.");
    }

    public static void saveXValue(float save)
    {
        x = save;
        PlayerPrefs.SetFloat($"x", save);
        //Debug.Log($"Saved x with a value of {x}.");
    }

    public static void loadXValue()
    {
        x = PlayerPrefs.GetFloat($"x", 707f);
        //Debug.Log($"Loaded x with a value of {x}.");
    }

    public static void saveYValue(float save)
    {
        y = save;
        PlayerPrefs.SetFloat($"y", save);
        //Debug.Log($"Saved y with a value of {y}.");
    }

    public static void loadYValue()
    {
        y = PlayerPrefs.GetFloat($"y", 356f);
        //Debug.Log($"Loaded y with a value of {y}.");
    }

    public static void saveUnderworldXValue(float save)
    {
        underworldx = save;
        PlayerPrefs.SetFloat($"underworldx", save);
        //Debug.Log($"Saved underworldx with a value of {underworldx}.");
    }

    public static void loadUnderworldXValue()
    {
        underworldx = PlayerPrefs.GetFloat($"underworldx", 668.2f);
        //Debug.Log($"Loaded underworldx with a value of {underworldx}.");
    }

    public static void saveUnderworldYValue(float save)
    {
        underworldy = save;
        PlayerPrefs.SetFloat($"underworldy", save);
        //Debug.Log($"Saved underworldy with a value of {underworldy}.");
    }

    public static void loadUnderworldYValue()
    {
        underworldy = PlayerPrefs.GetFloat($"y", 404.4f);
        //Debug.Log($"Loaded underworldy with a value of {underworldy}.");
    }

    public static void saveGlitchedValue(float save)
    {
        glitched = save;
        PlayerPrefs.SetFloat($"glitched", save);
        //Debug.Log($"Saved glitched with a value of {glitched}.");
    }

    public static void loadGlitchedValue()
    {
        glitched = PlayerPrefs.GetFloat($"glitched", 0f);
        //Debug.Log($"Loaded glitched with a value of {glitched}.");
    }

    public static void saveClockValue(float save)
    {
        clock = save;
        PlayerPrefs.SetFloat($"clock", save);
        //Debug.Log($"Saved clock with a value of {clock}.");
    }

    public static void loadClockValue()
    {
        clock = PlayerPrefs.GetFloat($"clock", 1f);
        //Debug.Log($"Loaded clock with a value of {clock}.");
    }

    public static void saveKeyValue(float save)
    {
        key = save;
        PlayerPrefs.SetFloat($"key", save);
        //Debug.Log($"Saved key with a value of {key}.");
    }

    public static void loadKeyValue()
    {
        key = PlayerPrefs.GetFloat($"key", 0f);
        //Debug.Log($"Loaded key with a value of {key}.");
    }

    public static void saveTokensValue(float save)
    {
        tokens = save;
        PlayerPrefs.SetFloat($"tokens", save);
        //Debug.Log($"Saved tokens with a value of {tokens}.");
    }

    public static void loadTokensValue()
    {
        tokens = PlayerPrefs.GetFloat($"tokens", 0f);
        //Debug.Log($"Loaded tokens with a value of {tokens}.");
    }

    public static void saveArmorValue(float save, int id)
    {
        ar[id] = save;
        PlayerPrefs.SetFloat($"ar{id}", save);
        //Debug.Log($"Saved ar{id} with a value of {ar[id].ToString()}.");
    }

    public static void loadArmorValue(int id)
    {
        ar[id] = PlayerPrefs.GetFloat($"ar{id}", 0f);
        //Debug.Log($"Loaded ar{id} with a value of {ar[id]}.");
    }

    public static void savePearlsValue(float save)
    {
        pearls = save;
        PlayerPrefs.SetFloat($"pearls", save);
        //Debug.Log($"Saved x with a value of {x}.");
    }

    public static void loadPearlsValue()
    {
        pearls = PlayerPrefs.GetFloat($"pearls", 0f);
        //Debug.Log($"Loaded x with a value of {x}.");
    }

    public static void saveAreaValue(float save)
    {
        area = save;
        PlayerPrefs.SetFloat($"area", save);
        //Debug.Log($"Saved area with a value of {area}.");
    }

    public static void loadAreaValue()
    {
        area = PlayerPrefs.GetFloat($"area", 0f);
        //Debug.Log($"Loaded area with a value of {area}.");
    }
}