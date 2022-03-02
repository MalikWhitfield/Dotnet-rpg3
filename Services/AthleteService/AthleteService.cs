using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Threading.Tasks;
using System.Linq;
using Dotnet_rpg3.DTOs.Athlete;
using System;
using AutoMapper;
using Dotnet_rpg3.Data;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_rpg3.Services.AthleteService
{
    public class AthleteService : IAthleteService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public AthleteService(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<ServiceResponse<List<AthleteDTO>>> GetAll()
        {
            var athletes = await _context.Athletes.ToListAsync();
            var serviceResponse = new ServiceResponse<List<AthleteDTO>>();
            serviceResponse.Data = athletes.Select(a => _mapper.Map<AthleteDTO>(a)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<AthleteDTO>> GetById(Guid id)
        {
            var serviceResponse = new ServiceResponse<AthleteDTO>();
            var athlete = await _context.Athletes.FirstOrDefaultAsync(a => a.AthleteId == id);
            // serviceResponse.Data = Athletes.FirstOrDefault(c => c.AthleteId == id);

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<AthleteDTO>>> Create(AddAthleteDTO newAthlete)
        {
            var serviceResponse = new ServiceResponse<List<AthleteDTO>>();
            // Athletes.Add(newAthlete);

            // serviceResponse.Data = Athletes;

            return serviceResponse;
        }


        public async Task<ServiceResponse<List<AthleteDTO>>> Delete(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<AthleteDTO>>();
            // serviceResponse.Data = Athletes;

            return serviceResponse;
        }
    }
}