using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Domain.Models;
using Domain.Repository;
using Library.ViewModels;

namespace Library.AddWindows
{
    public partial class AddNewLanguageWindow: Window
    {
        private readonly IUnitOfWork _unitOfWork;
        private CreatingBookViewModel viewModel;
        private int editedLanguageId;
        private OperationType _operationType;

        public AddNewLanguageWindow( IUnitOfWork unitOfWork, CreatingBookViewModel model)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            viewModel = model;
            _operationType = OperationType.Create;
        }


        public AddNewLanguageWindow(IUnitOfWork unitOfWork, CreatingBookViewModel model, Language language)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            viewModel = model;
            _operationType = OperationType.Edit;
            editedLanguageId = language.LanguageId;
            languageTextBox.Text = language.LanguageName;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(languageTextBox.Text))
            {
                var language = _unitOfWork.LanguageRepository
                    .Get()
                    .FirstOrDefault(x => x.LanguageName == languageTextBox.Text);
                if (language == null)
                {
                    if (_operationType == OperationType.Create)
                    {
                        _unitOfWork.LanguageRepository.Insert(
                            new Language {LanguageName = languageTextBox.Text});
                    }
                    else if(_operationType == OperationType.Edit)
                    {
                        var editedLanguage = _unitOfWork.LanguageRepository.GetById(editedLanguageId);
                        if (editedLanguage != null)
                        {
                            editedLanguage.LanguageName = languageTextBox.Text;
                            _unitOfWork.LanguageRepository.Update(editedLanguage);
                        }

                    }


                    _unitOfWork.Save();
                    viewModel.Languages = new ObservableCollection<Language>(_unitOfWork.LanguageRepository.Get().ToList()); 
                    Close();
                }
                else
                {
                    MessageBox.Show("Such lahguage alredy exists");
                }
            }
            else
            {
                MessageBox.Show("Incorrect language!");
            }
        }
    }
}
