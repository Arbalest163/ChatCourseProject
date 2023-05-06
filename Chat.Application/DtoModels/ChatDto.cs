using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Application.DtoModels
{
    public class ChatDto
    {
        public int ChatId { get; set; }
        public string Title { get; set; }
        public ICollection<UserDto> Users { get; set; }
        public ICollection<MessageDto> Messages { get; set; }
    }
}
