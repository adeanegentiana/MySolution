using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace MySolution.Module.BusinessObjects {
    [DefaultClassOptions]
    [DefaultProperty(nameof(Title))]
    public class Department : BaseObject {
        public virtual string Title { get; set; }

        public virtual string Office { get; set; }

        public virtual IList<Employee> Employees { get; set; } = new ObservableCollection<Employee>();

    }
}