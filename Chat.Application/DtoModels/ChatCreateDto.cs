using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Application.DtoModels;

public class ChatCreateDto
{
    public string Title { get; set; }
    public int UserId { get; set; }
}
