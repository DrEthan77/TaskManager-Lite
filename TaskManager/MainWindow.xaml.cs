using System;
using System.Collections.Generic;
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
//using System;
using System.Windows.Markup;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Timers;
using System.Net.NetworkInformation;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public List<Process> removed = new List<Process>();
        public Process[] localAll;
        public string[] unkillable = new string[] { };
        Timer updateTimer = new Timer();

        public void update(object source, ElapsedEventArgs e)
        {
            //MessageBox.Show("update");
            updateTimer.Interval = 2500;
            Dispatcher.Invoke(() =>
            {


                refresh();
                //close = false;
                //MessageBox.Show(close.ToString());

            });
        }
        public MainWindow()
        {

            localAll = Process.GetProcesses();
            InitializeComponent();
            Ping ping = new Ping();
            Console.WriteLine("start");

            //for (int i = 0; i < 5; i++)
            //{
            //    //ping.Send("10.0.6.11", 1, new byte[65499]);
            //    ping.SendAsync("98.138.252.38", 30, new object());
            //    ping.SendAsyncCancel();
            //    //if (reply.Status == IPStatus.Success)
            //    //{
            //    //    Console.WriteLine("Address: {0}", reply.Address.ToString());
            //    //    Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
            //    //    Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
            //    //    Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
            //    //    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
            //    //}
            //}
            //MessageBox.Show("done");
            //Process[] remoteAll = Process.GetProcesses("10.0.6.11");
            //MessageBox.Show(remoteAll.Length.ToString());

            //Process[] ipByName = Process.GetProcessesByName("Unity", "10.0.7.120");
            //MessageBox.Show(ipByName.ToString());
            this.Title = "Task Manager Lite";
            updateTimer.Elapsed += new ElapsedEventHandler(update);
            updateTimer.Interval = 2500;
            updateTimer.Enabled = true;
            refresh();
            //localAll.OrderByDescending()
            //for (int i = 0; i < localAll.Length; i++)
            //{
            //    //if (i == 0)
            //    //{
            //    //    MessageBox.Show(localAll[i].ProcessName);
            //    //}
            //    //string gridXaml = XamlWriter.Save(example);
            //    ////Load it into a new object:

            //    //StringReader stringReader = new StringReader(gridXaml);
            //    //XmlReader xmlReader = XmlReader.Create(stringReader);
            //    //Button newGrid = (Button)XamlReader.Load(xmlReader);
            //    Button bt = new Button();
            //    //(TextBlock)newGrid.Children[0].
            //    if (localAll[i].Responding)
            //        bt.Content = localAll[i].ProcessName + "|| PID:" + localAll[i].Id + "|| RAM:" + (localAll[i].WorkingSet64 / 1024 / 1024).ToString() + "MB";
            //    else
            //        bt.Content = "!NOT RESPONDING! " + localAll[i].ProcessName + "|| PID:" + localAll[i].Id + "|| RAM:" + (localAll[i].WorkingSet64 / 1024 / 1024).ToString() + "MB";
            //    //name.
            //    bt.Click += new RoutedEventHandler(endprocess_Click);
            //    bt.Tag = localAll[i].ProcessName + ":" + localAll[i].Id;
            //    //MessageBox.Show(GetChildOfType<Button>(newGrid).Tag.ToString());
            //    proccesspanel.Children.Add(bt);
            //}
        }
        public static T GetChildOfType<T>(DependencyObject depObj)
    where T : DependencyObject
        {
            if (depObj == null) return null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                var child = VisualTreeHelper.GetChild(depObj, i);

                var result = (child as T) ?? GetChildOfType<T>(child);
                if (result != null) return result;
            }
            return null;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //localAll
            List<string> templist = new List<string>();
            int temp = proccesspanel.Children.Count;
            for (int i = 0; i < temp; i++)
            {
                proccesspanel.Children.Remove(proccesspanel.Children[0]);
            }
            //localAll.OrderByDescending()
            refresh();
            //for (int i = 0; i < localAll.Length; i++)
            //{

            //    //string gridXaml = XamlWriter.Save(example);
            //    //StringReader stringReader = new StringReader(gridXaml);
            //    //XmlReader xmlReader = XmlReader.Create(stringReader);
            //    //Button newGrid = (Button)XamlReader.Load(xmlReader);
            //    Button bt = new Button();
            //    //if (GetChildOfType<TextBlock>(newGrid).Text.Contains(filter.Text))
            //    //(TextBlock)newGrid.Children[0].
            //    if (localAll[i].ProcessName.ToLower().Contains(filter.Text.ToLower()))
            //    {
            //        if (localAll[i].Responding)
            //            bt.Content = localAll[i].ProcessName + "|| PID:" + localAll[i].Id + "|| RAM:" + (localAll[i].WorkingSet64 / 1024 / 1024).ToString() + "MB";
            //        else
            //            bt.Content = "!NOT RESPONDING! " + localAll[i].ProcessName + "|| PID:" + localAll[i].Id + "|| RAM:" + (localAll[i].WorkingSet64 / 1024 / 1024).ToString() + "MB";

            //        //name.
            //        bt.Click += new RoutedEventHandler(endprocess_Click);
            //        bt.Tag = localAll[i].ProcessName + ":" + localAll[i].Id;
            //        //MessageBox.Show(GetChildOfType<Button>(newGrid).Tag.ToString());
            //        proccesspanel.Children.Add(bt);
            //    }
            //}
        }

        private void endprocess_Click(object sender, RoutedEventArgs e)
        {
            string untempered = string.Format("{0}", (sender as Button).Tag);

            string name = untempered.Remove(untempered.IndexOf(":"));
            string PID = untempered.Remove(0, untempered.IndexOf(":") + 1);

            if (!localAll[findindex(PID)].HasExited)
            {

                //string PID = untempered.Remove(0, untempered.IndexOf(":") + 1);
                //MessageBox.Show((untempered.Length - 1).ToString());
                //string id = untempered.Remove(untempered.IndexOf(" "), untempered.Length - untempered.IndexOf(" "));
                //string tag = untempered.Remove(0, untempered.IndexOf(" ") + 1);
                //TextReader tr = new StreamReader(tag);
                //string name = tr.ReadLine();
                //tr.Close();
                //MessageBox.Show(untempered);
                switch (MessageBox.Show("End the " + name + " process? \n (You will most likely lose any unsaved work you have created)", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Question))
                {
                    case (MessageBoxResult.OK):
                        if (findindex(PID) == -1)
                        {
                            MessageBox.Show("There was an error contact the admin(" + PID + ")", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            localAll[findindex(PID)].Kill();
                            //WaitForChangedResult;
                            updateTimer.Interval = 100;
                            //localAll[0].Exited
                            removed.Add(localAll[findindex(PID)]);
                            int index = findindex(PID);
                            for (int i = 0; i < localAll.Count(); i++)
                            {
                                if (localAll[i].ProcessName.Contains(localAll[index].ProcessName))
                                {
                                    bool quitted = false;
                                    try
                                    {
                                        quitted = localAll[i].HasExited;
                                    }
                                    catch (Exception e2)
                                    {
                                        Console.WriteLine(e2.Message);
                                    }
                                    if (quitted)
                                        removed.Add(localAll[i]);
                                    //refresh();
                                }
                            }

                            refresh();
                            //filter.Text = "";
                        }
                        //File.Delete(tag);
                        //notificationpanel.Children.Remove(sender as Button);
                        //TextReader tr1 = new StreamReader("..\\..\\Intranet\\me\\UserInfo.txt");
                        //string username = MainWindow.Decrypt(tr1.ReadLine(), 6);
                        //tr1.Close();
                        //Directory.CreateDirectory("Users\\" + username + "\\Friends");
                        //File.SetAttributes("Users\\" + username + "\\Friends", FileAttributes.Hidden);
                        //TextWriter tw = new StreamWriter("Users\\" + username + "\\Friends\\" + name + ".txt");
                        //tw.WriteLine(MainWindow.Encrypt(name, 3));
                        //tw.Close();
                        break;
                    case (MessageBoxResult.Cancel):

                        break;
                }
            }
            else
            {
                removed.Add(localAll[findindex(PID)]);
                refresh();
                MessageBox.Show("That Process is already quitting.", "Notification", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        public int findindex(string pid)
        {
            for (int i = 0; i < localAll.Length; i++)
            {
                if (localAll[i].Id.ToString() == pid)
                {
                    return i;
                }
            }
            return -1;
        }
        public void refresh()
        {
            localAll = Process.GetProcesses();

            List<string> templist = new List<string>();
            int temp = proccesspanel.Children.Count;
            for (int i = 0; i < temp; i++)
            {
                proccesspanel.Children.Remove(proccesspanel.Children[0]);
            }
            for (int i = 0; i < localAll.Length; i++)
            {

                if (!removed.Contains(localAll[i]) && !unkillable.Contains(localAll[i].ProcessName.ToLower()))
                {
                    //if (!localAll[i].HasExited)
                    //{
                    //bool quitted = false;
                    //try
                    //{
                    //    quitted = localAll[i].HasExited;
                    //}
                    //catch (Exception e)
                    //{
                    //    //Console.WriteLine(e.Message);
                    //}
                    //string gridXaml = XamlWriter.Save(example);
                    //StringReader stringReader = new StringReader(gridXaml);
                    //XmlReader xmlReader = XmlReader.Create(stringReader);
                    //Button newGrid = (Button)XamlReader.Load(xmlReader);

                    Button bt = new Button();
                    //if (GetChildOfType<TextBlock>(newGrid).Text.Contains(filter.Text))
                    //(TextBlock)newGrid.Children[0].
                    //if (!quitted)
                    //{
                    if (localAll[i].ProcessName.ToLower().Contains(filter.Text.ToLower()))
                    {
                        if (localAll[i].Responding)
                            bt.Content = localAll[i].ProcessName + "|| PID:" + localAll[i].Id + "|| RAM:" + (localAll[i].WorkingSet64 / 1024 / 1024).ToString() + "MB";
                        else
                            bt.Content = "!NOT RESPONDING! " + localAll[i].ProcessName + "|| PID:" + localAll[i].Id + "|| RAM:" + (localAll[i].WorkingSet64 / 1024 / 1024).ToString() + "MB";
                        //name.
                        bt.Click += new RoutedEventHandler(endprocess_Click);
                        bt.Tag = localAll[i].ProcessName + ":" + localAll[i].Id;
                        //MessageBox.Show(GetChildOfType<Button>(newGrid).Tag.ToString());
                        if (removed.Count > 0 && localAll[i].Id == removed[0].Id)
                        {
                            removed.Remove(localAll[i]);
                        }
                        else
                        {
                            proccesspanel.Children.Add(bt);
                        }
                    }
                }

            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            refresh();
        }
    }
}
