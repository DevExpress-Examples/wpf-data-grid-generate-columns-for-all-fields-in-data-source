using System.Data;

namespace AutoPopulateColumns {
    public class SimpleData {
        static DataTable dt = new DataTable();
        public static DataView Numbers {
            get {
                if(dt.Rows.Count == 0) CreateSimpleData();
                return dt.DefaultView;
            }
        }
        static void CreateSimpleData() {
            dt.Columns.Add("col1");
            dt.Columns.Add("col2");
            dt.Rows.Add(new object[] { 1, "one" });
            dt.Rows.Add(new object[] { 2, "two" });
            dt.Rows.Add(new object[] { 3, "three" });
            dt.Rows.Add(new object[] { 4, "four" });
            dt.Rows.Add(new object[] { 5, "five" });
        }
    }
}
