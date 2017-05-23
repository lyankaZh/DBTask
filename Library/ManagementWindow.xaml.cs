using System.Windows;
using System.Windows.Input;
using Domain.Repository;

namespace Library
{
    public partial class ManagementWindow : Window
    {
        IUnitOfWork _unitOfWork;
        public ManagementWindow(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }


        private void editAuthorCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
        //    if (booksTable != null)
        //    {
        //        var selectedItem = booksTable.SelectedItem;
        //        e.CanExecute = selectedItem != null;
        //    }
        }

        private void editAuthorCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //EditBook();
        }

        private void deleteAuthorCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //if (booksTable != null)
            //{
            //    var selectedItem = booksTable.SelectedItem;
            //    e.CanExecute = selectedItem != null;
            //}
        }

        private void deleteAuthorCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //var messageBoxResult = MessageBox.Show("Are you sure?", "Delete Confirmation",
            //    MessageBoxButton.YesNo);
            //if (messageBoxResult == MessageBoxResult.Yes)
            //{
            //    DeleteBook();
            //}
        }

        private void editGenreCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //    if (booksTable != null)
            //    {
            //        var selectedItem = booksTable.SelectedItem;
            //        e.CanExecute = selectedItem != null;
            //    }
        }

        private void editGenreCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //EditBook();
        }

        private void deleteGenreCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //if (booksTable != null)
            //{
            //    var selectedItem = booksTable.SelectedItem;
            //    e.CanExecute = selectedItem != null;
            //}
        }

        private void deleteGenreCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //var messageBoxResult = MessageBox.Show("Are you sure?", "Delete Confirmation",
            //    MessageBoxButton.YesNo);
            //if (messageBoxResult == MessageBoxResult.Yes)
            //{
            //    DeleteBook();
            //}
        }

        private void editLanguageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //    if (booksTable != null)
            //    {
            //        var selectedItem = booksTable.SelectedItem;
            //        e.CanExecute = selectedItem != null;
            //    }
        }

        private void editLanguageCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //EditBook();
        }

        private void deleteLanguageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //if (booksTable != null)
            //{
            //    var selectedItem = booksTable.SelectedItem;
            //    e.CanExecute = selectedItem != null;
            //}
        }

        private void deleteLanguageCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //var messageBoxResult = MessageBox.Show("Are you sure?", "Delete Confirmation",
            //    MessageBoxButton.YesNo);
            //if (messageBoxResult == MessageBoxResult.Yes)
            //{
            //    DeleteBook();
            //}
        }

        private void editPublisherCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //    if (booksTable != null)
            //    {
            //        var selectedItem = booksTable.SelectedItem;
            //        e.CanExecute = selectedItem != null;
            //    }
        }

        private void editPublisherCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //EditBook();
        }

        private void deletePublisherCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //if (booksTable != null)
            //{
            //    var selectedItem = booksTable.SelectedItem;
            //    e.CanExecute = selectedItem != null;
            //}
        }

        private void deletePublisherCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //var messageBoxResult = MessageBox.Show("Are you sure?", "Delete Confirmation",
            //    MessageBoxButton.YesNo);
            //if (messageBoxResult == MessageBoxResult.Yes)
            //{
            //    DeleteBook();
            //}
        }
    }
}
