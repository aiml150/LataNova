﻿using API.Commands;
using API.Commands.Contracts;
using Core.Models;
using Infrastructure.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceOrderController : ControllerBase
    {
        private readonly IReadOnlyRepository<ServiceOrder> _serviceOrdeReadOnlyRepository;
        private readonly IWriteRepository<ServiceOrder> _serviceOrderWriteRepository;

        public ServiceOrderController(IReadOnlyRepository<ServiceOrder> serviceOrdeReadOnlyRepository, IWriteRepository<ServiceOrder> serviceOrderWriteRepository)
        {
            _serviceOrdeReadOnlyRepository = serviceOrdeReadOnlyRepository;
            _serviceOrderWriteRepository = serviceOrderWriteRepository;
        }

        [HttpGet]
        public IActionResult ServiceOrders()
        {
            return Ok(_serviceOrdeReadOnlyRepository.Get());
        }


        [HttpGet("{id}")]
        public IActionResult ServiceOrder(Guid id)
        {
            var obj = FindServiceOrder(id);
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult PostServiceOrder([FromBody] ServiceOrder serviceOrder)
        {
            _serviceOrderWriteRepository.Add(serviceOrder);

            return Ok(serviceOrder);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateServiceOrder(Guid id, [FromBody] ServiceOrder serviceOrder)
        {
            var obj = FindServiceOrder(id);

            obj.Quantity = serviceOrder.Quantity;
            _serviceOrderWriteRepository.Update(obj);

            return Ok(obj);
        }

        [HttpDelete]
        public IActionResult DeleteServiceOrder(Guid id)
        {

            if(new DeleteCommand<ServiceOrder>(id, _serviceOrderWriteRepository, _serviceOrdeReadOnlyRepository).Execute())
                return Ok();
            return NotFound();
        }

        private ServiceOrder FindServiceOrder(Guid id)
        {
            return _serviceOrdeReadOnlyRepository.Find(id);
        }
    }
}
