namespace FindShaulsTreasure.Pages;

public partial class QuestHolder : ContentPage
{
	int currentTeamId = 5;


	public QuestHolder()
	{
		InitializeComponent();

		var firstQuest = new Quests.Group_06.Quest_06(currentTeamId);

		cvCurrentQuest.Content = firstQuest;

		lQuestName.Text = firstQuest.Data.QuestName;
	}
}