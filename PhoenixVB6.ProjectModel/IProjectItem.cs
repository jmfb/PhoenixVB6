namespace PhoenixVB6.ProjectModel
{
	public interface IProjectItem
	{
		int LineNumber { get; }

		string Key { get; }

		string Value { get; }
	}

	public interface IReferenceProjectItem : IProjectItem
	{
	}

	public interface IFileProjectItem : IProjectItem
	{
		string RelativePath { get; }
	}
}