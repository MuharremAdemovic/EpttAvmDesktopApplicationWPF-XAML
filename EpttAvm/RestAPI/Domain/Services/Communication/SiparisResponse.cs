using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;

namespace RestAPI.Domain.Services.Communication
{
    public class SiparisResponse : BaseResponse<Siparis>
    {
        public SiparisResponse(Siparis siparis) : base(siparis) { }

        public SiparisResponse(string message) : base(message) { }
    }
}
