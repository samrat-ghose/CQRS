﻿using System;

namespace BookARoom.Domain.WriteModel
{
    // TODO: find a better name following Vaughn VERNON's reco (I do something...) or keep the reference to repository to help people understanding?
    public interface IBookingRepository
    {
        Guid Save(BookARoomCommand bookingCommand);
    }
}