using Chat.Application.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Application.Interfaces;

public interface IChatService
{
    Task<ChatListDto> GetChats();
    Task<ChatDto> CreateChat(ChatCreateDto createDto);
    Task DeleteChat(ChatDeleteDto deleteDto);
    Task UpdateChat(ChatUpdateDto updateDto);
}
