using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataTableEditable.Models;

namespace DataTableEditable.Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult Index()
        {
            var companies = DataRepository.GetCompanies();
            return View(companies);
        }

        public ActionResult Ajax()
        {
            return View();
        }

        public ActionResult Customization()
        {
            var companies = DataRepository.GetCompanies();
            return View(companies);
        }

        public ActionResult IndividualColumnEditing()
        {
            var companies = DataRepository.GetCompanies();
            return View(companies);
        }

        #region Ajax Data Provider

        public ActionResult AjaxDataProvider(JQueryDataTableParamModel param)
        {
            var allCompanies = DataRepository.GetCompanies();
            IEnumerable<Company> filteredCompanies;
            if (!string.IsNullOrEmpty(param.sSearch))
            {
                //Used if particulare columns are filtered 
                var nameFilter = Convert.ToString(Request["sSearch_1"]);
                var addressFilter = Convert.ToString(Request["sSearch_2"]);
                var townFilter = Convert.ToString(Request["sSearch_3"]);

                //Optionally check whether the columns are searchable at all 
                var isNameSearchable = Convert.ToBoolean(Request["bSearchable_1"]);
                var isAddressSearchable = Convert.ToBoolean(Request["bSearchable_2"]);
                var isTownSearchable = Convert.ToBoolean(Request["bSearchable_3"]);

                filteredCompanies = DataRepository.GetCompanies()
                   .Where(c => isNameSearchable && c.Name.ToLower().Contains(param.sSearch.ToLower())
                               ||
                               isAddressSearchable && c.Address.ToLower().Contains(param.sSearch.ToLower())
                               ||
                               isTownSearchable && c.Town.ToLower().Contains(param.sSearch.ToLower()));
            }
            else
            {
                filteredCompanies = allCompanies;
            }

            var isNameSortable = Convert.ToBoolean(Request["bSortable_1"]);
            var isAddressSortable = Convert.ToBoolean(Request["bSortable_2"]);
            var isTownSortable = Convert.ToBoolean(Request["bSortable_3"]);
            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            Func<Company, string> orderingFunction = (c => sortColumnIndex == 1 && isNameSortable ? c.Name :
                                                          sortColumnIndex == 2 && isAddressSortable ? c.Address :
                                                          sortColumnIndex == 3 && isTownSortable ? c.Town :
                                                          "");

            var sortDirection = Request["sSortDir_0"]; // asc or desc
            if (sortDirection == "asc")
                filteredCompanies = filteredCompanies.OrderBy(orderingFunction);
            else
                filteredCompanies = filteredCompanies.OrderByDescending(orderingFunction);

            var displayedCompanies = filteredCompanies.Skip(param.iDisplayStart).Take(param.iDisplayLength);
            var result = from c in displayedCompanies select new[] { Convert.ToString(c.ID), c.Name, c.Address, c.Town };
            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = allCompanies.Count(),
                iTotalDisplayRecords = filteredCompanies.Count(),
                aaData = result
            },
                        JsonRequestBehavior.AllowGet);
        }


        #endregion


        #region "CRUD operations"


        /// <summary>
        /// Method called but plugin when a row is deleted
        /// </summary>
        /// <param name="id">Id of the row</param>
        /// <returns>"ok" if delete is successfully performed - any other value will be considered as an error mesage on the client-side</returns>
        public string DeleteData(int id)
        {
            try
            {
                var company = DataRepository.GetCompanies().FirstOrDefault(c => c.ID == id);
                if (company == null)
                    return "Company cannot be found";
                DataRepository.GetCompanies().Remove(company);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        /// <summary>
        /// Action that updates data
        /// </summary>
        /// <param name="id">Id of the record</param>
        /// <param name="value">Value that shoudl be set</param>
        /// <param name="rowId">Id of the row</param>
        /// <param name="columnPosition">Position of the column(hidden columns are not counted)</param>
        /// <param name="columnId">Position of the column(hidden columns are counted)</param>
        /// <param name="columnName">Name of the column</param>
        /// <returns>value if update suceed - any other value will be considered as an error message on the client-side</returns>
        public string UpdateData(int id, string value, int? rowId, int? columnPosition, int? columnId, string columnName)
        {
            var companies = DataRepository.GetCompanies();

            if (columnPosition == 0 && companies.Any(c => c.Name.ToLower().Equals(value.ToLower())))
                return "Company with a name '" + value + "' already exists";
            var company = companies.FirstOrDefault(c => c.ID == id);
            if (company == null)
            {
                return "Company with an id = " + id + " does not exists";
            }
            switch (columnPosition)
            {
                case 0:
                    company.Name = value;
                    break;
                case 1:
                    company.Address = value;
                    break;
                case 2:
                    company.Town = value;
                    break;
                default:
                    break;
            }
            return value;
        }

        public int AddData(string name, string address, string town, int? country)
        {
            var companies = DataRepository.GetCompanies();
            if (companies.Any(c => c.Name.ToLower().Equals(name.ToLower())))
            {
                Response.Write("Company with the name '" + name + "' already exists");
                Response.StatusCode = 404;
                Response.End();
                return -1;
            }

            var company = new Company();
            company.Name = name;
            company.Address = address;
            company.Town = town;
            companies.Add(company);
            return company.ID;
        }

        public JsonResult getTownList()
        {
            var town = DataRepository.getTown();
            var list = town.Select(c => new[] { c.Name.ToString(), c.Name.ToString() });
            return Json(list);
        }
        #endregion
    }

    /// <summary>
    /// Class that encapsulates most common parameters sent by DataTables plugin
    /// </summary>
    public class JQueryDataTableParamModel
    {
        /// <summary>
        /// Request sequence number sent by DataTable, same value must be returned in response
        /// </summary>       
        public string sEcho { get; set; }

        /// <summary>
        /// Text used for filtering
        /// </summary>
        public string sSearch { get; set; }

        /// <summary>
        /// Number of records that should be shown in table
        /// </summary>
        public int iDisplayLength { get; set; }

        /// <summary>
        /// First record that should be shown(used for paging)
        /// </summary>
        public int iDisplayStart { get; set; }

        /// <summary>
        /// Number of columns in table
        /// </summary>
        public int iColumns { get; set; }

        /// <summary>
        /// Number of columns that are used in sorting
        /// </summary>
        public int iSortingCols { get; set; }

        /// <summary>
        /// Comma separated list of column names
        /// </summary>
        public string sColumns { get; set; }


    }
}
