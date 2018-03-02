using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panta.Admin.Company.Models
{
    public class Settings
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }       
        public bool FollowStandartHolyDayClosingTime { get; set; } //if there is national day of, no booking can be made on that day, unless manualy changed 
        public bool RequireBookingConfirmationFromCompany { get; set; } //the company must confirm before the booking is actual
        public bool ReciveEmailOnBooking { get; set; } //the company recives email when customer makes booking
        public bool RequireCustomerPhoneNumberValidation { get; set; } //only allow customers that has verifyed by sms to make booking at the company
        public bool SendSMSReminderToCustomer { get; set; } //send SMS to the customer to remind him about his booking (same day ? day before? )
        public bool SendEmailReminderToCustomer { get; set; }//send Emal to the customer to remind him about his booking (same day ? day before ? )
        public bool BePubliclyExsposed { get; set; } //can the company be found and book via public chanels(our web and app), or only through URl (those who just use plugin)

    }
}