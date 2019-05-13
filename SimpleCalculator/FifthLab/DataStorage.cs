using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleCalculator.FifthLab
{
    /// <summary>
    /// Data storage class.
    /// </summary>
    public class DataStorage
    {
        /// <summary>
        /// GetNeededInformationAsynchronous method.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<User>> GetNeededInformationAsynchronous()
        {
            return await GetInformation();
        }

        /// <summary>
        /// GetInformation private method.
        /// </summary>
        /// <returns></returns>
        private Task<List<User>> GetInformation()
        {
            // Create an user.
            var fakeUser = new User();
            fakeUser.Id = new Guid();
            fakeUser.FirstName = "Best";
            fakeUser.SecondName = "Student";

            // Create collection of users.
            var fakeUsers = new List<User>();
            fakeUsers.Add(fakeUser);
            fakeUsers.Add(fakeUser);
            fakeUsers.Add(fakeUser);

            return Task.Run(() => fakeUsers); 
        }
    }
}
