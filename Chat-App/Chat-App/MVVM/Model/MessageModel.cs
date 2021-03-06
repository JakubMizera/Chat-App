using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.MVVM.Model
{
    class MessageModel
    {
        public string UserName { get; set; }
        public string UserNameColor { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }
        public bool? TheFirstMessage { get; set; }
    }
}
