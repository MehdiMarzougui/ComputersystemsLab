using LibraryManager.BLL;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LibraryManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MemberLoanPage : Page
    {
        ObservableCollection<Loan> loans = new ObservableCollection<Loan>();
        public Member member { get; set; }
        
        public MemberLoanPage()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string && !string.IsNullOrWhiteSpace((string)e.Parameter))
            {
                string memberID = e.Parameter.ToString();

                member = MemberStore.Instance.GetMembersByID(memberID);

                ReloadLoans();
            }
            base.OnNavigatedTo(e);
        }

        private void Loan_Book_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BookListPage), member.id);
        }

        private void Loan_DVD_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DvdListPage), member.id);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LoansListView.SelectedIndex >= loans.Count || LoansListView.SelectedIndex < 0)
            {
                return;
            }
            Loan selectedloan = loans[LoansListView.SelectedIndex];
            DisplayLoanBookDialog(selectedloan);

        }

        private async void DisplayLoanBookDialog(Loan loan)
        {
            ContentDialog loanDialog = new ContentDialog
            {
                Title = $"Loan item",
                Content = $"Wolud you like to close the loan ending on {loan.dueToDate}?",
                PrimaryButtonText = "OK",
                CloseButtonText = "Cancel"
            };

            ContentDialogResult result = await loanDialog.ShowAsync();

            // Loan the book if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                LoanStore.Instance.CloseLoan(loan);
                ReloadLoans();
            }
            else
            {
                // The user clicked the CLoseButton, pressed ESC, Gamepad B, or the system back button.
                // Do nothing.
            }

        }

            private void ReloadLoans()
        {
            loans.Clear();
            foreach (var ln in LoanStore.Instance.GetLoansForMember(member))
                loans.Add(ln);
        }

        //TODO: Show Dialog method 


        public void Back_button_event(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MemberSearchPage));
        }
    }

    
}
