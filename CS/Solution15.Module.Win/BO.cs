using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using System.Drawing;
using DevExpress.Xpo.Metadata;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.ExpressApp.SystemModule;

namespace Solution15.Module {

    [NavigationItem]
    [OptimisticLocking(false)]
    public class Employees : XPBaseObject {
        public string Address;
        public DateTime BirthDate;
        public string City;
        public string Country;
        [Key]
        public int EmployeeID;
        public string Extension;
        public string FirstName;
        public DateTime HireDate;
        public string HomePhone;
        public string LastName;
        public string Notes;
        [ValueConverter(typeof(ImageValueConverter))]
        public Image Photo;
        public string PostalCode;
        public string Region;
        public int ReportsTo;
        public string Title;
        public string TitleOfCourtesy;
        public Employees(Session session)
            : base(session) {
        }
    }

}
