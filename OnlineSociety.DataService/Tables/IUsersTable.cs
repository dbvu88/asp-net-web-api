﻿using OnlineSociety.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSociety.DataService.Tables
{
    public interface IUsersTable
    {
        Task<IEnumerable<User>> GetUsersAsync(bool petsIncluded = false);
        Task<User> GetUserByNameAsync(string username);
        Task<IEnumerable<User>> GetUsersByBirthDateAsync(DateTime birthdate, bool petsIncluded = false);
    }

    public class UsersTable : IUsersTable
    {
        private readonly OnlineSocietyContext _context;

        public UsersTable(OnlineSocietyContext context)
        {
            this._context = context;
        }

        public async Task<User> GetUserByNameAsync(string name)
        {
            return await _context.Users
                .Include(c => c.Clan)
                .FirstOrDefaultAsync(t => t.Username == name);
        }

        public async Task<IEnumerable<User>> GetUsersAsync(bool petsIncluded = false)
        {
            var query = _context.Users.Include(c => c.Clan);

            if ( petsIncluded )
            {
                query.Include(c => c.Pets);
            }
            return await query.ToArrayAsync();
        }

        public async Task<IEnumerable<User>> GetUsersByBirthDateAsync(DateTime birthdate, bool petsIncluded = false)
        {
            var query = _context.Users.Include(c => c.Clan);

            if (petsIncluded)
            {
                query.Include(c => c.Pets);
            }
            return await query.Where(c => c.DateOfBirth == birthdate).ToArrayAsync();
        }
    }
}
