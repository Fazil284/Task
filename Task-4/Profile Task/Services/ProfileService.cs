using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task4.Models;

namespace Task4.Services
{
    public class ProfileService : IProfile<Prof>
    {
        private ProfContext _context;
        private ILogger<ProfileService> _logger;

        public ProfileService(ProfContext context, ILogger<ProfileService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add(Prof t)
        {
            try
            {
                _context.Profs.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                throw;
            }
        }

        public Prof Get(int id)
        {
            try
            {
                Prof profile = _context.Profs.FirstOrDefault(a => a.Id == id);
                return profile;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public IEnumerable<Prof> GetAll()
        {
            try
            {
                if (_context.Profs.Count() == 0)
                    return null;
                return _context.Profs.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
    }
}