using System.Threading;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string input = @"
A Y
A Y
B X
A Y
C Y
B Y
B Z
B Y
A X
B X
C Z
B Y
B Y
B Y
B Y
C X
A Z
B X
A Y
A Y
B Y
A X
C X
B Y
A Y
B Y
C X
A Z
B Y
A X
A Y
B Y
A Y
A X
B Y
B Y
B Y
B X
A X
C Y
A X
C Z
B Z
A Z
A Z
C X
A X
A X
B Y
B Y
C Y
B Y
B X
B Y
B Y
B X
C X
A X
A X
A Z
C X
A Z
A X
B Y
B Y
A Y
A Z
B Y
B X
B Y
B Y
B X
C Z
A X
B X
B X
A Y
B X
C Z
B Y
A X
C Z
A Y
B Y
B Y
A X
A Z
B Y
B Y
A Z
A Z
B Y
A X
A Z
C Y
A X
B Y
C X
A X
B Y
A X
A Z
C X
A Y
A X
B X
A X
B Z
B X
B Y
A X
A Y
B Y
B Z
C X
B X
A X
C Z
C Y
A Y
B Y
A X
B Y
C Y
B Y
C Y
B Y
C Z
C X
A Y
B Y
B X
A X
A X
A Y
A Y
B Y
A Z
B Y
A X
C X
B Y
B X
C X
A Y
B Z
B Y
B X
B Y
B Y
C Z
B X
B Z
A X
B Y
A X
B Y
C Z
A X
A Y
B Z
A X
B X
A Z
B Y
A Y
A X
B Y
C Z
B X
B Y
C X
B X
A X
C X
B X
B Y
B Z
B Y
B Y
A X
B Y
A X
A X
B X
A X
A X
B Y
B Y
B Y
C X
B Y
A Z
A X
B Y
A Y
A Z
B Y
A Z
C X
B Y
C X
B Y
B Y
A X
B Y
A X
B Y
B X
B Y
B Y
B Z
B Y
A Y
A X
A X
A X
C Z
A Y
A X
C Y
A X
B Z
B Y
B Y
B Y
A Z
B Y
B X
A Z
B Y
A Y
B Y
A Z
B Y
A X
B Z
A Z
C X
B Y
B Y
B Y
B X
A X
B X
A Y
B X
B Y
B Y
A X
B Y
B Z
B Y
B Y
B X
B X
C Z
A Y
B Y
B Y
B Y
B X
A X
B X
A Y
A Z
A Z
A Z
A X
A Y
B Y
C Y
A Z
A Z
A Z
C X
A X
C X
A Z
B X
A Y
B Y
A Z
B Y
B X
C Y
A Z
A X
C X
C X
C X
B Y
A X
A Y
C X
B Y
C Z
B Y
B Y
A Y
B Y
A Y
B Y
B Y
B X
A X
A X
A Z
A Y
B X
B Y
A Z
C X
A Y
A X
B Y
B Y
B X
A Z
B Y
A X
A X
B Y
A X
C X
A Z
A Z
B Y
A Z
A Y
A Y
A Y
B Y
A Y
A Z
A Y
A X
A Z
B Y
B Y
C X
B X
C Z
B X
A Z
C Y
B Y
A X
B Y
A Y
A X
B Y
B X
C Z
A Z
A Z
B Y
A Z
B Y
B Y
A X
A X
A X
B Z
A Y
B Z
A Y
C Y
A X
B X
A Y
B X
B Y
A X
A Y
A X
C X
C Z
B Y
A Y
B Y
B Z
A X
B Y
C Y
A Y
A Z
B Y
A X
A Z
A Y
B Y
B Y
A Z
C Z
B X
A Y
C Y
A X
A X
A X
B Y
C Z
A X
A X
B X
A X
A X
A Y
A X
C X
A X
A Y
B Z
A X
C X
A X
B X
A Y
A X
A X
A X
C Z
A X
A X
B X
B Y
A Y
A X
A Z
A Y
A Y
A Y
A Z
B X
A X
A X
A X
A Z
B Y
A X
A Y
B X
C X
B Y
A Z
A Z
A Z
B Z
B Y
A Z
A Z
A X
A Y
A X
A X
A X
A Y
A Z
B Y
A Z
B X
B X
A Y
A X
B X
B X
C Z
B X
A X
A Z
C X
A X
A X
B Z
A X
B X
A X
A X
A X
B Z
A Z
A Y
A Z
B Y
A X
A Y
A Y
B X
C Z
A X
A X
A X
B Y
B Y
A X
A X
B Y
A X
B X
A Y
C X
B X
B Y
C Z
B Y
A X
C Z
B Z
B Y
A Z
B X
B Y
B X
B Y
B Y
B Y
B X
B Y
A X
B Z
B Y
C X
B Y
C X
A Z
B X
A Z
A X
A Z
A Y
A X
A Z
B Y
B X
B X
B Y
B X
B X
B Z
B Z
B Y
A X
C X
B Y
B X
B X
C X
B X
B X
B Y
A Z
A Z
B Y
C Y
A Z
B Y
B Z
A Z
C Y
C X
A X
B Y
A Y
B X
B Y
B Z
A Y
A Z
A X
A X
C X
B Z
A Y
A Z
B Y
A Y
A Z
B Y
A Z
C Z
B Y
A X
A Z
B Y
B Y
A Y
A X
C Z
B Y
B X
A X
C Z
B Y
B Y
B Z
B Y
A Y
B Y
A Z
C Z
B Y
B X
B Z
B X
A X
A Y
A Z
A Z
A X
A X
B Y
B X
A Z
A X
B Y
B Y
B X
A Y
B Y
C Y
B Y
A X
B Y
B X
B Z
A X
B Y
B Y
A X
A X
A X
C X
B X
A Z
B X
C X
B Y
A Y
B Y
C X
B Y
B Y
B X
A X
A X
A X
A X
B Y
B Y
B Z
A Z
A Z
A Z
A Y
B X
A Y
B Y
C Z
C X
B Y
B Y
B Y
B Y
A X
A X
A Z
C Y
B X
A Y
B Y
B Y
C Z
B X
A X
A X
A Z
C X
B Y
B X
C Z
B X
A Y
B X
B X
B Z
C X
A Z
B Y
B X
B Y
B Y
A X
B Y
A X
A X
A Y
A Z
B Z
B Y
A Y
A Y
C Z
A Y
A X
B Y
B Y
C Z
B Y
A X
B X
A X
B Y
A X
A Z
B Z
B Y
A X
C X
A X
A X
B Y
A Y
A X
A Z
B Y
C Z
C X
A X
B X
B X
B Y
B X
B Y
B Y
A Z
A Y
A Z
A X
B Y
B X
B Y
C X
B Z
B X
C X
B Y
A X
A Y
A Y
B X
A X
B Y
B X
A X
B X
B Y
C Y
A Z
C Z
B X
B X
B Y
A Z
C Y
B X
A Z
B Y
A Y
A Z
B Y
A X
A Y
C Z
B Y
A X
B Y
B X
A Y
B Y
C X
A Y
B Y
B Y
A X
C Z
B Y
B X
A X
B X
B Y
A X
B Y
B Y
B Z
A X
C Z
A Y
B X
A X
C X
B Z
B Y
A Z
B X
A Z
B Y
C Z
A X
B Y
B X
B Y
A X
B Y
A X
A Y
A Y
A X
B Y
A X
B Y
A X
A Y
A Y
C X
B X
B Y
A Z
B X
A X
B Y
A Y
B X
B Y
A Z
B X
B X
A Y
B Y
A Z
B X
B Y
A Y
A X
A X
B X
C Z
A Y
B Y
A Z
A Z
A Z
B Y
A Y
A X
A Z
B X
B Y
C Y
A X
A X
C X
A Z
B X
B Y
B X
B Y
B Y
B Y
A X
B Z
B Z
B Z
B Y
A X
A X
B Y
A Z
B Y
C Y
B X
B X
B X
B Y
B Y
A Y
A X
B X
A X
A Z
A Y
C Y
B Y
B Z
B Z
A Y
B Y
A Z
B X
B Y
B Y
B X
B X
B Y
A X
C Z
B Y
A X
A X
A Y
B X
B Y
A Z
A Y
B Y
A Y
A X
A Z
A Y
A X
A X
A Y
B X
A X
B Y
B Y
B X
B Y
B Y
B Y
A Y
B X
A X
C Y
A Y
B Y
C X
C X
B Y
B Z
A Z
A Y
B Y
B Y
A Y
B Z
A Z
A X
B Y
A X
C Z
B Y
B Y
A Z
A Y
B Y
A Z
B Y
A Z
A Y
A Z
C Y
A Z
A X
A X
A Z
A X
B Y
A Z
B X
A Y
B Y
A Z
B X
B Z
B X
A Y
A Y
B Y
A Z
A X
B X
A Z
A X
B Y
B X
C X
A Z
C X
C X
B Z
A X
B Y
A Y
A Y
A Z
B Y
C X
A Z
A X
A Y
A Z
A X
A Y
A Y
A X
C X
B Y
B Y
B Y
A Z
B Y
A Z
B Y
C X
B Y
A X
B X
B Y
C X
A Z
B Y
B Y
B Y
A X
C Z
A Z
B Z
A X
A X
A X
A X
B Z
A Y
B X
B Z
A X
B X
A Y
A Y
C Z
B Y
B Y
A X
C Y
B X
B Y
A Y
C Z
A X
B X
A Z
C Z
C Z
B X
A Z
A X
B Z
A Z
B Y
B X
B Y
A Z
A Y
B Y
B Z
A X
B Z
A Z
A Y
C Y
A X
B Y
C Y
A Z
A Z
B X
B X
C X
A Y
B X
B X
B Y
A Y
C Z
A Z
A Y
B X
B Y
B Y
A X
C X
B X
A X
A Z
B Y
B Y
A X
A Y
B Y
C Z
A X
A X
B Y
A Y
A X
C Z
B X
C Y
A X
A X
A Y
B X
B Y
A X
B Y
A Y
B Y
B Y
B Y
B X
C X
A Z
A Z
A X
C Y
A Y
C X
A Z
A X
A X
B Y
A X
A X
B X
B Y
A Y
B Y
A X
B X
B Y
B Y
B X
C X
A Z
B Y
A Y
A Z
B Y
B Y
B Z
B Z
A X
B Y
A Y
A Z
A Y
A X
A Z
B X
A X
B X
A Y
C X
C X
A X
B X
A X
C X
A X
A Z
A Y
B Y
C X
A Y
A Y
B Y
B X
B Y
B Y
A Z
A Y
A Z
C X
B Y
B Y
A X
A X
B Y
A X
B Z
B X
B Y
A X
A Z
B Y
A Y
B Y
A X
C Z
A Z
A Y
B Y
B Y
B Y
B X
A Z
A Y
A X
B X
A Y
B Y
A Y
B Y
A Z
A Z
B Y
B X
B Y
A Y
C Y
B Z
B Y
A Y
C X
A Y
B Y
B Y
B Y
B Y
A X
B X
A Z
B Y
A Y
B Z
C X
B Y
A X
B X
B Y
B Y
A Y
A X
A Y
C X
B Y
A Y
A X
B Y
C X
A Y
B X
C Z
B Y
B Y
C Z
A X
A X
A X
A X
B Y
A Z
A Z
B X
A Z
A Z
A X
C Y
A Z
B Y
B Y
A Z
A Z
C Z
B Y
B X
C Z
C Z
B Y
B X
A Z
B X
C Z
C X
B Z
A Y
C Z
B Y
B Y
A Z
B Y
C X
C Y
B Y
C X
A X
A X
B Z
A Y
B Z
B Y
A X
B Z
A X
C X
B Y
A Y
A X
A X
B X
A X
A Y
A Y
B Y
B Z
B Y
A X
A Z
B Y
A Y
B Y
C Y
A X
B X
A X
B Y
A X
A X
B X
B Y
A Z
A Y
A X
C X
B X
C X
B Y
A X
B Y
A Z
A Z
C X
A Z
B Y
A Y
B Y
C X
B Y
B Z
A X
B Y
B X
A Z
B Z
B Y
A X
A Y
A Z
A Y
B Z
A X
A Y
A Z
A Y
C X
B Y
C Z
B Y
B Z
B X
B Y
A Z
C X
C Z
A Y
A Z
B Y
B X
B Y
B X
B X
A Y
A X
B X
B Y
A X
A X
B X
B Y
C X
A Y
C Y
A Z
C X
A Y
A Z
A Y
A X
A Z
B Y
C X
B Y
A Z
A Y
B Y
B Y
B X
B Y
C Z
A X
B X
A X
A X
A X
B Y
A X
B Z
B X
B Y
B Y
A X
B Z
A X
A Y
B Y
A X
B X
B Y
B X
A Z
A X
B Y
C X
B Y
A Z
B X
B Y
A Y
B X
A X
A X
A Y
A Y
B X
B Y
B Y
A X
A Y
B Y
A X
A X
A X
B X
B Y
A Y
A X
B Y
A X
B X
B Y
B Y
A Z
B X
B Y
B Z
A X
B X
A Z
A X
A Y
A X
B Y
B Y
A X
B Z
A X
B Y
B Z
A Y
A Y
A Z
A Y
B Y
A Y
B Y
A X
C Z
A Y
B X
B X
A Y
A X
B Y
C X
B X
B Z
A Y
A Y
C X
A X
B X
A X
A X
A Y
C X
A X
B Z
C Z
B X
B Y
A Z
C X
A X
B Y
B Y
A Y
B Z
B Y
B Y
A X
A X
C Z
B Y
B Y
B Y
A Z
A Z
B X
A X
B Y
A X
B Z
A X
B Y
B X
B Y
B Y
B Y
B Y
B Z
B Y
A Z
A X
C X
B Y
B Y
A X
B Y
B Y
A Z
A Z
A Z
A Z
A X
A Z
B X
B Y
B X
C Y
A Y
C X
B X
C X
A Z
B Y
B Y
A Y
B X
B Y
A Y
A X
A X
B Y
B X
A Y
B Y
B Y
C Z
C X
B X
B Y
A Y
A Z
B Y
A X
C Z
B Y
A Y
B Y
B Z
A X
A Z
A Y
A X
A Z
B Z
A Z
B Y
A Y
A X
A Z
B Y
B Y
B Y
B Y
B Y
A Z
B Y
C X
B Y
A Y
B X
B X
B Y
B Y
C X
C X
B Y
A Y
B Y
B Y
B X
A Z
B Y
B Y
B Y
A X
B Y
A Z
B Y
A X
B Y
B Y
A Z
B Y
A Z
C Z
B X
B Y
A Y
C Z
B Y
B X
B Y
A Z
A Z
B Y
C X
B Y
A Y
B Z
B Y
B Y
B X
A Z
A X
B Y
A X
A X
B X
B Y
A Z
B Y
C Z
A Z
A X
C Z
B Y
B X
C X
A X
A Z
A X
B Y
B Y
B X
A Z
B Y
B Y
C Z
A X
B Y
B Y
B X
B Y
B Y
C X
B Z
B Y
A X
B X
B X
B Y
A X
A Z
B Y
A X
A Z
A X
B Y
C Z
C X
C Z
A Z
B X
B Y
A X
B Z
A Y
A Z
A Z
A Z
A X
C Y
A X
B X
A Y
C Z
A X
B Y
B Y
A X
A Z
B Y
A Z
A X
A Z
B Y
A Y
B Y
A Y
C Y
B X
A Y
B Y
A X
B X
B Y
A Y
B Y
C Y
C X
B Y
B Y
B Z
B X
A Y
B Y
B Y
A X
C Y
C X
A X
B Y
B Y
B X
A X
B X
B Y
B Y
C X
B Y
B X
B X
A X
A X
B Y
B Y
B Y
B Y
B Y
C Z
A Y
B Y
C Z
B Y
C X
B Z
B Y
A X
A Z
B Y
A Y
A X
B Y
B Z
A X
C Y
B Y
B Y
A Z
A Y
B X
B Y
B Y
B Y
A Y
C Y
B X
B Y
B Y
B Y
B Y
B Y
A Y
B Y
A Z
B X
A Y
B X
B Y
B Y
A Z
B Z
B Y
C Y
A X
A Z
A X
B Y
C X
C Z
C Z
B Y
B Y
B Y
A Y
B X
B Y
C X
B Y
A Y
A Z
A X
A X
A Z
B Y
A Z
A X
B X
B Y
B Y
B Y
A Y
B Y
A Y
A Z
C Y
B X
C X
C X
A Y
B Y
A X
A X
A Y
A X
B Y
B Y
C X
B Y
C X
C X
C X
B Y
B X
B Z
A Y
C X
A Y
B Y
A Z
A Z
C Z
C X
A X
A X
A Z
B Y
C Z
B X
B Y
B Y
B Y
A Z
B Y
B X
B Y
B Y
A Z
A Z
B X
A X
B Z
A X
B Y
A Z
B Y
A Y
A X
B Y
B Y
C X
A X
B Y
C Y
B Y
B Y
A Y
A X
B X
B X
B Z
C X
B Y
B Y
C Y
B Y
A Y
B X
B Y
B X
A X
C X
C X
A X
A Y
A Y
B Y
A X
A X
B Y
A X
B Z
C X
B Y
A X
B Y
B Y
A Y
B Y
B Y
A X
B Z
B Y
B Y
A Z
B Z
B Z
B X
B Y
A Y
A Y
A X
B Y
A Y
B Y
A Z
B Y
A X
C Z
C Z
C X
B Y
B Z
B Z
C Z
B Z
B Y
C X
A Y
B Y
B Y
A X
C Z
A Y
A X
A Y
C X
A X
B X
C X
A Z
B Y
A X
A X
B Y
B Y
A X
B Y
A Z
A X
C X
B Y
C Z
B X
B Y
C Z
A X
B Z
A Y
A Y
B Y
C X
C Z
A X
A X
A Y
A Y
A Y
B Y
A X
A X
B Z
C Y
A Y
B Y
B Y
B Y
A X
A X
C Z
B Y
B Y
A X
B Y
B Y
A Y
A X
A Z
A Z
A Z
B X
A X
B Y
C Y
B Y
C Y
B X
A Y
C Z
A Y
B Y
A X
C X
A X
B Y
C X
A X
A X
B X
A Z
B X
C Z
A X
B X
A Y
C Y
C X
A X
A Y
A X
A X
B Y
A Z
A X
A Z
A Y
B Y
A Y
A X
B Y
A Y
A X
A X
B X
B Z
B Y
B X
C X
A Z
C X
B Y
A Y
B X
A Z
B Y
A Y
B Y
C X
B Y
B Y
C Z
B Z
B Y
A Z
A Y
B X
A X
A Z
A X
A Y
B X
A Z
A Y
A X
A X
B X
B Y
A X
C X
C Z
B Y
C X
B Y
A X
A X
B X
A X
A Z
B X
B Y
C X
B Y
B Y
A Z
A Y
A X
B X
A Z
A Y
C Z
A X
A X
A Z
C X
B Y
A Z
A Y
B Y
A Y
B X
B Y
C Y
B Y
C X
B Y
B Y
B Y
B X
C X
A X
B Y
B X
B X
B Y
A Z
B Y
A X
A X
A X
A X
C Y
A Z
A Y
C X
B X
A X
B Y
C X
C Z
B Y
A Z
B Z
B Y
B Y
A Y
B X
B Y
C X
B Y
A Y
B Z
A Z
A X
A X
A Y
C X
B Y
A Y
B X
B X
B Y
B Y
A Z
A Y
A Z
B Y
A Y
A X
B Y
C X
A X
B Y
A Y
A X
B Y
B Y
C Y
A X
A Z
A Y
B Y
B X
B X
B Y
A X
B Y
B X
A Y
B X
B Y
B Y
B Y
A Z
B Y
B Z
C X
A Z
B Y
B Y
C Y
A Y
B X
B Z
B X
A Z
B Y
B X
A Y
B X
B Z
A Z
C X
B X
B X
B Z
B Y
B Y
A Y
A Y
A Y
A Y
B Y
B Z
C X
A X
B Y
B X
A Y
C Z
B Y
A X
A Z
C X
A Z
A Z
C Y
B Y
A X
A X
C X
A Z
B Y
B Y
B Z
B Y
A X
C X
A X
A Z
A X
A X
A Y
C X
A Z
A X
C Y
A Y
C X
B Y
B Y
A X
B Y
A X
B Y
C X
B X
A X
A Z
A X
B Y
A Y
B Y
C X
B X
C Z
B Y
B Y
B Y
A X
B Y
A Y
A Z
C Z
A Y
B Y
C Y
C Z
A X
A Y
B Y
A Y
B X
C X
C Z
B X
A Z
A Z
B Y
A Y
A Z
B Z
C X
A Z
C X
B X
B Y
A Y
B X
A Z
A Y
A X
A X
B Y
A Y
C X
B Y
A X
B Z
B X
B Y
A Y
B Y
B X
A Z
A X
A X
B Y
A Z
B X
A Y
C Z
A Y
A X
B Y
B X
A Z
C Z
B X
A Z
A Y
A Z
B Y
B Y
C X
B Y
A Y
A Y
A Y
A X
B Y
B Y
A Z
A X
B X
A X
B Y
B Y
A Y
A Y
A X
B Y
B Y
B Y
C Z
B Y
A X
C X
A X
C X
B X
A X
A X
B Y
B Y
A X
B Y
B Y
A X
A Z
A Y
B Y
A X
C Y
C X
B Y
B X
B Y
B Z
B Y
A Y
B Y
A Z
C Z
A Y
A Y
B Y
B Y
A X
B Y
B Y
A Y
B Y
B Y
A X
A Z
A Z
A Y
B Y
A X
A Z
B Y
A X
B X
C Y
A X
A Y
B X
A X
A Y
A Z
C X
A X
A X
B Y
B Y
B Y
A X
A Z
A X
B Y
B Y
C Y
C Z
B Y
B Y
B Y
C X
B Y
A Z
A X
B X
B Y
C Z
A Z
A Z
B Y
A Z
A X
A Z
B Y
A X
C X
B X
A Y
B Y
C Y
A X
A X
B Y
A Z
A X
A X
A Y
A Y
A Y
B Y
A Y
";

int rockScore = 1;
int paperScore = 2;
int scissorScore = 3;

int lose = 0;
int draw = 3;
int win = 6;

int maxScoreSelf = 0;
int forcedMaxScore = 0;
int maxScoreEnemy = 0;

// gegner: A -> rock, B -> Paper, C -> Scissor
// selber: X -> rock, Y -> Paper, Z -> Scissor

// scores: 0 -> lose, 3 -> draw, 6 -> win
// shape score: 1 -> rock, 2 -> paper, 3 -> scissor

string currentSelectionEnemy = String.Empty;
string currentSelectionSelf = String.Empty;

foreach (var item in input)
{
    if (currentSelectionEnemy == "")
    {
        if (item.Equals('A'))
        {
            currentSelectionEnemy = item.ToString();
        }
        else if (item.Equals('B'))
        {
            currentSelectionEnemy = item.ToString();
        }
        else if (item.Equals('C'))
        {
            currentSelectionEnemy = item.ToString();
        }
    }
    else if(currentSelectionSelf == "")
    {
        if (item.Equals('X'))
        {
            currentSelectionSelf = item.ToString();
        }
        else if (item.Equals('Y'))
        {
            currentSelectionSelf = item.ToString();
        }
        else if (item.Equals('Z'))
        {
            currentSelectionSelf = item.ToString();
        }
    }
    else
    {
        currentTurn(currentSelectionEnemy, currentSelectionSelf);
        forceTurnResult(currentSelectionEnemy, currentSelectionSelf);
        // whitespace
        currentSelectionEnemy = "";
        currentSelectionSelf = "";
    }
}
Console.WriteLine(maxScoreSelf);
Console.WriteLine(forcedMaxScore);

void currentTurn(string enemy, string self)
{
    // gegner: A -> rock, B -> Paper, C -> Scissor
    // selber: X -> rock, Y -> Paper, Z -> Scissor
    if (enemy != null && enemy != "" && self != null && self != "")
    {
        // CALCULATE ALL DRAWS
        if (enemy == "A" && self == "X")
        {
            maxScoreSelf += draw + rockScore;
        }
        else if (enemy == "B" && self == "Y")
        {
            maxScoreSelf += draw + paperScore;
        }
        else if (enemy == "C" && self == "Z")
        {
            maxScoreSelf += draw + scissorScore;
        }
        // CALCULATE WIN/LOSE CONDITIONS
        if (enemy == "A" && self == "Y")
        {
            maxScoreSelf += win + paperScore;
        }
        else if (enemy == "A" && self == "Z")
        {
            maxScoreSelf += lose + scissorScore;
        }
        else if (enemy == "B" && self == "X")
        {
            maxScoreSelf += lose + rockScore;
        }
        else if (enemy == "B" && self == "Z")
        {
            maxScoreSelf += win + scissorScore;
        }
        else if (enemy == "C" && self == "X")
        {
            maxScoreSelf += win + rockScore;
        }
        else if (enemy == "C" && self == "Y")
        {
            maxScoreSelf += lose + paperScore;
        }
    }
}

void forceTurnResult(string enemy, string self)
{
    // gegner: A -> rock, B -> Paper, C -> Scissor
    // selber: X -> lose, Y -> draw, Z -> Win
    if (enemy != null && enemy != "" && self != null && self != "")
    {
        // A
        if (enemy == "A" && self == "X")
        {
            forcedMaxScore += lose + scissorScore;
        }
        else if (enemy == "A" && self == "Y")
        {
            forcedMaxScore += draw + rockScore;
        }
        else if (enemy == "A" && self == "Z")
        {
            forcedMaxScore += win + paperScore;
        }
        // B
        else if (enemy == "B" && self == "X")
        {
            forcedMaxScore += lose + rockScore;
        }
        else if (enemy == "B" && self == "Y")
        {
            forcedMaxScore += draw + paperScore;
        }
        else if (enemy == "B" && self == "Z")
        {
            forcedMaxScore += win + scissorScore;
        }
        // C
        else if (enemy == "C" && self == "X")
        {
            forcedMaxScore += lose + paperScore;
        }
        else if (enemy == "C" && self == "Y")
        {
            forcedMaxScore += draw + scissorScore;
        }
        else if (enemy == "C" && self == "Z")
        {
            forcedMaxScore += win + rockScore;
        }
    }
}