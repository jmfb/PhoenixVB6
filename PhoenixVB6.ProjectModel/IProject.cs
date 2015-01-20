namespace PhoenixVB6.ProjectModel
{
	public interface IProject
	{
		ProjectType Type { get; set; }

		string Name { get; set; }

		string Title { get; set; }

		string Description { get; set; }

		string BinaryName { get; set; }
	}
}