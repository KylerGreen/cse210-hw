using System;
using System.IO;

class Menu
{
    private int _score = 0;

    private List<Goal> _goals = new List<Goal>();


    public void Display()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateGoal();
                break;
            case "2":
                ListGoals();
                break;
            case "3":
                SaveGoals();
                break;
            case "4":
                LoadGoals();
                break;
            case "5":
                RecordEvent();
                break;
            case "6":
                Quit();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        switch (goalType)
        {
            case "1":

                Console.Write("Enter the name of the goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter a short description of the goal: ");
                string description = Console.ReadLine();
                Console.Write("Enter the points associated with this goal: ");
                int points = int.Parse(Console.ReadLine());

                Goal simpleGoal = new Simple(points, name, description, false);
                _goals.Add(simpleGoal);
                break;

            case "2":

                Console.Write("Enter the name of the goal: ");
                string Ename = Console.ReadLine();
                Console.Write("Enter a short description of the goal: ");
                string Edescription = Console.ReadLine();
                Console.Write("Enter the points associated with this goal: ");
                int Epoints = int.Parse(Console.ReadLine());

                Goal eternalGoal = new Eternal(Epoints, Ename, Edescription, false);
                _goals.Add(eternalGoal);
                break;

            case "3":

                Console.Write("Enter the name of the goal: ");
                string Cname = Console.ReadLine();
                Console.Write("Enter a short description of the goal: ");
                string Cdescription = Console.ReadLine();
                Console.Write("Enter the points associated with this goal: ");
                int Cpoints = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of times this goal needs to be accomplished for a bonus: ");
                int timesToComplete = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the goal that many times: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                Goal checklistGoal = new Checklist(Cpoints, Cname, Cdescription, timesToComplete, bonusPoints, false);
                _goals.Add(checklistGoal);
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        Display();
    }

    public void ListGoals()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        Console.WriteLine();
        int Number = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{Number}. ");
            goal.DisplayGoal();
            Number += 1;
        }

        Display();
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write("Please enter the filename to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation(goal));
            }
        }

        Display();
    }

    public void LoadGoals()
{
        Console.Clear();
        Console.WriteLine();
        Console.Write("Please enter the filename to load from: ");
        string filename = Console.ReadLine();

        using (StreamReader inputFile = new StreamReader(filename))
        {
            _goals.Clear();
            _score = int.Parse(inputFile.ReadLine());
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                string goalType = parts[0];
                string[] data = parts[1].Split('|');

                switch (goalType)
                {
                    case "Simple":
                        Goal simpleGoal = new Simple(int.Parse(data[2]), data[0], data[1], GetGoalStatus(data[3]));
                        _goals.Add(simpleGoal);
                        break;
                    case "Eternal":
                        Goal eternalGoal = new Eternal(int.Parse(data[2]), data[0], data[1], GetGoalStatus(data[3]));
                        _goals.Add(eternalGoal);
                        break;
                    case "Checklist":
                        Checklist checklistGoal = new Checklist(int.Parse(data[2]), data[0], data[1], int.Parse(data[5]), int.Parse(data[6]), GetGoalStatus(data[3]));
                        for (int i = 0; i < int.Parse(data[4]); i++)
                        {
                            checklistGoal.UpdateStatus(this);
                        }
                        _goals.Add(checklistGoal);
                        break;
                }
            }
        }

        Display();
}

    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        Console.WriteLine();
        int Number = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{Number}. ");
            goal.DisplayGoal();
            Number += 1;
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        Goal selectedGoal = _goals[choice - 1];
        selectedGoal.UpdateStatus(this);

        Display();
    }

    public void Quit()
    {
        Console.Clear();
    }

    public void AddPoints(int points)
    {
        _score += points;
    }

    public bool GetGoalStatus(String goalStatus)
    {
        if (goalStatus == "[ ]")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}