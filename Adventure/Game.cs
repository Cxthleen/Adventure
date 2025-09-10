using System;
using System.Threading;
using System.IO;

class Game
{
    static int affection = 0;
    static int sceneStage = 1;
    static string saveFile = "savegame.txt";
    static string currentGoal = "Meet Anakin";
    static bool gameRunning = false;

    public static void Start()
    {
        affection = 0;
        sceneStage = 1;
        currentGoal = "Meet Anakin";
        gameRunning = true;
        GameLoop();
    }

    private static void GameLoop()
    {
        while (gameRunning)
        {
            switch (sceneStage)
            {
                case 1: Scene1(); break;
                case 2: Scene2(); break;
                case 3: Scene3(); break;
                case 4: Scene4(); break;
                case 5: Scene5(); break;
                case 6: ShowEnding(); gameRunning = false; break;
                default: gameRunning = false; break;
            }
        }
    }

    // Scene 1: Reunion on Coruscant
    private static void Scene1()
    {
        Console.Clear();
        Console.WriteLine("===== Scene 1: Reunion on Coruscant =====");
        ShowGoal();

        Console.WriteLine("Your shuttle lands at the Senate platform. The cityscape stretches around you, glowing lights reflecting the tension in the galaxy.");
        Thread.Sleep(1200);
        Console.WriteLine("Anakin waits, intense, his eyes immediately on you.");
        Thread.Sleep(1200);
        Console.WriteLine("Anakin: \"Padmé... it's good to see you.\"");
        Thread.Sleep(1000);

        Console.WriteLine("\nHow do you respond?");
        Console.WriteLine("1. Warm: 'I've missed you too, Anakin. Tell me what you're thinking.'");
        Console.WriteLine("2. Formal: 'It’s good to see you, Anakin. We must remain professional.'");
        Console.WriteLine("3. Playful: 'You look serious—have you been brooding?'");
        Console.WriteLine("(Type 'hint' for a suggestion)");

        string choice = GetChoice("hint", "A warm response opens his heart; formality keeps distance; playful teasing lightens tension.");

        switch (choice)
        {
            case "1":
                Console.WriteLine("\nPadmé: \"I've missed you too, Anakin. Tell me what you're thinking.\"");
                Console.WriteLine("Anakin smiles, visibly relieved, tension easing from his shoulders.");
                affection += 2;
                currentGoal = "Reconnect and spend time with Anakin.";
                break;
            case "2":
                Console.WriteLine("\nPadmé: \"It’s good to see you, Anakin. We must remain professional.\"");
                Console.WriteLine("Anakin bows slightly, disappointment shadowing his eyes.");
                affection -= 1;
                currentGoal = "Find a way to soften his mood later.";
                break;
            case "3":
                Console.WriteLine("\nPadmé: \"You look serious—have you been brooding?\"");
                Console.WriteLine("Anakin chuckles nervously, the tension lightening just a little.");
                affection += 1;
                currentGoal = "Build lighthearted rapport.";
                break;
            default:
                Console.WriteLine("\nHe waits silently, unsure of your next move.");
                break;
        }

        sceneStage = 2;
        SaveOption();
    }

    // Scene 2: Naboo Retreat
    private static void Scene2()
    {
        Console.Clear();
        Console.WriteLine("===== Scene 2: Naboo Retreat =====");
        ShowGoal();

        Console.WriteLine("The serene lakes of Naboo stretch before you, reflecting the fading sun. Peace seems possible for a moment.");
        Thread.Sleep(1200);
        Console.WriteLine("Anakin sits near the fireplace, looking at you, eyes filled with intensity and longing.");
        Thread.Sleep(1200);

        Console.WriteLine("Anakin: \"I don't like sand. It's coarse and rough and irritating and it gets everywhere.\"");
        Thread.Sleep(1000);
        Console.WriteLine("Anakin: \"Being here with you... it's the only thing that feels right.\"");
        Thread.Sleep(1000);

        Console.WriteLine("\nYour response?");
        Console.WriteLine("1. Heartfelt: 'I feel the same, Anakin. I want to be with you.'");
        Console.WriteLine("2. Playful: 'You worry too much. It's just sand.'");
        Console.WriteLine("3. Caution: 'Anakin, we must think of our duties first.'");
        Console.WriteLine("4. Test him: 'Can you handle being with me and everything else?'");
        Console.WriteLine("(Type 'hint' for a suggestion)");

        string choice = GetChoice("hint", "Heartfelt choice strengthens your bond; humor or caution changes the mood subtly.");

        switch (choice)
        {
            case "1":
                Console.WriteLine("\nPadmé: \"I feel the same, Anakin. I want to be with you.\"");
                Console.WriteLine("Anakin smiles softly, a rare peace crossing his face.");
                affection += 2;
                currentGoal = "Prepare for harder times together.";
                break;
            case "2":
                Console.WriteLine("\nPadmé: \"You worry too much. It's just sand.\"");
                Console.WriteLine("Anakin chuckles nervously, tension easing.");
                affection += 1;
                currentGoal = "Share small joys amidst uncertainty.";
                break;
            case "3":
                Console.WriteLine("\nPadmé: \"Anakin, we must think of our duties first.\"");
                Console.WriteLine("He frowns slightly, the weight of responsibility returning.");
                affection -= 1;
                currentGoal = "Rebuild trust before things escalate.";
                break;
            case "4":
                Console.WriteLine("\nPadmé: \"Can you handle being with me and everything else?\"");
                Console.WriteLine("Anakin looks conflicted, unsure how to respond.");
                affection -= 2;
                currentGoal = "Convince him your bond is strong.";
                break;
            default:
                Console.WriteLine("\nHe waits silently, conflicted.");
                break;
        }

        sceneStage = 3;
        SaveOption();
    }

    // Scene 3: Tatooine Memories
    private static void Scene3()
    {
        Console.Clear();
        Console.WriteLine("===== Scene 3: Tatooine Memories =====");
        ShowGoal();

        Console.WriteLine("War reports reach you, darkening the horizon of hope. Anakin speaks of fear and loss.");
        Thread.Sleep(1200);
        Console.WriteLine("Anakin: \"I won't let anything happen to you. I will do anything to protect you.\"");
        Thread.Sleep(1000);

        Console.WriteLine("\nYour response?");
        Console.WriteLine("1. Comfort: 'I will stay with you. We can face it together.'");
        Console.WriteLine("2. Caution: 'I love you, but we must consider the consequences.'");
        Console.WriteLine("3. Humor: 'Well, let's hope things don't get too dramatic.'");
        Console.WriteLine("(Type 'hint' for a suggestion)");

        string choice = GetChoice("hint", "Comforting eases fear; caution protects both; humor lightens tension.");

        switch (choice)
        {
            case "1":
                Console.WriteLine("\nPadmé: \"I will stay with you. We can face it together.\"");
                Console.WriteLine("Anakin smiles softly, a moment of calm in the storm.");
                affection += 3;
                currentGoal = "Stand together through the storm.";
                break;
            case "2":
                Console.WriteLine("\nPadmé: \"I love you, but we must consider the consequences.\"");
                Console.WriteLine("Anakin looks distant, troubled by your words.");
                affection -= 2;
                currentGoal = "He may grow restless.";
                break;
            case "3":
                Console.WriteLine("\nPadmé: \"Well, let's hope things don't get too dramatic.\"");
                Console.WriteLine("Anakin chuckles nervously, tension easing slightly.");
                affection += 1;
                currentGoal = "Use small moments to strengthen your bond.";
                break;
            default:
                Console.WriteLine("\nHe waits silently, lost in thought.");
                break;
        }

        sceneStage = 4;
        SaveOption();
    }

    // Scene 4: Mustafar Confrontation
    private static void Scene4()
    {
        Console.Clear();
        Console.WriteLine("===== Scene 4: Mustafar Confrontation =====");
        ShowGoal();

        Console.WriteLine("\nMustafar. Rivers of molten lava blaze across the planet as your ship lands.");
        Thread.Sleep(1500);
        Console.WriteLine("The heat is suffocating; the roar of molten rock mirrors the turmoil in your heart.");
        Thread.Sleep(1500);
        Console.WriteLine("Anakin stands ahead, cloaked in shadow, his yellow eyes burning with anger as Obi-Wan is visibly ragebaiting in the doorway of your ship.");
        Thread.Sleep(1500);

        Console.WriteLine("\nHe rushes toward you, desperation in every step:");
        Console.WriteLine("\"You’re with him! You brought him here to kill me!\"");
        Thread.Sleep(2000);

        Console.WriteLine("\nWhat do you do?");
        Console.WriteLine("1. Reach for him: \"I love you! But Anakin, you’re going down a path I can’t follow.\"");
        Console.WriteLine("2. Plead: \"You’re breaking my heart! Please, come back to me!\"");
        Console.WriteLine("(Type 'hint' for a suggestion)");

        string choice = GetChoice("hint", "Anakin is consumed by fear and anger. Only love may reach him now.");

        switch (choice)
        {
            case "1":
                Console.WriteLine("\nPadmé: \"I love you! But Anakin, you’re going down a path I can’t follow.\"");
                Thread.Sleep(1200);
                Console.WriteLine("Anakin’s face twists with fury:");
                Console.WriteLine("\"Because of Obi-Wan? Don’t you turn against me!\"");
                affection -= 2;
                currentGoal = "You’re running out of time to save him.";
                break;
            case "2":
                Console.WriteLine("\nTears stream down your face.");
                Console.WriteLine("Padmé: \"You’re breaking my heart! Please, come back to me!\"");
                Thread.Sleep(1200);
                Console.WriteLine("For a fleeting moment, the man you loved flickers in his eyes.");
                affection += 1;
                currentGoal = "Maybe your words can still reach him.";
                break;
            default:
                Console.WriteLine("\nYou hesitate, unsure. Anakin watches, conflicted and dangerous.");
                currentGoal = "Act quickly before it’s too late.";
                break;
        }

        sceneStage = 5;
        SaveOption();
    }

    // Scene 5: Final Choice
    private static void Scene5()
    {
        Console.Clear();
        Console.WriteLine("===== Scene 5: Final Choice =====");
        ShowGoal();

        Console.WriteLine("The volcanic ground trembles. Ash and fire swirl around you.");
        Thread.Sleep(1200);
        Console.WriteLine("Your next words could change everything.");

        Console.WriteLine("\nChoices:");
        Console.WriteLine("1. Heartfelt: 'Stay with me. I won’t leave you.'");
        Console.WriteLine("2. Moral: 'Remember who you used to be.'");
        Console.WriteLine("3. Escape: 'We have to get out now!'");
        Console.WriteLine("(Type 'hint' for a suggestion)");

        string choice = GetChoice("hint", "Heartfelt may heal him; moral may plant doubt; escape may save you but risks anger.");

        switch (choice)
        {
            case "1":
                Console.WriteLine("\nPadmé: \"Stay with me. I won’t leave you.\"");
                affection += 3;
                break;
            case "2":
                Console.WriteLine("\nPadmé: \"Remember who you used to be.\"");
                break;
            case "3":
                Console.WriteLine("\nPadmé: \"We have to get out now!\"");
                affection -= 2;
                break;
            default:
                Console.WriteLine("\nYou hesitate, the outcome uncertain.");
                break;
        }

        sceneStage = 6;
        SaveOption();
    }

    private static void ShowGoal()
    {
        Console.WriteLine("==== Current Goal ====");
        Console.WriteLine(currentGoal);
        Console.WriteLine("======================");
    }

    private static string GetChoice(string hintCommand, string hintText)
    {
        while (true)
        {
            string input = Console.ReadLine().ToLower().Trim();
            if (input == hintCommand)
            {
                Console.WriteLine("\nHint: " + hintText);
                Console.WriteLine("(Press Enter to return to your choice)");
                Console.ReadLine();
                continue;
            }
            return input;
        }
    }

    private static void SaveOption()
    {
        Console.WriteLine("\nWould you like to save your progress? (yes/no)");
        string saveChoice = Console.ReadLine().ToLower().Trim();
        if (saveChoice == "yes" || saveChoice == "y")
        {
            SaveGame();
        }

        Console.WriteLine("\n(Press Enter to continue...)");
        Console.ReadLine();
    }

    public static void SaveGame()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(saveFile))
            {
                writer.WriteLine(sceneStage);
                writer.WriteLine(affection);
            }
            Console.WriteLine("Game saved!");
            Thread.Sleep(800);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving: {ex.Message}");
            Thread.Sleep(1200);
        }
    }

    public static void LoadGame()
    {
        if (File.Exists(saveFile))
        {
            try
            {
                string[] data = File.ReadAllLines(saveFile);
                if (data.Length >= 2 &&
                    int.TryParse(data[0], out int loadedStage) &&
                    int.TryParse(data[1], out int loadedAffection))
                {
                    sceneStage = loadedStage;
                    affection = loadedAffection;
                    Console.WriteLine("Savegame loaded. Resuming...");
                    Thread.Sleep(800);
                    gameRunning = true;
                    GameLoop();
                }
                else
                {
                    Console.WriteLine("Save file is corrupted or incomplete.");
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading: {ex.Message}");
                Thread.Sleep(1200);
            }
        }
        else
        {
            Console.WriteLine("No savegame found.");
            Thread.Sleep(800);
        }
    }

    private static void ShowEnding()
    {
        Console.Clear();
        Console.WriteLine("=== End of the Story ===\n");
        Thread.Sleep(1000);

        if (affection >= 6)
        {
            Console.WriteLine("For a fragile moment, Anakin’s fury fades. You see the man you once loved, even amidst the darkness.");
            Thread.Sleep(1500);
            Console.WriteLine("He hesitates, his breathing heavy, eyes searching yours for understanding.");
            Thread.Sleep(1500);
            Console.WriteLine("Padmé: \"We can face this together, Anakin. I won’t leave you.\"");
            Thread.Sleep(1500);
            Console.WriteLine("He takes your hands, and for a brief heartbeat, the galaxy seems at peace. The love you shared gives him the strength to resist the shadow threatening to consume him.");
            Thread.Sleep(1500);
            Console.WriteLine("\nEnding: Secret Lovers – Against all odds, your bond survives, a glimmer of hope in a galaxy torn apart.");
        }
        else if (affection >= 0)
        {
            Console.WriteLine("The darkness around him is overwhelming, and your words barely reach the man he once was.");
            Thread.Sleep(1500);
            Console.WriteLine("For a fleeting moment, you glimpse Anakin’s true self, but it slips away as the anger and fear take hold.");
            Thread.Sleep(1500);
            Console.WriteLine("Padmé: \"I tried... I tried to reach you.\"");
            Thread.Sleep(1500);
            Console.WriteLine("You are forced to step back, heartbroken. Though your love remains, the choices you made couldn’t fully save him.");
            Thread.Sleep(1500);
            Console.WriteLine("\nEnding: Bittersweet – Love endures, but the consequences of fear and anger leave an unhealed scar.");
        }
        else
        {
            Console.WriteLine("The darkness consumes him completely. Rage and fear have erased every trace of the man you loved.");
            Thread.Sleep(1500);
            Console.WriteLine("In a tragic instant, your vision narrows to loss. His voice, once full of warmth, is gone, replaced by cold fury.");
            Thread.Sleep(1500);
            Console.WriteLine("Padmé: \"Anakin... what have you become?\"");
            Thread.Sleep(1500);
            Console.WriteLine("You step back in fear as he slowly walks towards you with ill intent");
            Thread.Sleep(1500);
            Console.WriteLine("\nEnding: Tragic – Anakin chokes you with the force as his rage takes over.");
        }

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

        sceneStage = 1;
        currentGoal = "Meet Anakin";
    }

}
