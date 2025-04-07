﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarGo.Application.Features.CQRS.Commands.ContactCommands;
using CarGo.Application.interfaces;
using Cargo.Domain.Entities;

namespace CarGo.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateContactCommand command)
        {
            await _repository.CreateAsync(new Contact
            {
               Name = command.Name,
               Subject = command.Subject,
               SendDate = command.SendDate,
               Message = command.Message,
                Email = command.Email,
            });
        }
    }
}
