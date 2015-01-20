using System.IO;

namespace PhoenixVB6.Exports
{
	public class FileSystem : IFileSystem
	{
		#region IFileSystem Members

		public virtual Stream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return File.Open(path, mode, access, share);
		}

		#endregion
	}
}