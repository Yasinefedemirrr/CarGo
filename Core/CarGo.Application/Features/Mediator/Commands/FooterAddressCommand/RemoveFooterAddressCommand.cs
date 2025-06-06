﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarGo.Application.Features.Mediator.Commands.FooterAddressCommand
{
    public class RemoveFooterAddressCommand :IRequest
    {
        public int Id { get; set; }

        public RemoveFooterAddressCommand(int id)
        {
            Id = id;
        }
    }
}
