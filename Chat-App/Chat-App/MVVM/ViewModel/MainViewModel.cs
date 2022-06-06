using Chat_App.Core;
using Chat_App.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands*/
        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set 
            { 
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        private string _message { get; set; }
        public string Message
        {
            get { return _message; }
            set 
            { 
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    TheFirstMessage = false,
                });

                Message = "";

            });


            Messages.Add(new MessageModel()
            {
                UserName = "Tomek",
                UserNameColor = "#409aff",
                ImageSource = "https://cdn.icon-icons.com/icons2/2643/PNG/512/male_boy_person_people_avatar_icon_159358.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                TheFirstMessage = true
            });

            for (int i = 0; i < 2; i++)
            {
                Messages.Add(new MessageModel()
                {
                    UserName = "Tomek",
                    UserNameColor = "#409aff",
                    ImageSource = "https://cdn.icon-icons.com/icons2/2643/PNG/512/male_boy_person_people_avatar_icon_159358.png",
                    Message = "Jestem Tomek",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    TheFirstMessage = false
                });
            }

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel()
                {
                    UserName = "Romek",
                    UserNameColor = "#409aff",
                    ImageSource = "https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg",
                    Message = "A ja Romek",
                    Time = DateTime.Now,
                    IsNativeOrigin = true
                });
            }

            Messages.Add(new MessageModel()
            {
                UserName = "Tomek",
                UserNameColor = "#409aff",
                ImageSource = "https://cdn.icon-icons.com/icons2/2643/PNG/512/male_boy_person_people_avatar_icon_159358.png",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

          
            Contacts.Add(new ContactModel
            {
                UserName = $"Tomek",
                ImageSource = "https://cdn.icon-icons.com/icons2/2643/PNG/512/male_boy_person_people_avatar_icon_159358.png",
                Messages = Messages
            });


            Contacts.Add(new ContactModel
            {
                UserName = $"Romek",
                ImageSource = "https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg",
                Messages = Messages
            });

        }
    }
}
