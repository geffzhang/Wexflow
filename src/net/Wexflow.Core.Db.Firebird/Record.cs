﻿namespace Wexflow.Core.Db.Firebird
{
    public class Record : Core.Db.Record
    {

        public static readonly string ColumnName_Id = "ID";
        public static readonly string ColumnName_Name = "NAME";
        public static readonly string ColumnName_Description = "DESCRIPTION";
        public static readonly string ColumnName_Approved = "APPROVED";
        public static readonly string ColumnName_StartDate = "START_DATE";
        public static readonly string ColumnName_EndDate = "END_DATE";
        public static readonly string ColumnName_Comments = "COMMENTS";
        public static readonly string ColumnName_ManagerComments = "MANAGER_COMMENTS";
        public static readonly string ColumnName_CreatedBy = "CREATED_BY";
        public static readonly string ColumnName_CreatedOn = "CREATED_ON";
        public static readonly string ColumnName_ModifiedBy = "MODIFIED_BY";
        public static readonly string ColumnName_ModifiedOn = "MODIFIED_ON";
        public static readonly string ColumnName_AssignedTo = "ASSIGNED_TO";
        public static readonly string ColumnName_AssignedOn = "ASSIGNED_ON";

        public static readonly string TableStruct = "(" + ColumnName_Id + " integer generated by default as identity primary key, "
                                                        + ColumnName_Name + " VARCHAR(512), "
                                                        + ColumnName_Description + " BLOB SUB_TYPE TEXT, "
                                                        + ColumnName_Approved + " BOOLEAN, "
                                                        + ColumnName_StartDate + " TIMESTAMP, "
                                                        + ColumnName_EndDate + " TIMESTAMP, "
                                                        + ColumnName_Comments + " BLOB SUB_TYPE TEXT, "
                                                        + ColumnName_ManagerComments + " BLOB SUB_TYPE TEXT, "
                                                        + ColumnName_CreatedBy + " INTEGER, "
                                                        + ColumnName_CreatedOn + " TIMESTAMP, "
                                                        + ColumnName_ModifiedBy + " INTEGER, "
                                                        + ColumnName_ModifiedOn + " TIMESTAMP, "
                                                        + ColumnName_AssignedTo + " INTEGER, "
                                                        + ColumnName_AssignedOn + " TIMESTAMP)";

        public int Id { get; set; }

        public override string GetDbId()
        {
            return Id.ToString();
        }
    }
}
