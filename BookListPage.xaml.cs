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


namespace LibraryManager
{

    public sealed partial class BookListPage : Page
    {
        public List<Book> books;

        //storing the member with whom the loan should be associated
        public Member selectedMember {get; set;}

        public BookListPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string && !string.IsNullOrWhiteSpace((string)e.Parameter))
            {
                string memberID = e.Parameter.ToString();

                selectedMember = MemberStore.Instance.GetMembersByID(memberID);
                books = new List<Book>();
                foreach(Book book in BookStore.Instance.books)
                {
                    if(book.isAvailable)
                    {
                        books.Add(book);
                        
                    }
                }
            }
            base.OnNavigatedTo(e);
        }


        

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Book selectedBook = books[BooksListView.SelectedIndex];
            DisplayLoanBookDialog(selectedBook);
        }


        private async void DisplayLoanBookDialog(Book book)
        {
            ContentDialog loanBookDialog = new ContentDialog
            {
                Title = $"Loan Book",
                Content = $"Wolud you like to loan the {book.title} book?",
                PrimaryButtonText = "OK",
                CloseButtonText = "Cancel"
            };

            ContentDialogResult result = await loanBookDialog.ShowAsync();

            // Loan the book if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                LoanStore.Instance.CreateNewLoan(selectedMember,book) ;
                this.Frame.Navigate(typeof(MemberLoanPage),selectedMember.id);

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
