using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData 
{
    public static string[] descriptions = 
    {
        "Description of room 0. This might be a long string because this is your first room",
        "Description of room 1. This is where the description of room 1 goes"
    };

    public static string[,] options =
    {
        {"North", "South", "East", "West"},
        {"Option 1", "Option 2", "Option 3", "Option 4"}
    };

    public static string[] endings =
    {
        "",""
    };
}
