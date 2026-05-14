namespace FindShaulsTreasure.Quests.Group_03;

public partial class Quest_03 : BaseQuestView
{
    Dictionary<string, string> ClueWords { get; set; }
    public Quest_03(int teamId) : base(teamId)
    {
        Data = new Models.QuestInfo("Flashing Letters", "", "");
        InitializeComponent();
        ClueWords = new Dictionary<string, string>();
        ClueWords.Add("Word1", "I");
        ClueWords.Add("Word2", "follow");
        ClueWords.Add("Word3", "steps");
        ClueWords.Add("Word4", "to");
        ClueWords.Add("Word5", "solve");
        ClueWords.Add("Word6", "problems");
        ClueWords.Add("Word7", "what");
        ClueWords.Add("Word8", "am");
        ClueWords.Add("Word9", "I?");
    }

}
