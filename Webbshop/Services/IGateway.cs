using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webbshop.ViewModels;

namespace Webbshop.Services
{
    public interface IGateway
    {
        PaymentResult ProcessPayment(CheckoutViewModel model);
    }
}