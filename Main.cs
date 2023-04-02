using System;

/*

To Do // Features:
==========
-   CharacterCreation.cs
    + complete character creation



Rework // Necessary Changes:
==========
-   



Completed:
==========
-   added string validation



*/

namespace TheArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // character creation phase
            CharacterCreation characterCreation = new CharacterCreation();
            characterCreation.WelcomePlayer();
            characterCreation.CreateCharacter();

            // main game play loop
            Combat combat = new Combat();
            
        }
    }
}