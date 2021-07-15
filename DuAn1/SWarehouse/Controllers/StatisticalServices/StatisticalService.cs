using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWarehouse.Utilities;

namespace SWarehouse.Controllers.StatisticalServices
{
    class StatisticalService : IStatisticalService
    {
        SWareDBEntities _db = new SWareDBEntities();
        public Task<List<SP_CountProReceivedByNameInQuarter_Result>>
            GetCountProReceivedByNameInQuarter_Results()
        {
            try
            {
                var data = _db.SP_CountProReceivedByNameInQuarter();
                List<SP_CountProReceivedByNameInQuarter_Result> result = new List<SP_CountProReceivedByNameInQuarter_Result>();
                if (data != null)
                {
                    foreach (SP_CountProReceivedByNameInQuarter_Result item in data)
                        result.Add(item);
                    return Task.FromResult(result);
                }
                return Task.FromResult(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<List<SP_CountProReceivedByNameInWeek_Result>> GetCountProReceivedByNameInWeek_Results()
        {
            try
            {
                var data = _db.SP_CountProReceivedByNameInWeek();
                List<SP_CountProReceivedByNameInWeek_Result> result = new List<SP_CountProReceivedByNameInWeek_Result>();
                if (data != null)
                {
                    foreach (SP_CountProReceivedByNameInWeek_Result item in data)
                        result.Add(item);
                    return Task.FromResult(result);
                }
                return Task.FromResult(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Task<List<SP_CountProReceivedByNameInMonth_Result>> GetCountProReceivedByNameInMonth_Results()
        {
            try
            {
                var data = _db.SP_CountProReceivedByNameInMonth();
                List<SP_CountProReceivedByNameInMonth_Result> result = new List<SP_CountProReceivedByNameInMonth_Result>();
                if (data != null)
                {
                    foreach (SP_CountProReceivedByNameInMonth_Result item in data)
                        result.Add(item);
                    return Task.FromResult(result);
                }
                return Task.FromResult(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Task<List<SP_GetMoneyOutByGRNInMonth_Result>> getMoneyOutByGRNInMonth_Result()
        {
            try
            {
                var data = _db.SP_GetMoneyOutByGRNInMonth();
                List<SP_GetMoneyOutByGRNInMonth_Result> result = new List<SP_GetMoneyOutByGRNInMonth_Result>();
                if (data != null)
                {
                    foreach (SP_GetMoneyOutByGRNInMonth_Result item in data)
                        result.Add(item);
                    return Task.FromResult(result);
                }
                return Task.FromResult(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Task<List<SP_GetInMoneyByOrderInMonth_Result>> getInMoneyByOrderInMonth_Results()
        {
            try
            {
                var data = _db.SP_GetInMoneyByOrderInMonth();
                List<SP_GetInMoneyByOrderInMonth_Result> resultssss = new List<SP_GetInMoneyByOrderInMonth_Result>();
                if (data != null)
                {
                    foreach (SP_GetInMoneyByOrderInMonth_Result item in data)
                        resultssss.Add(item);
                    return Task.FromResult(resultssss);
                }
                return Task.FromResult(resultssss);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Task<List<SP_GetMoneyOutByGRNInQuarter_Result>> getMoneyOutByGRNInQuarter_Results()
        {
            try
            {
                var data = _db.SP_GetMoneyOutByGRNInQuarter();
                List<SP_GetMoneyOutByGRNInQuarter_Result> resultsss = new List<SP_GetMoneyOutByGRNInQuarter_Result>();
                if (data != null)
                {
                    foreach (SP_GetMoneyOutByGRNInQuarter_Result item in data)
                        resultsss.Add(item);
                    return Task.FromResult(resultsss);
                }
                return Task.FromResult(resultsss);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<List<SP_GetMoneyOutByGRNInWeek_Result>> getMoneyOutByGRNInWeek_Results()
        {
            try
            {
                var data = _db.SP_GetMoneyOutByGRNInWeek();
                List<SP_GetMoneyOutByGRNInWeek_Result> results = new List<SP_GetMoneyOutByGRNInWeek_Result>();
                if (data != null)
                {
                    foreach (SP_GetMoneyOutByGRNInWeek_Result item in data)
                        results.Add(item);
                    return Task.FromResult(results);
                }
                return Task.FromResult(results);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Task<List<SP_GetInMoneyByOrderInMonth_Result>> getMoneyOrderInMonth()
        {
            try
            {
                var data = _db.SP_GetInMoneyByOrderInMonth();
                List<SP_GetInMoneyByOrderInMonth_Result> result = new List<SP_GetInMoneyByOrderInMonth_Result>();
                if (data != null)
                {
                    foreach (SP_GetInMoneyByOrderInMonth_Result item in data)
                        result.Add(item);
                    return Task.FromResult(result);
                }
                return Task.FromResult(result);
            }
            catch
            {
                throw;
            }
        }

        public Task<List<SP_GetInMoneyByOrderInWeek_Result>> getMoneyOrderInWeek()
        {
            var data = _db.SP_GetInMoneyByOrderInWeek();
            List<SP_GetInMoneyByOrderInWeek_Result> result = new List<SP_GetInMoneyByOrderInWeek_Result>();
            if (data != null)
            {
                foreach (var item in data)
                    result.Add(item);
                return Task.FromResult(result);

            }
            return Task.FromResult(result);
        }
        public Task<List<SP_GetInMoneyByOrderInQuarter_Result>> getMoneyOrderInQuarter()
        {
            try
            {
                var data = _db.SP_GetInMoneyByOrderInQuarter();
                List<SP_GetInMoneyByOrderInQuarter_Result> result = new List<SP_GetInMoneyByOrderInQuarter_Result>();
                if (data != null)
                {
                    foreach (SP_GetInMoneyByOrderInQuarter_Result item in data)
                        result.Add(item);
                    return Task.FromResult(result);
                }
                return Task.FromResult(result);
            }
            catch
            {
                throw;
            }
        }
        public Task<List<SP_GetProductOutInDay_Result>> getProductOutInDay()
        {
            var data = _db.SP_GetProductOutInDay();
            List<SP_GetProductOutInDay_Result> result = new List<SP_GetProductOutInDay_Result>();
            if (data != null)
            {
                foreach (SP_GetProductOutInDay_Result item in data)
                    result.Add(item);
                return Task.FromResult(result);
            }
            return Task.FromResult(result);
        }
        public Task<List<SP_GetProductOutInMonth_Result>> getProductOutInMonth()
        {
            var data = _db.SP_GetProductOutInMonth();
            List<SP_GetProductOutInMonth_Result> result = new List<SP_GetProductOutInMonth_Result>();
            if (data != null)
            {
                foreach (SP_GetProductOutInMonth_Result item in data)
                    result.Add(item);
                return Task.FromResult(result);
            }
            return Task.FromResult(result);

        }
        public Task<List<SP_GetProductOutInWeek_Result>> getProductOutInWeek()
        {

            var data = _db.SP_GetProductOutInWeek();
            List<SP_GetProductOutInWeek_Result> result = new List<SP_GetProductOutInWeek_Result>();
            if (data != null)
            {
                foreach (SP_GetProductOutInWeek_Result item in data)
                    result.Add(item);
                return Task.FromResult(result);
            }
            return Task.FromResult(result);

        }
        public Task<List<SP_getAllProductIDAndName_Result>> getAllProductIDAndName_Results()
        {
            var data = _db.SP_getAllProductIDAndName();
            List<SP_getAllProductIDAndName_Result> results = new List<SP_getAllProductIDAndName_Result>();
            if (data != null)
            {
                foreach (SP_getAllProductIDAndName_Result item in data)
                    results.Add(item);
                return Task.FromResult(results);
            }
            return Task.FromResult(results);
        }
    }
}
