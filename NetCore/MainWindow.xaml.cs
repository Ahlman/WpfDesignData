using System.ComponentModel;

namespace NetCore
{
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();

			if(DesignerProperties.GetIsInDesignMode(this) == false)
			{
				DataContext = new DesignData();
			}
		}
	}
}
