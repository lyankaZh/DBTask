using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Domain.Models;
using Domain.Repository;
using Library.ViewModels;

namespace Library.AddWindows
{
    public partial class AddNewGenreWindow: Window
    {
        readonly IUnitOfWork _unitOfWork;
        private readonly CreatingBookViewModel _creatingBookView;
        private OperationType operationType;
        private int editedGenreIndex;

        public AddNewGenreWindow(IUnitOfWork unitOfWork,CreatingBookViewModel viewModel)
        {
            InitializeComponent();
            _creatingBookView = viewModel;
            _unitOfWork = unitOfWork;
            operationType = OperationType.Create;
        }

        public AddNewGenreWindow(IUnitOfWork unitOfWork, CreatingBookViewModel viewModel,Genre genre)
        {
            InitializeComponent();
            _creatingBookView = viewModel;
            _unitOfWork = unitOfWork;
            editedGenreIndex = genre.GenreId;
            genreTextBox.Text = genre.GenreName;
            operationType = OperationType.Edit;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(genreTextBox.Text))
            {
                var genre = _unitOfWork.GenreRepository
                    .Get()
                    .FirstOrDefault(x => x.GenreName == genreTextBox.Text);
                if (genre == null)
                {
                    if (operationType == OperationType.Create)
                    {
                        _unitOfWork.GenreRepository.Insert(
                            new Genre
                            {
                                GenreName = genreTextBox.Text
                            });
                    }
                    else if (operationType == OperationType.Edit)
                    {
                        var genreToEdit = _unitOfWork.GenreRepository.GetById(editedGenreIndex);
                        if (genreToEdit != null)
                        {
                            genreToEdit.GenreName = genreTextBox.Text;
                            _unitOfWork.GenreRepository.Update(genreToEdit);
                        }
                    }

                    _unitOfWork.Save();
                    _creatingBookView.Genres = new ObservableCollection<Genre>(_unitOfWork.GenreRepository.Get().ToList());
                    Close();
                }
                else
                {
                    MessageBox.Show("Such genre already exists!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect genre");
            }
        }
    }
}
