using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Controllers.StatisticalServices
{
    interface IStatisticalService
    {
        /// <summary>
        /// thống kê thu theo tháng
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetInMoneyByOrderInMonth_Result>> getMoneyOrderInMonth();
        /// <summary>
        /// thống kê thu theo tuần 
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetInMoneyByOrderInWeek_Result>> getMoneyOrderInWeek();
        /// <summary>
        /// thống kê thu theo quý
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetInMoneyByOrderInQuarter_Result>> getMoneyOrderInQuarter();
        /// <summary>
        /// thống kê Thu theo tháng
        /// </summary>
        /// <returns></returns>
        /// 
        Task<List<SP_GetInMoneyByOrderInMonth_Result>> getInMoneyByOrderInMonth_Results();
        /// <summary>
        /// Thống kê chi theo tuần
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetMoneyOutByGRNInWeek_Result>> getMoneyOutByGRNInWeek_Results();
        /// <summary>
        /// Thống Kê Chi theo Quý
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetMoneyOutByGRNInQuarter_Result>> getMoneyOutByGRNInQuarter_Results();
        /// <summary>
        /// Thống Kê chi Theo Tháng
        /// </summary>
        /// <returns></returns>
        Task<List<SP_GetMoneyOutByGRNInMonth_Result> > getMoneyOutByGRNInMonth_Result();
        /// <summary>
        /// Thống kê hàng hóa
        /// </summary>
        /// <returns></returns>
        Task<List<SP_CountProReceivedByNameInMonth_Result>> GetCountProReceivedByNameInMonth_Results();
        Task<List<SP_CountProReceivedByNameInWeek_Result>>
            GetCountProReceivedByNameInWeek_Results();
        Task<List<SP_CountProReceivedByNameInQuarter_Result>>
            GetCountProReceivedByNameInQuarter_Results();

         Task<List<SP_GetProductOutInDay_Result>> getProductOutInDay();
        Task<List<SP_GetProductOutInMonth_Result>> getProductOutInMonth();
        Task<List<SP_GetProductOutInWeek_Result>> getProductOutInWeek();
        Task<List<SP_getAllProductIDAndName_Result>> getAllProductIDAndName_Results();


    }
}
