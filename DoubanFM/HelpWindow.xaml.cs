﻿/*
 * Author : K.F.Storm
 * Email : yk000123 at sina.com
 * Website : http://www.kfstorm.com
 * */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DoubanFM
{
	/// <summary>
	/// Interaction logic for HelpWindow.xaml
	/// </summary>
	public partial class HelpWindow : ChildWindowBase
	{
		public HelpWindow()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void Hyperlink_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start((sender as Hyperlink).Tag as string);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
			}
		}
	}
}