using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Domain.Models;

namespace RestAPI.Domain.Services.Communication
{
    public class SliderResponse : BaseResponse<Slider>
    {
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="slider">Saved slider.</param>
        /// <returns>Response.</returns>
        public SliderResponse(Slider slider) : base(slider)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SliderResponse(string message) : base(message)
        { }
    }
}
