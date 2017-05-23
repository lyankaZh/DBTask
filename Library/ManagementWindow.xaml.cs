using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Domain.Models;
using Domain.Repository;
using Library.AddWindows;
using Library.ViewModels;

namespace Library
{
    public partial class ManagementWindow : Window
    {
        IUnitOfWork _unitOfWork;
        private CreatingBookViewModel viewModel;
        public ManagementWindow(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            viewModel = new CreatingBookViewModel(_unitOfWork);
            DataContext = viewModel;
        }


        private void editAuthorCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (authorsTable != null)
            {
                var selectedItem = authorsTable.SelectedItem;
                e.CanExecute = selectedItem != null;
            }
        }

        private void editAuthorCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var author = authorsTable.SelectedItem as Author;
            if (author != null)
            {
                var authorCreatingWindow = new AddNewAuthorWindow(_unitOfWork, viewModel, author);
                authorCreatingWindow.ShowDialog();
            }
        }

        private void deleteAuthorCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (authorsTable != null)
            {
                var selectedItem = authorsTable.SelectedItem;
                e.CanExecute = selectedItem != null;
            }
        }

        private void deleteAuthorCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Are you sure?", "Delete Confirmation",
                MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                var author = authorsTable.SelectedItem as Author;
                if (author != null)
                {
                    var authorToDelete = _unitOfWork.AuthorRepository.GetById(author.AuthorId);
                    _unitOfWork.AuthorRepository.Delete(authorToDelete);
                    _unitOfWork.Save();
                    viewModel.Authors =
                        new ObservableCollection<Author>(_unitOfWork.AuthorRepository.Get().ToList());
                }
            }
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

        private void AddAuthorButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddNewAuthorWindow addNewAuthorWindow = new AddNewAuthorWindow(_unitOfWork, viewModel);
            addNewAuthorWindow.ShowDialog();
        }
    }
}
