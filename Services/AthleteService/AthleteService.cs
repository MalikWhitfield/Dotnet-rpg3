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
            serviceResponse.Data = _mapper.Map<AthleteDTO>(athlete);

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<AthleteDTO>>> Create(AddAthleteDTO newAthlete)
        {
            var serviceResponse = new ServiceResponse<List<AthleteDTO>>();

            _context.Add(_mapper.Map<Athlete>(newAthlete));
            await _context.SaveChangesAsync();

            serviceResponse.Data = _context.Athletes.Select(a => _mapper.Map<AthleteDTO>(a)).ToList();

            return serviceResponse;
        }


        public async Task<ServiceResponse<List<AthleteDTO>>> Delete(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<AthleteDTO>>();
            var athlete = await _context.Athletes.FirstOrDefaultAsync(a => a.AthleteId == id);

            _context.Athletes.Remove(athlete);
            await _context.SaveChangesAsync();

            serviceResponse.Data = _context.Athletes.Select(a => _mapper.Map<AthleteDTO>(a)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<AthleteDTO>> Update(UpdateAthleteDTO updateAthlete)
        {
            var serviceResponse = new ServiceResponse<AthleteDTO>();
            var athlete = await _context.Athletes.FirstOrDefaultAsync(a => a.AthleteId == updateAthlete.AthleteId);

            athlete.Bio = updateAthlete.Bio;
            athlete.Event = updateAthlete.Event;
            athlete.FirstName = updateAthlete.FirstName;
            athlete.LastName = updateAthlete.LAstName;
            athlete.Year = updateAthlete.Year;
            await _context.SaveChangesAsync();

            serviceResponse.Data = _mapper.Map<AthleteDTO>(athlete);


            return serviceResponse;
        }
    }
}