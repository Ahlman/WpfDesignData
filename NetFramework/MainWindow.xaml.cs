using System.ComponentModel;

namespace NetFramework
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
