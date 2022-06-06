using Chat_App.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.MVVM.ViewModel
{
    internal class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel()
            {
                UserName = "Tomek",
                UserNameColor = "#409aff",
                ImageSource = "https://media.istockphoto.com/photos/businessman-silhouette-as-avatar-or-default-profile-picture-picture-id476085198?b=1&k=20&m=476085198&s=170667a&w=0&h=Ct4e1kIOdCOrEgvsQg4A1qeuQv944pPFORUQcaGw4oI=",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                TheFirstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel()
                {
                    UserName = "Tomek",
                    UserNameColor = "#409aff",
                    ImageSource = "https://media.istockphoto.com/photos/businessman-silhouette-as-avatar-or-default-profile-picture-picture-id476085198?b=1&k=20&m=476085198&s=170667a&w=0&h=Ct4e1kIOdCOrEgvsQg4A1qeuQv944pPFORUQcaGw4oI=",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    TheFirstMessage = false
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel()
                {
                    UserName = "Romek",
                    UserNameColor = "#409aff",
                    ImageSource = "https://media.istockphoto.com/photos/businessman-silhouette-as-avatar-or-default-profile-picture-picture-id476085198?b=1&k=20&m=476085198&s=170667a&w=0&h=Ct4e1kIOdCOrEgvsQg4A1qeuQv944pPFORUQcaGw4oI=",
                    Message = "Test dla Romka",
                    Time = DateTime.Now,
                    IsNativeOrigin = true
                });
            }

            Messages.Add(new MessageModel()
            {
                UserName = "Tomek",
                UserNameColor = "#409aff",
                ImageSource = "https://media.istockphoto.com/photos/businessman-silhouette-as-avatar-or-default-profile-picture-picture-id476085198?b=1&k=20&m=476085198&s=170667a&w=0&h=Ct4e1kIOdCOrEgvsQg4A1qeuQv944pPFORUQcaGw4oI=",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    UserName = $"Tomek {i}",
                    ImageSource = "https://media.istockphoto.com/photos/businessman-silhouette-as-avatar-or-default-profile-picture-picture-id476085198?b=1&k=20&m=476085198&s=170667a&w=0&h=Ct4e1kIOdCOrEgvsQg4A1qeuQv944pPFORUQcaGw4oI=",
                    Messages = Messages
                });
            }

        }
    }
}
