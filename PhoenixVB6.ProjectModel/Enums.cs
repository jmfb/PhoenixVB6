using System.ComponentModel;

namespace PhoenixVB6.ProjectModel
{
	public enum ProjectType
	{
		[Description("Standard EXE")]
		Exe,

		[Description("ActiveX EXE")]
		OleExe,

		[Description("ActiveX DLL")]
		OleDll,

		[Description("ActiveX Control")]
		Control,
	}

	public enum DataBindingBehavior
	{
		None = 0,
		SimpleBound = 1,
		ComplexBound = 2,
	}

	public enum DataSourceBehavior
	{
		None = 0,
		DataSource = 1,
	}

	public enum Instancing
	{
		Private = 1,
		PublicNotCreatable = 2,
		SingleUse = 3,
		GlobalSingleUse = 4,
		MultiUse = 5,
		GlobalMultiUse = 6,
	}

	public enum MTSTransactionMode
	{
		NotAnMTSObject = 0,
		NoTransactions = 1,
		RequiresTransaction = 2,
		UsesTransaction = 3,
		RequiresNewTransaction = 4,
	}

	public enum Persistable
	{
		NotPersistable = 0,
		Persistable = 1,
	}

}