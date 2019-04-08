//WinMain.xaml.cs
//   WinMain.xaml TreasureChest3 Code-Behind...
//   Copyright © 1998-2018, Ken Clark
//*********************************************************************************************************************************
//
//   Modification History:
//   Date:       Description:
//   10/12/18    Started History;
//=================================================================================================================================
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using TC3Base;
using TC3Model.Login;
using TreasureChest3.WPF.Logon;

namespace TreasureChest3.WPF
{
    /// <summary>
    /// Interaction logic for WinMain.xaml
    /// </summary>
    public partial class WinMain : Window
    {
        public WinMain()
        {
            InitializeComponent();
            tcBase = FindResource("tcBase") as TCBase;
            Debug.WriteLine(message: $"{tcBase.AppName} Initializing...");
            MenuHelpAbout.Header = $"_About {tcBase.AppName}...";
            OKtoClose = true;
#if InvokeMain
            try
            {
                //MyBase.ActiveForm = New frmMain(MyBase.Support, Me, Nothing)
                WinMain main = new WinMain();
                //MyBase.ActiveForm.ShowDialog()
                bool? result = main.ShowDialog();
            }
            catch (Exception ex)
            {
                string Message = $"{ex.Message}\n\nStackTrace:\n{ex.StackTrace}\n";
                Exception iException = ex.InnerException;
                if (!(iException == null))
                {
                    Message += "\nUnderlying Exception(s):\n";
                    while (!(iException == null))
                    {
                        Message += $"{iException.GetType().Name}\n{iException.Message}\n\nStackTrace:\n{iException.StackTrace}\n";
                        iException = iException.InnerException;
                    }
                }
                System.Windows.MessageBox.Show(Message, ex.GetType().Name);
            }
#endif
            //TODO: Write a routine to use the connection string to get our UserName...
            string connectionString = ConfigurationManager.ConnectionStrings["TCContext"].ConnectionString;

            this.lblUserID.Text = "Ken Clark";
            this.Title = $"{tcBase.AppName} [DB: {this.lblDatabase.Text}]";

            //StatusBar Stuff...
            sbpMessage.Text = $"Version {tcBase.AppVersion}";
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;
            timer.Start();

            SimulateStatusBar();
        }
        #region "Events..."
        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            if (mShown) return;
            mShown = true;
            DisplayLogon();
            //DisplayUserControl($"{tcBase.AppName}.Logon", "ucLogon");
        }
        #endregion
        #region "Properties..."
        private TCBase tcBase = null;
        private bool OKtoClose { get; set; }
        private UserControl mCurrentControl = null;
        private bool mShown = false;    //TODO: Refactor into a base Window class...
        public bool Shown { get { return mShown; }}
        #endregion
        #region "Methods..."
        public void DisplayLogon()
        {
            ToolBar.IsEnabled = false;
            ToolBarMenu.IsEnabled = false;

            ucLogon mCurrentControl = new ucLogon();
            mCurrentControl.Cancel += Logon_Cancel;
            mCurrentControl.Error += Logon_Error;
            mCurrentControl.Submit += Logon_Submit;
            ContentArea.Children.Add(mCurrentControl);
        }
        public void DisplayUserControl(string componentName, string controlName)
        {
            controlName = $"{componentName}.{controlName}";
            Type typ = Type.GetType(controlName);
            UserControl uc;

            if (typ.BaseType.Name == "UserControlSubmitCancel") {
                //Create an instance of this control
                mCurrentControl = (UserControlSubmitCancel)Activator.CreateInstance(typ);
                if (mCurrentControl != null)
                {
                    //((UserControlSubmitCancel)mCurrentControl).Cancel += WinMain_Cancel;
                    //((UserControlSubmitCancel)mCurrentControl).Error += WinMain_Error;
                    //((UserControlSubmitCancel)mCurrentControl).Submit += WinMain_Submit;
                    ContentArea.Children.Add(mCurrentControl);
                }
            }
            else {
                //Create an instance of this control
                uc = (UserControl)Activator.CreateInstance(typ);
                if (uc != null)
                {
                    ContentArea.Children.Add(uc);
                }
            }
        }
        private void Logon_Cancel(object sender, EventArgs e)
        {
            ContentArea.Children.Clear();
            Logon_Close(sender);
            this.Close();
        }
        private void Logon_Close(object sender)
        {
            ucLogon mCurrentControl = (ucLogon)sender;
            mCurrentControl.Cancel -= Logon_Cancel;
            mCurrentControl.Error -= Logon_Error;
            mCurrentControl.Submit -= Logon_Submit;
        }
        private void Logon_Error(object sender, EventArgs e)
        {
            MessageBox.Show(((LoginEventArgs)e).LoginObject.ValidationRuleMessages.ToString());
        }
        private void Logon_Submit(object sender, EventArgs e)
        {
            tcBase.UserName = ((LoginEventArgs)e).LoginObject.LoginID;
            //TODO: Authenticate...
            ContentArea.Children.Clear();
            ToolBar.IsEnabled = true;
            ToolBarMenu.IsEnabled = true;
            Logon_Close(sender);
        }

        //private void DoMenu(string ComponentName, string ClassName, string Caption)
        //{
        //    string assemblyName = string.Empty;
        //    Assembly TCAssembly = null;
        //    //TODO: TC3Base objTC3Component = null;
        //    try
        //    {
        //        this.Cursor = Cursors.Wait;
        //        //mTCBase.MainHeight = this.Height;
        //        //mTCBase.MainWidth = this.Width;
        //        //mTCBase.SaveTop = this.Top;
        //        //mTCBase.SaveLeft = this.Left;
        //        //mTCBase.SaveCaption = this.Text;
        //        //mTCBase.SaveIcon = this.Icon;
        //        //mTCBase.ActiveForm = this;

        //        //Load the target assembly...
        //        assemblyName = FindComponent(ComponentName);
        //        if (string.IsNullOrEmpty(assemblyName))
        //            throw new Exception($"Unable to determine assembly location for component \"{ComponentName}\"");
        //        TCAssembly = Assembly.LoadFrom(assemblyName);
        //        objTCComponent = (TC3Base)TCAssembly.CreateInstance(ClassName, true, BindingFlags.CreateInstance, null, new object[] {
        //            mSupport,
        //            ClassName.Split('.')[1]
        //        }, null, null);
        //        if ((objTCComponent == null))
        //            throw new Exception(string.Format("Component not properly configured - Class \"{0}\" not found in Assembly \"{1}\"", ClassName, assemblyName));

        //        objTCComponent.Splash += this.DoSplash;
        //        try
        //        {
        //            objTCComponent.Load(this, Caption);
        //        }
        //        finally
        //        {
        //            objTCComponent.Splash -= this.DoSplash;
        //        }

        //        this.Hide();
        //        this.niMain.Visible = true;
        //        this.niMain.Text = AppName;

        //        this.Text = mTCBase.SaveCaption + " - " + Caption;
        //        this.Icon = objTCComponent.Icon;
        //        this.Cursor = Cursors.Arrow;

        //        objTCComponent.Show();
        //    }
        //    finally
        //    {
        //        objTCComponent.Dispose();
        //        objTCComponent = null;
        //        TCAssembly = null;
        //        AssemblyName = null;
        //        ShowMain();
        //    }
        //    ShowMain();
        //}
        private string FindComponent(string componentName) {
            string appPath = TCBase.ApplicationPath();
            //First look under where our main application lives (mSupport.ApplicationPath)...
            string testPath = $"{appPath}\\{componentName}";
            if (File.Exists(testPath)) return testPath;
            //OK, now look under where the component would live if we were running in a development environment...
            FileInfo fi = new FileInfo(appPath);
            testPath = $"{fi.DirectoryName}\\{TCBase.ParsePath(componentName, TCBase.ParseParts.FileNameBase)}\\bin\\{componentName}";
            if (File.Exists(testPath)) return testPath;
            return null;
        }
        /// <summary>
        /// Example of how to load a ResourceDictionary dynamically at run-time...
        /// </summary>
        //private void LoadResource(string xamlPath)
        //{
        //    ResourceDictionary resourceDictionary = new ResourceDictionary();
        //    string resourcePath = $"/TC3Base;component/{xamlPath}";
        //    resourceDictionary.Source = new Uri(resourcePath, UriKind.RelativeOrAbsolute);
        //    try
        //    {
        //        this.Resources.MergedDictionaries.Clear();
        //        this.Resources.MergedDictionaries.Add(resourceDictionary);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}
        //private void ProtectMissingMenuComponents()
        //{
        //    this.MenuDatabaseBooks.Visibility = string.IsNullOrEmpty(FindComponent("TC33Books.dll")) ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuDatabaseCollectables.Visibility = string.IsNullOrEmpty(FindComponent("TC3Collectables.dll")) ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuDatabaseHobby.Visibility = string.IsNullOrEmpty(FindComponent("TC3Hobby.dll")) ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuDatabaseImages.Visibility = string.IsNullOrEmpty(FindComponent("TC3Images.dll")) ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuDatabaseMusic.Visibility = string.IsNullOrEmpty(FindComponent("TC3Music.dll")) ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuDatabaseSoftware.Visibility = string.IsNullOrEmpty(FindComponent("TC3Software.dll")) ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuDatabaseUSNavy.Visibility = string.IsNullOrEmpty(FindComponent("TC3USNavy.dll")) ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuDatabaseVideoLibrary.Visibility = string.IsNullOrEmpty(FindComponent("TC3VideoLibrary.dll")) ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuReportsDVDs.Visibility = !ReportExists("DVDs.rpt") ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuReportsHistory.Visibility = !ReportExists("History.rpt") ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuReportsKitsByLocation.Visibility = !ReportExists("KitsByLocation.rpt") ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuReportsKitsByStorage.Visibility = !ReportExists("KitsForStorage.rpt") ? Visibility.Collapsed : Visibility.Visible;
        //    this.MenuReportsWishList.Visibility = !ReportExists("WishList.rpt") ? Visibility.Collapsed : Visibility.Visible;
        //}
        private bool ReportExists(string ReportName)
        {
            return false;
           // return File.Exists($"{mTCBase.ReportsDirectory}\\{ReportName}");
        }
        //private void ShowMain()
        //{
        //    if (this.Top < 0 || this.Top > Screen.PrimaryScreen.Bounds.Height)
        //        this.Top = mTCBase.SaveTop;
        //    else
        //        mTCBase.SaveTop = this.Top;
        //    if (this.Left < 0 || this.Left > Screen.PrimaryScreen.Bounds.Width)
        //        this.Left = mTCBase.SaveLeft;
        //    else
        //        mTCBase.SaveLeft = this.Left;
        //    this.Text = mTCBase.SaveCaption;
        //    this.Icon = mTCBase.SaveIcon;
        //    this.Cursor = Cursors.Default;
        //    this.niMain.Visible = false;
        //    mTCBase.ActiveForm = this;
        //    this.Show();
        //}
        private void SimulateStatusBar()
        {
            sbpPosition.Text = "678 of 1,492"; sbpPosition.ToolTip = "Record Position"; 
            sbpMode.Text = " "; sbpMode.ToolTip = "Mode"; 
            sbpFilter.Text = "Filtered"; sbpFilter.ToolTip = "RowFilter: Format=\"Kindle\"";
            sbpSort.Text = "Sorted"; sbpSort.ToolTip = "Sort: Alphasort";
            //sbpMessage.Text = " "; sbpMessage.ToolTip = "Message";
            sbpStatus.Text = " "; sbpStatus.ToolTip = "Status";

            sbiPosition.Visibility = Visibility.Collapsed;
            sbiSep1.Visibility = Visibility.Collapsed;
            sbiMode.Visibility = Visibility.Collapsed;
            sbiSep2.Visibility = Visibility.Collapsed;
            sbiFilter.Visibility = Visibility.Collapsed;
            sbiSep3.Visibility = Visibility.Collapsed;
            sbiSort.Visibility = Visibility.Collapsed;
            sbiSep4.Visibility = Visibility.Collapsed;
            //sbiMessage.Visibility = Visibility.Collapsed;
            sbiStatus.Visibility = Visibility.Collapsed;
            sbiSep5.Visibility = Visibility.Collapsed;
        }
        #endregion
        #region "Event Handlers..."
        #region #Menu Event Handlers..."
        private void MenuFile_Click(object sender, RoutedEventArgs e)
        {
            string header = ((MenuItem)sender).Header.ToString().ToLower();
            switch (header)
            {
                case "e_xit":
                    this.Close();
                    break;
                case "_options":
                    //new WinOptions().ShowDialog();
                    break;
                default:
                    break;
            }
        }
        private void MenuDatabase_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            string header = ((MenuItem)sender).Header.ToString().ToLower();
            switch (header)
            {
                case "_books":
                    new WinBooks().ShowDialog();
                    break;
                case "_collectables":
                    //new WinCollectables().ShowDialog();
                    break;
                case "_kits":
                    //new WinKits().ShowDialog();
                    break;
                case "_decals":
                    //new WinDecals().ShowDialog();
                    break;
                case "_detail sets":
                    //new WinDetailSets().ShowDialog();
                    break;
                case "_finishing products":
                    //new WinFinishingProducts().ShowDialog();
                    break;
                case "_tools":
                    //new WinTools().ShowDialog();
                    break;
                case "_rockets":
                    //new WinRockets().ShowDialog();
                    break;
                case "_trains":
                    //new WinTrains().ShowDialog();
                    break;
                case "_companies":
                    //new WinCompanies().ShowDialog();
                    break;
                case "_aircraft designations":
                    //new WinAircraftDesignations().ShowDialog();
                    break;
                case "_blue angels history":
                    //new WinBlueAngelsHistory().ShowDialog();
                    break;
                case "_images":
                    //new WinImages().ShowDialog();
                    break;
                case "_music":
                    //new WinMusic().ShowDialog();
                    break;
                case "_software":
                    //new WinSoftware().ShowDialog();
                    break;
                case "_classes":
                    //new WinUSNavyClasses().ShowDialog();
                    break;
                case "_classifications":
                    //new WinUSNavyClassifications().ShowDialog();
                    break;
                case "_ships":
                    //new WinUSNavyShips().ShowDialog();
                    break;
                case "_movies":
                    //new WinMovies().ShowDialog();
                    break;
                case "_specials":
                    //new WinSpecials().ShowDialog();
                    break;
                case "_tv episodes":
                    //new WinTVEpisodes().ShowDialog();
                    break;
                default:
                    break;
            }
            this.Visibility = Visibility.Visible;
        }
        private void MenuReports_Click(object sender, RoutedEventArgs e)
        {
            string header = ((MenuItem)sender).Header.ToString().ToLower();
            switch (header)
            {
                case "_dvds":
                    //new WinReportsDVDs().ShowDialog();
                    break;
                case "_history":
                    //new WinReportsHistory().ShowDialog();
                    break;
                case "model kits by _location":
                    //new WinReportsModelKitsByLocation().ShowDialog();
                    break;
                case "model kits by _storage":
                    //new WinReportsModelKitsByStorage().ShowDialog();
                    break;
                case "_wishList":
                    //new WinReportsWishList().ShowDialog();
                    break;
                default:
                    break;
            }
        }
        private void MenuHelp_Click(object sender, RoutedEventArgs e)
        {
            string header = ((MenuItem)sender).Header.ToString().ToLower();
            if (header.StartsWith("_about"))
                new WinAbout().ShowDialog();
        }
        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            this.lblUserID.Text = this.lblUserID.Text == "KCLARK" ? "kfc12@comcast.net" : "KCLARK";
        }
        #endregion
        private void Timer_Tick(object sender, EventArgs e)
        {
            sbpTime.Text = DateTime.Now.ToShortTimeString();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !OKtoClose;
        }
        #endregion
    }
}
