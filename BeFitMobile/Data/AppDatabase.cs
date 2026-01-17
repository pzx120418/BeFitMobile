using SQLite;
using BeFitMobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeFitMobile.Data
{
    public class AppDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public AppDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<ExerciseType>().Wait();
            _database.CreateTableAsync<TrainingSession>().Wait();
            _database.CreateTableAsync<ExerciseInSession>().Wait();
        }

        // ExerciseType CRUD
        public Task<List<ExerciseType>> GetExerciseTypesAsync()
        {
            return _database.Table<ExerciseType>().ToListAsync();
        }

        public Task<int> SaveExerciseTypeAsync(ExerciseType exercise)
        {
            if (exercise.Id != 0)
                return _database.UpdateAsync(exercise);
            else
                return _database.InsertAsync(exercise);
        }

        public Task<int> DeleteExerciseTypeAsync(ExerciseType exercise)
        {
            return _database.DeleteAsync(exercise);
        }

        // TrainingSession CRUD
        public Task<List<TrainingSession>> GetTrainingSessionsAsync()
        {
            return _database.Table<TrainingSession>().ToListAsync();
        }

        public Task<int> SaveTrainingSessionAsync(TrainingSession session)
        {
            if (session.Id != 0)
                return _database.UpdateAsync(session);
            else
                return _database.InsertAsync(session);
        }

        public Task<int> DeleteTrainingSessionAsync(TrainingSession session)
        {
            return _database.DeleteAsync(session);
        }

        // ExerciseInSession CRUD
        public Task<List<ExerciseInSession>> GetExercisesInSessionAsync()
        {
            return _database.Table<ExerciseInSession>().ToListAsync();
        }

        public Task<int> SaveExerciseInSessionAsync(ExerciseInSession item)
        {
            if (item.Id != 0)
                return _database.UpdateAsync(item);
            else
                return _database.InsertAsync(item);
        }

        public Task<int> DeleteExerciseInSessionAsync(ExerciseInSession item)
        {
            return _database.DeleteAsync(item);
        }
    }
}
