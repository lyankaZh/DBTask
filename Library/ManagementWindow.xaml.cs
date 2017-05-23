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
        private Book bookFromPreviousWindow;
        private BooksDisplayViewModel _booksDisplayViewModelToRemember;
        private OperationType _operationTypeToRemember;

        public ManagementWindow(IUnitOfWork unitOfWork, Book book, 
            BooksDisplayViewModel booksDisplayViewModelToRemember, OperationType operation)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            viewModel = new CreatingBookViewModel(_unitOfWork);
            DataContext = viewModel;
            bookFromPreviousWindow = book;
            _booksDisplayViewModelToRemember = booksDisplayViewModelToRemember;
            _operationTypeToRemember = operation;
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
            var messageBoxResult = MessageBox.Show("Are you sure? All books of this author will be deleted", "Delete Confirmation",
                MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                var author = authorsTable.SelectedItem as Author;
                if (author != null)
                {
                    var authorToDelete = _unitOfWork.AuthorRepository.GetById(author.AuthorId);
                    foreach (var book in _unitOfWork.BookRepository.Get())
                    {
                        if (book.Authors.Contains(author))
                        {
                            if (book.Authors.Count == 1)
                            {
                                _unitOfWork.BookRepository.Delete(book);
                            }
                            else
                            {
                                book.Authors.Remove(author);
                                _unitOfWork.BookRepository.Update(book);
                            }
                        }
                    }
                    _unitOfWork.AuthorRepository.Delete(authorToDelete);
                    _unitOfWork.Save();
                    viewModel.Authors =
                        new ObservableCollection<Author>(_unitOfWork.AuthorRepository.Get().ToList());
                }
            }
        }

        private void editGenreCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (genresTable != null)
            {
                var selectedItem = genresTable.SelectedItem;
                e.CanExecute = selectedItem != null;
            }
        }

        private void editGenreCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var genre = genresTable.SelectedItem as Genre;
            if (genre != null)
            {
                var genreCreatingWindow = new AddNewGenreWindow(_unitOfWork, viewModel, genre);
                genreCreatingWindow.ShowDialog();
                
            }
        }

        private void deleteGenreCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (genresTable != null)
            {
                var selectedItem = genresTable.SelectedItem;
                e.CanExecute = selectedItem != null;
            }
        }

        private void deleteGenreCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Are you sure? All books of this genres will be deleted!", "Delete Confirmation",
                MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                var genre = genresTable.SelectedItem as Genre;
                if (genre != null)
                {
                    var genreToDelete = _unitOfWork.GenreRepository.GetById(genre.GenreId);
                    foreach (var book in _unitOfWork.BookRepository.Get())
                    {
                        if (book.Genre == genreToDelete)
                        {
                            _unitOfWork.BookRepository.Delete(book);
                        }
                    }

                    _unitOfWork.GenreRepository.Delete(genreToDelete);
                    _unitOfWork.Save();
                    viewModel.Genres =
                        new ObservableCollection<Genre>(_unitOfWork.GenreRepository.Get().ToList());
                    
                }
            }
        }

        private void editLanguageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (languagesTable != null)
            {
                var selectedItem = languagesTable.SelectedItem;
                e.CanExecute = selectedItem != null;
            }
        }

        private void editLanguageCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var language = languagesTable.SelectedItem as Language;
            if (language != null)
            {
                var languageCreatingWindow = new AddNewLanguageWindow(_unitOfWork, viewModel, language);
                languageCreatingWindow.ShowDialog();

            }
        }

        private void deleteLanguageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (languagesTable != null)
            {
                var selectedItem = languagesTable.SelectedItem;
                e.CanExecute = selectedItem != null;
            }
        }

        private void deleteLanguageCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Are you sure? All books of this language will be deleted!", "Delete Confirmation",
                MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                var language = languagesTable.SelectedItem as Language;
                if (language != null)
                {
                    var languageToDelete = _unitOfWork.LanguageRepository.GetById(language.LanguageId);
                    foreach (var book in _unitOfWork.BookRepository.Get())
                    {
                        if (book.Language == languageToDelete)
                        {
                            _unitOfWork.BookRepository.Delete(book);
                        }
                    }

                    _unitOfWork.LanguageRepository.Delete(languageToDelete);
                    _unitOfWork.Save();
                    viewModel.Languages =
                        new ObservableCollection<Language>(_unitOfWork.LanguageRepository.Get().ToList());

                }
            }
        }

        private void editPublisherCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (publishersTable != null)
            {
                var selectedItem = publishersTable.SelectedItem;
                e.CanExecute = selectedItem != null;
            }
        }

        private void editPublisherCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var publisher = publishersTable.SelectedItem as Publisher;
            if (publisher != null)
            {
                var publisherCreatingWindow = new AddNewPublisherWindow(_unitOfWork, viewModel, publisher);
                publisherCreatingWindow.ShowDialog();

            }
        }

        private void deletePublisherCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (publishersTable != null)
            {
                var selectedItem = publishersTable.SelectedItem;
                e.CanExecute = selectedItem != null;
            }
        }

        private void deletePublisherCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Are you sure? All books of this publisher will be deleted!", "Delete Confirmation",
               MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                var publisher = publishersTable.SelectedItem as Publisher;
                if (publisher != null)
                {
                    var publisherToDelete = _unitOfWork.PublisherRepository.GetById(publisher.PublisherId);
                    foreach (var book in _unitOfWork.BookRepository.Get())
                    {
                        if (book.Publisher == publisherToDelete)
                        {
                            _unitOfWork.BookRepository.Delete(book);
                        }
                    }

                    _unitOfWork.PublisherRepository.Delete(publisherToDelete);
                    _unitOfWork.Save();
                    viewModel.Publishers =
                        new ObservableCollection<Publisher>(_unitOfWork.PublisherRepository.Get().ToList());

                }
            }
        }

        private void AddAuthorButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddNewAuthorWindow addNewAuthorWindow = new AddNewAuthorWindow(_unitOfWork, viewModel);
            addNewAuthorWindow.ShowDialog();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewBookWindow addNewBookWindow = new AddNewBookWindow(_unitOfWork, _booksDisplayViewModelToRemember,
                bookFromPreviousWindow, _operationTypeToRemember);
            addNewBookWindow.Show();
            Close();
        }

        private void AddGenreButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddNewGenreWindow addNewGenreWindow = new AddNewGenreWindow(
                _unitOfWork, viewModel);
            addNewGenreWindow.ShowDialog();

        }

        private void AddLanguageButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddNewLanguageWindow addNewLanguageWindow = new AddWindows.AddNewLanguageWindow(
                _unitOfWork, viewModel);
            addNewLanguageWindow.ShowDialog();
        }

        private void AddPublisherButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddNewPublisherWindow addNewPublisherWindow = new AddNewPublisherWindow(
                 _unitOfWork, viewModel);
            addNewPublisherWindow.ShowDialog();
        }
    }
}
