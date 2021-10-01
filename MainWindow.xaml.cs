using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

namespace OSEmulator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }



        //private void users_Click(object sender, RoutedEventArgs e) {
        //    System.Diagnostics.Process process = new System.Diagnostics.Process();
        //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        //    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        //    process.StartInfo = new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\compmgmt.msc", "/s") {
        //        UseShellExecute = true
        //    };
        //    process.Start();
        //}

        //private void createUser_Click(object sender, RoutedEventArgs e) {
        //    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("CMD.exe", $"/C net user {user.Text} {pass.Text} /add") {
        //        CreateNoWindow = true
        //    });
        //}

        //private void deleteUser_Click(object sender, RoutedEventArgs e) {
        //    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("CMD.exe", $"/C net user {user.Text} /delete") {
        //        CreateNoWindow = true
        //    });
        //}

        //private void journalReload_Click(object sender, RoutedEventArgs e) {
        //    EventLog EventLog1 = new EventLog("Security");

        //    foreach (System.Diagnostics.EventLogEntry entry in EventLog1.Entries) {
        //        if (entry.Category == "(4624)" || entry.Category == "(4634)")
        //            logs.Text += (entry.Message);
        //    }


        //    //// Specify your source name and log name (e.g. Application, System or some custom name)
        //    //EventLog log = new EventLog() {
        //    //    Log = "Security"
        //    //};

        //    //// Enumerate through log entries
        //    //foreach (EventLogEntry entry in log.Entries) {
        //    //    // Do something with log entries
        //    //    logs.Text += (entry.Message);
        //    //}

        //    //// You also may filter log entries by date (LINQ is used for this)
        //    //foreach (EventLogEntry entry in log.Entries.Cast<EventLogEntry>().Where(x => (DateTime.Now - x.TimeGenerated).Days == 0)) {
        //    //    // Do something with log entries
        //    //    logs.Text += (entry.Message);
        //    //}
        //    //EventLog[] remoteEventLogs;
        //    //remoteEventLogs = EventLog.GetEventLogs();

        //    //foreach (EventLog log in remoteEventLogs) {
        //    //    logs.Text += ($"{logs.Text}: {log.Log} \n");
        //    //}
        //}
    }
}
