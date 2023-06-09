﻿using LibraryManager.BLL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LibraryManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MemberSearchPage : Page
    {
        //This will be presented in the list
        ObservableCollection<Member> members = new ObservableCollection<Member>();

        public MemberSearchPage()
        {
            this.InitializeComponent();
            LoadAllMembers();

            //We set the navigation cache mode -> the page will be chached while we are "away" from it.
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        //Loads all members
        private void LoadAllMembers()
        {
            members.Clear();
            foreach (var member in MemberStore.Instance.members)
            {
                members.Add(member);
            }
        }

        private void LoadMembers(string name = "", string id="", string nationality="", string DOB="")
        {
            members.Clear();
            IEnumerable<Member> filteredMembers = MemberStore.Instance.members;

            if (!string.IsNullOrWhiteSpace(name))
            {
                filteredMembers = filteredMembers.Where(member => member.name.Contains(name, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(nationality))
            {
                filteredMembers = filteredMembers.Where(member => member.nationality.Contains(nationality, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(DOB))
            {
                filteredMembers = filteredMembers.Where(member => member.DOB.Contains(DOB, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(id))
            {
                filteredMembers = filteredMembers.Where(member => member.id == id);
            }

            foreach (var member in filteredMembers)
            {
                members.Add(member);
            }
            
        }

        private void submitButtonClick(object sender, RoutedEventArgs e)
        {
            string name = Member_name.Text;
            string id = Member_id.Text;
            string nationality = Member_nationality.Text;
            string DOB = Member_DOB.Text;
            LoadMembers(name, id, nationality, DOB);
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MembersListView.SelectedIndex < 0)
            {
                return;
            }
            Member mb = members[MembersListView.SelectedIndex];

            this.Frame.Navigate(typeof(MemberLoanPage), mb.id);
        }
    }
}
