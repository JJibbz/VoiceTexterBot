using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiceTexterBot.Models;

namespace VoiceTexterBot.Services
{
    public interface IStorage
    {   
            ///<summary>
            ///Получение сессии пользователя по идентификатору
            /// </summary>
            Session GetSession(long chatId);
        
    }
}
