using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using EntityLayer;
using System.Data.Entity.Core.Objects;
using DataAccessLayer.Repository;
using System.Data.Entity;
using System.Windows.Forms;
namespace DataAccessLayer
{
    public class InventoryMasterDAL : SpaPracticeEntities
    {

        /// <summary>
        /// For performing godown operations
        /// </summary>
        /// <param name="ddlBranch"></param>
        #region === bind branch
        public void BindBranch(ComboBox ddlBranch)
        {
            try
            {
                List<tblbranch> servicelist = new List<tblbranch>();
                var data = (from p in tblbranches
                            select new
                            {
                                BranchCode = p.BranchID,
                                BranchName = p.BranchName


                            }).ToList();

                if (servicelist != null  )
                {

                    ddlBranch.Items.Clear();

                    ddlBranch.DataSource = servicelist;
                    ddlBranch.ValueMember = "BranchID";
                    ddlBranch.DisplayMember = "BranchName";
                    ddlBranch.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

            }

          



        }
        #endregion
        #region insert operation in godown
        public int InsertGodown(int BranchCode,string description, bool MainGodown,int UserCode)
        {
            tblgodown gd = new tblgodown();

            try
            {
                
             
                gd.BranchCd = BranchCode;
                gd.Description = description;
                gd.MainGodown = MainGodown;
                gd.ACTIVEYN = true;
                gd.EntryDate = DateTime.Now;
                gd.UserCode = UserCode;
                tblgodowns.Add(gd);
                SaveChanges();
            }
            catch (Exception ex)
            {
            }
            return gd.Code;

            


        }
        #endregion
        #region === update godown
        public int UpdateGodown(int Code,int BranchCode, string description, bool MainGodown, int UserCode,bool Activeyn)
        {
           // tblgodown gd = new Repository.tblgodown();
            tblgodown gd = tblgodowns.SingleOrDefault(p => p.Code == Code);
            try
            {

               
                gd.BranchCd = BranchCode;
                gd.Description = description;
                gd.MainGodown = MainGodown;
                gd.ACTIVEYN = Activeyn;
                gd.EntryDate = DateTime.Now;
                gd.UserCode = UserCode;
              
                SaveChanges();
                
            }
            catch (Exception ex)
            {
            }
            return gd.Code;

            

        }
        #endregion

        #region === bind godown in datagrid
        public void BindList(DataGrid grdGodown, int BranchID,bool ISAdmin)
        {
            try
            {
                List<tblgodown> servicelist = new List<tblgodown>();
                if (!ISAdmin)
                {
                    var data = (from p in tblgodowns.Where(p => p.BranchCd == BranchID)
                                orderby p.Description
                                select p
                               ).ToList();
                }
                else
                {
                    var data = (from p in tblgodowns
                                orderby p.Description
                                select p
                               ).ToList();
                }
                if (servicelist != null)
                {
                    grdGodown.DataSource = null;
                    grdGodown.DataSource = servicelist;
                }
            }
            catch (Exception ex)
            {

            }





        }
        #endregion



    }
}
