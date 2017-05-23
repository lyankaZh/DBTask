using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Domain.Models;
using Domain.Repository;
using Library.ViewModels;

namespace Library.AddWindows
{
    public partial class AddNewPublisherWindow
    {
        readonly IUnitOfWork _unitOfWork;
        private CreatingBookViewModel viewModel;
        private int editedPublisherId;
        private OperationType operationType;

        public AddNewPublisherWindow(IUnitOfWork unitOfWork, CreatingBookViewModel model)
        {
            InitializeComponent();
            viewModel = model;
            _unitOfWork = unitOfWork;
            operationType = OperationType.Create;
        }

        public AddNewPublisherWindow(IUnitOfWork unitOfWork, CreatingBookViewModel model, Publisher publisher)
        {
            InitializeComponent();
            viewModel = model;
            _unitOfWork = unitOfWork;
            operationType = OperationType.Edit;
            editedPublisherId = publisher.PublisherId;
            publisherNameTextBox.Text = publisher.PublisherName;
            cityTextBox.Text = publisher.City;
            countryTextBox.Text = publisher.Country;

        }

        private void cancelButtonCopy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(publisherNameTextBox.Text) &&
                !string.IsNullOrEmpty(cityTextBox.Text) &&
                !string.IsNullOrEmpty(countryTextBox.Text))
            {
                var publisher = _unitOfWork.PublisherRepository
                    .Get()
                    .FirstOrDefault(x => x.PublisherName == publisherNameTextBox.Text && 
                    x.City == cityTextBox.Text && x.Country == countryTextBox.Text);
                if (publisher == null)
                {
                    if (operationType == OperationType.Create)
                    {
                        _unitOfWork.PublisherRepository.Insert(
                            new Publisher
                            {
                                PublisherName = publisherNameTextBox.Text,
                                City = cityTextBox.Text,
                                Country = countryTextBox.Text
                            }
                        );
                    }
                    else if (operationType == OperationType.Edit)
                    {
                        var editedPublisher = _unitOfWork.PublisherRepository.GetById(editedPublisherId);
                        if (editedPublisher != null)
                        {
                            editedPublisher.PublisherName = publisherNameTextBox.Text;
                            editedPublisher.City = cityTextBox.Text;
                            editedPublisher.Country = countryTextBox.Text;
                            _unitOfWork.PublisherRepository.Update(editedPublisher);
                        }
                    }
                    _unitOfWork.Save();
                    viewModel.Publishers = new ObservableCollection<Publisher>(_unitOfWork.PublisherRepository.Get().ToList());
                    Close();
                }
                else
                {
                    MessageBox.Show("Such publisher already exists!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect publisher!");
            }
        }
    }
}
