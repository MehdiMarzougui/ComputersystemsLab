using LibraryManager.BLL;
using System;
using System.Collections.Generic;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LibraryManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DvdListPage : Page
    {
        public List<DVD> DVDs;

        //storing the member with whom the loan should be associated
        public Member selectedMember { get; set; }

        public DvdListPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string && !string.IsNullOrWhiteSpace((string)e.Parameter))
            {
                string memberID = e.Parameter.ToString();

                selectedMember = MemberStore.Instance.GetMembersByID(memberID);
                DVDs = new List<DVD>();
                foreach (DVD DVD in DVDStore.Instance.DVDs)
                {
                    if (DVD.isAvailable)
                    {
                        DVDs.Add(DVD);

                    }
                }
            }
            base.OnNavigatedTo(e);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DVD selectedDVD = DVDs[DVDsListView.SelectedIndex];
            DisplayLoanDVDialog(selectedDVD);
        }

        //TODO: LoanBook

        private async void DisplayLoanDVDialog(DVD DVD)
        {
            ContentDialog loanBookDialog = new ContentDialog
            {
                Title = $"Loan Book",
                Content = $"Wolud you like to loan the {DVD.title} DVD?",
                PrimaryButtonText = "OK",
                CloseButtonText = "Cancel"
            };

            ContentDialogResult result = await loanBookDialog.ShowAsync();

            // Loan the book if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                LoanStore.Instance.CreateNewLoan(selectedMember, DVD);
                this.Frame.Navigate(typeof(MemberLoanPage), selectedMember.id);

            }
            else
            {
                // The user clicked the CLoseButton, pressed ESC, Gamepad B, or the system back button.
                // Do nothing.
            }


        }
        public void Back_button_event(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MemberLoanPage), selectedMember.id);
        }
    }
}
