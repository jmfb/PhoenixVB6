using System.ComponentModel.Composition;

namespace PhoenixVB6.ProjectModel.Exports
{
	[Export]
	public class Project : IProject
	{
		#region IProject Members

		public virtual ProjectType Type { get; set; }

		public virtual string Name { get; set; }

		public virtual string Title { get; set; }

		public virtual string Description { get; set; }

		public virtual string BinaryName { get; set; }

		#endregion
	}
}