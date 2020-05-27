using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevIO.Api.Controllers
{
    [ApiController]    
    public abstract class MainController : ControllerBase
    {

        /**
         *   É classe de controller base, para ser usada nas demais controller. 
         * 
         * Conterá válidação de notificações de erro.
         * validação de model states
         * validação de operações.
         * **/
    }

}
