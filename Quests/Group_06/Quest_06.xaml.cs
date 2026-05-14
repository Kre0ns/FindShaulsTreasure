namespace FindShaulsTreasure.Quests.Group_06;

public partial class Quest_06 : BaseQuestView
{
	public Quest_06(int teamId): base(teamId)
    {
        Data = new Models.QuestInfo("Tralala", "Example Hint", Models.QuestType.Manual, "Example Answer");
        InitializeComponent();
	}
}