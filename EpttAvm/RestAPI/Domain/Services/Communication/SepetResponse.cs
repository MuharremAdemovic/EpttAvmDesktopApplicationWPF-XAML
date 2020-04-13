using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;

namespace RestAPI.Domain.Services.Communication
{
    public class SepetResponse : BaseResponse<Sepet>
    {
        public SepetResponse(Sepet sepet) : base(sepet) { }

        public SepetResponse(string message) : base(message) { }
    }
}
