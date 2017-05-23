using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Domain.Models;
using Domain.Repository;
using Library.ViewModels;

namespace Library.AddWindows
{
    public partial class AddNewAuthorWindow : Window
    {
        IUnitOfWork _unitOfWork;
        private CreatingBookViewModel viewModel;
        private OperationType operationType;
        private int editAuthorId;

        public AddNewAuthorWindow(IUnitOfWork unitOfWork, CreatingBookViewModel model)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            viewModel = model;
            operationType = OperationType.Create;
        }

        public AddNewAuthorWindow(IUnitOfWork unitOfWork, CreatingBookViewModel model, Author author)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            viewModel = model;
            operationType = OperationType.Edit;
            editAuthorId = author.AuthorId;
            SetTextOnEditFields(author);
        }

        private void SetTextOnEditFields(Author author)
        {
            nameTextBox.Text = author.FirstName;
            surnameTextBox.Text = author.LastName;
            if (author.MiddleName != null)
            {
                middleNameTextBox.Text = author.MiddleName;
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(surnameTextBox.Text) && !string.IsNullOrEmpty(nameTextBox.Text))
            {
               
                    var author =new Author
                {
                    FirstName = nameTextBox.Text,
                    LastName = surnameTextBox.Text
                };
                if (!string.IsNullOrEmpty(middleNameTextBox.Text))
                {
                    author.MiddleName = middleNameTextBox.Text;
                }
                if (operationType == OperationType.Create)
                {
                    if (_unitOfWork.AuthorRepository.Get(x => x.FirstName == nameTextBox.Text
                                                         && x.LastName == surnameTextBox.Text &&
                                                         x.MiddleName == middleNameTextBox.Text).Any())
                    {
                        MessageBox.Show("Such author already exists");
                        return;
                    }
                    _unitOfWork.AuthorRepository.Insert(author);
                }
                else if (operationType == OperationType.Edit)
                {
                    var authorToEdit = _unitOfWork.AuthorRepository.GetById(editAuthorId);
                    if (authorToEdit != null)
                    {
                        authorToEdit.FirstName = author.FirstName;
                        authorToEdit.LastName = author.LastName;
                        if (authorToEdit.MiddleName != null)
                        {
                            authorToEdit.MiddleName = author.MiddleName;
                        }
                    }
                    
                }
                
                _unitOfWork.Save();

                viewModel.Authors = new ObservableCollection<Author>(_unitOfWork.AuthorRepository.Get().ToList());
                Close();
            }
            else
            {
                MessageBox.Show("Input correct author");
            }
        }
    }
}
